using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire.Models.Buildings
{
    using Intefaces;
    using Resources;

    public class Barracks : Building
    {
        private const string BarracksUnitType = "Swordsman";
        private const int BarracksUnitCicleLength = 4;
        private const ResourceType BarracksResourceType = ResourceType.Steel;
        private const int BarracksResourceCicleLength = 3;
        private const int BarracksResourceQuantity = 10;
        
        public Barracks(IUnitFactory unitFactory, IResourceFactory resourceFactory)
            : base(BarracksUnitType, BarracksUnitCicleLength, BarracksResourceType, BarracksResourceCicleLength, BarracksResourceQuantity, 
                    unitFactory, resourceFactory)
        {
        }

        

        //public override IUnit CreateUnit(string unitType, int quantity)
        //{
        //    throw new NotImplementedException();
        //}

        //public override IResource CreateResource(ResourceType type, int quantity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
