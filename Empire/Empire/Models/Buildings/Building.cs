using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire.Models.Buildings
{
    using Intefaces;
    using Resources;

    public abstract class Building : IBuilding
    {
        private const int ProductionDelay = 1; //building begin produce 1 turn after it has been created

        private int cyclesCount = 0;
        private string unitType;
        private int unitCycleLength;
        private ResourceType resourceType;
        private int resourceCycleLength;
        private int resourceQuantity;
        private IUnitFactory unitFactory;
        private IResourceFactory resourceFactory;

        public Building(string unitType, int unitCycleLength, ResourceType resourceType, int resourceCycleLength,
                                        int resourceQuantity, IUnitFactory unitFactory, IResourceFactory resourceFactory)
        {
            this.unitType = unitType;
            this.unitCycleLength = unitCycleLength;
            this.resourceType = resourceType;
            this.resourceCycleLength = resourceCycleLength;
            this.resourceQuantity = resourceQuantity;
            this.unitFactory = unitFactory;
            this.resourceFactory = resourceFactory;
        }

        public bool CanProduceResource
        {
            get
            {
                bool canProduceResource = this.cyclesCount > ProductionDelay
                    && (this.cyclesCount - ProductionDelay) % this.resourceCycleLength == 0;

                return canProduceResource;
            }
        }

        public bool CanProduceUnit
        {
            get
            {
                bool canProduceUnit = this.cyclesCount > ProductionDelay
                    && (this.cyclesCount - ProductionDelay) % this.unitCycleLength == 0;

                return canProduceUnit;
            }
        }

        public IUnit ProduceUnit()
        {
            var unit = this.unitFactory.CreateUnit(this.unitType);
            return unit;
        }
        
        public IResource ProduceResource()
        {
            var resource = this.resourceFactory.CreateResource(this.resourceType, this.resourceQuantity);
            return resource;
        }
        
        public virtual void Update()
        {
            this.cyclesCount++;
            
        }


        public override string ToString()
        {
            int turnsUntilUnit = this.unitCycleLength - (this.cyclesCount - ProductionDelay) % this.unitCycleLength;
            int turnsUntilResource = this.resourceCycleLength - (this.cyclesCount - ProductionDelay) % this.resourceCycleLength;

            var result = string.Format(
                "--{0}: {1} turns ({2} turns until {3}, {4} turns until {5})",
                this.GetType().Name,
                this.cyclesCount - ProductionDelay,
                turnsUntilUnit,
                this.unitType,
                turnsUntilResource,
                this.resourceType);

            return result;
        }
        

        

        //public string UnitType
        //{
        //    get { return this.unitType; }
        //    set
        //    {
        //        if (string.IsNullOrWhiteSpace(value))
        //        {
        //            throw new ArgumentNullException("UnitType", "The unit type cannot be null or white space.");
        //        }
        //        this.unitType = value;
        //    }
        //}

        //public ResourceType ResourceType
        //{
        //    get { return this.resourceType; }
        //    set { this.resourceType = value; }
        //}

        //public int UnitCicleLength
        //{
        //    get { return this.unitCycleLength; }
        //    set 
        //    {
        //        if (value < 1)
        //        {
        //            throw new ArgumentOutOfRangeException("UnitCicleLength", "The length of the production cycle for units should be positive.");
        //        }
        //        this.unitCycleLength = value; 
        //    }
        //}

        //public int ResourceCicleLength
        //{
        //    get { return this.resourceCycleLength; }
        //    set
        //    {
        //        if (value < 1)
        //        {
        //            throw new ArgumentOutOfRangeException("ResourceCicleLength", "The length of the production cycle for resource should be positive.");
        //        }
        //        this.resourceCycleLength = value;
        //    }
        //}

        //public int UnitQuantity
        //{
        //    get { return this.unitsQuantity; }
        //    set {
        //            if (value < 1)
        //            {
        //                throw new ArgumentOutOfRangeException("UnitQuantity", "The units quantity should be positive.");
        //            }
        //            this.unitsQuantity = value; 
        //        }
        //}

        //public int ResourceQuantity
        //{
        //    get { return this.resourceQuanitity; }
        //    set
        //    {
        //        if (value < 1)
        //        {
        //            throw new ArgumentOutOfRangeException("ResourceQuantity", "The resource quantity should be positive.");
        //        }
        //        this.resourceQuanitity = value;
        //    }
        //}

        //public bool AbleToProduce
        //{
        //    get { return this.ableToProduce; }
        //}

        //public abstract IUnit CreateUnit(string unitType, int quantity);


        //public abstract IResource CreateResource(ResourceType type, int quantity);


        
    }
}
