using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire.Intefaces
{
    using Models.Resources;

    public interface IEmpiresData
    {
        IEnumerable<IBuilding> Buildings { get; }

        void AddBuilding(IBuilding building);

        IDictionary<string, int> Units { get; }

        void AddUnit(IUnit unit);

        IDictionary<ResourceType, int> Resources { get; } 
    }
}
