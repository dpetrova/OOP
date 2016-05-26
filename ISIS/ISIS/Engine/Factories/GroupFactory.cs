using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS.Engine.Factories
{
    using Interfaces;
    using Models.MilitantGroups;

    public class GroupFactory
    {
        public IMilitantGroup CreateGroup(string name, int health, int damage, IWarEffect effect, IAttack attack)
        {
            return new MilitantGroup(name, health, damage, effect, attack);
        }


    }
}
