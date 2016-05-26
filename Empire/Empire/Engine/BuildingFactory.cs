using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire.Engine
{
    using Intefaces;
    using Models.Buildings;
    using Models.Units;

    public class BuildingFactory : IBuildingFactory
    {
        public IBuilding CreateBuilding(string buildingType, IUnitFactory unitFactory, IResourceFactory resourceFactory)
        {
            switch (buildingType)
            {
                case "archery":
                    return new Archery(unitFactory, resourceFactory);
                case "barracks":
                    return new Barracks(unitFactory, resourceFactory);
                default:
                    throw new ArgumentException("Unknown building type.");        
            }
        }
    }
}
