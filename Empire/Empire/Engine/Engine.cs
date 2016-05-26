using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire.Engine
{
    using Intefaces;

    public class Engine : IRunnable
    {
        private IBuildingFactory buildingFactory;
        private IResourceFactory resourceFactory;
        private IUnitFactory unitFactory;
        private IEmpiresData data;
        private IInputReader reader;
        private IOutputWriter writer;

        public Engine(IBuildingFactory buildingFactory, IResourceFactory resourceFactory, IUnitFactory unitFactory,
                                                            IEmpiresData data, IInputReader reader, IOutputWriter writer)
        {
            this.buildingFactory = buildingFactory;
            this.resourceFactory = resourceFactory;
            this.unitFactory = unitFactory;
            this.data = data;
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            while (true)
            {
                string[] input = this.reader.ReadLine().Split();

                this.ExecuteCommand(input);
                this.UpdateBuildings();
            }
        }

        // Made method virtual and protected to allow extension (new commands)
        protected virtual void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "empire-status":
                    this.ExecuteStatusCommand();
                    break;
                case "armistice":
                    Environment.Exit(0);
                    break;
                case "skip":
                    break;
                case "build":
                    this.ExecuteBuildCommand(inputParams[1]);
                    break;
                default:
                    throw new ArgumentException("Unknown command.");
            }
        }
        
        private void ExecuteStatusCommand()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine("Treasury:");
            foreach (var resource in this.data.Resources)
            {
                output.AppendFormat("--{0}: {1}{2}", resource.Key, resource.Value, Environment.NewLine);
            }

            output.AppendLine("Buildings:");
            if (this.data.Buildings.Any())
            {
                foreach (IBuilding building in this.data.Buildings)
                {
                    output.AppendLine(building.ToString()); //we should override ToString() in Building class
                }
            }
            else
            {
                output.AppendLine("N/A");
            }

            output.AppendLine("Units:");
            if (this.data.Units.Any())
            {
                foreach (var unit in this.data.Units)
                {
                    output.AppendFormat("--{0}: {1}{2}", unit.Key, unit.Value, Environment.NewLine);
                }
            }
            else
            {
                output.AppendLine("N/A");
            }

            //it is good to make separate methods for these appends:
            //this.AppendTreasuryInfo(output);
            //this.AppendBuildingsInfo(output);
            //this.AppendUnitsInfo(output);

            this.writer.Print(output.ToString().Trim());
        }


        private void ExecuteBuildCommand(string buildingType)
        {
            IBuilding building =
                this.buildingFactory.CreateBuilding(buildingType, this.unitFactory, this.resourceFactory);

            this.data.AddBuilding(building);
        }


        private void UpdateBuildings()
        {
            foreach (IBuilding building in this.data.Buildings)
            {
                building.Update();

                if (building.CanProduceUnit)
                {
                    var unit = building.ProduceUnit();
                    this.data.AddUnit(unit);
                }

                if (building.CanProduceResource)
                {
                    var resource = building.ProduceResource();
                    this.data.Resources[resource.ResourceType] += resource.Quantity;
                }
            }
        }

        //private void AppendUnitsInfo(StringBuilder output)
        //{
        //    output.AppendLine("Units:");
        //    if (this.data.Units.Any())
        //    {
        //        foreach (var unit in this.data.Units)
        //        {
        //            output.AppendFormat("--{0}: {1}{2}", unit.Key, unit.Value, Environment.NewLine);
        //        }
        //    }
        //    else
        //    {
        //        output.AppendLine("N/A");
        //    }
        //}

        //private void AppendBuildingsInfo(StringBuilder output)
        //{
        //    output.AppendLine("Buildings:");
        //    if (this.data.Buildings.Any())
        //    {
        //        foreach (IBuilding building in this.data.Buildings)
        //        {
        //            output.AppendLine(building.ToString());
        //        }
        //    }
        //    else
        //    {
        //        output.AppendLine("N/A");
        //    }
        //}

        //private void AppendTreasuryInfo(StringBuilder output)
        //{
        //    output.AppendLine("Treasury:");
        //    foreach (var resource in this.data.Resources)
        //    {
        //        output.AppendFormat("--{0}: {1}{2}", resource.Key, resource.Value, Environment.NewLine);
        //    }
        //}
        
    }
}
