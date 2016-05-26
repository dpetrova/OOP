using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire.Database
{
    using System.Collections;
    using Intefaces;
    using Models;
    using Models.Resources;

    public class EmpiresData : IEmpiresData
    {
        private readonly ICollection<IBuilding> buildings = new List<IBuilding>();
        //private readonly IDictionary<string, int> units = new Dictionary<string, int>();

        public EmpiresData()
        {
            this.Resources = new Dictionary<ResourceType, int>();
            this.Units = new Dictionary<string, int>();
            this.InitResources();
        }
        
        public IEnumerable<IBuilding> Buildings
        {
            get { return this.buildings; }
        }

        public IDictionary<string, int> Units { get; private set; }
        

       public IDictionary<ResourceType, int> Resources { get; private set; }

        public void AddBuilding(IBuilding building)
        {
            if (building == null)
            {
                throw new ArgumentNullException("building"); //nameof(building)
            }
            this.buildings.Add(building);
        }
        
        public void AddUnit(IUnit unit)
        {
            if (unit == null)
            {
                throw new ArgumentNullException("unit"); //nameof(unit)
            }

            var unitType = unit.GetType().Name; //it returns the name of the class

            if (!this.Units.ContainsKey(unitType))
            {
                this.Units.Add(unitType, 0);
            }

            this.Units[unitType]++;
        }

        private void InitResources()
        {
            var resourceTypes = Enum.GetValues(typeof(ResourceType));

            foreach (ResourceType resourceType in resourceTypes)
            {
                this.Resources.Add(resourceType, 0);
            }
        }

    }
}
