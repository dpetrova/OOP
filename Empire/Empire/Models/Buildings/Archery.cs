using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire.Models.Buildings
{
    using Intefaces;
    using Resources;

    public class Archery : Building
    {
        private const string ArcheryUnitType = "Archer";
        private const int ArcheryUnitCicleLength = 3;
        private const ResourceType ArcheryResourceType = ResourceType.Gold;
        private const int ArcheryResourceCicleLength = 2;
        private const int ArcheryResourceQuantity = 5;
        
        public Archery(IUnitFactory unitFactory, IResourceFactory resourceFactory)
            : base(ArcheryUnitType, ArcheryUnitCicleLength, ArcheryResourceType, ArcheryResourceCicleLength, ArcheryResourceQuantity,
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
