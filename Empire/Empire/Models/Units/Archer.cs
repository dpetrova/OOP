using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire.Models.Units
{
    public class Archer : Unit
    {
        private const int ArcherHealth = 25;
        private const int ArcherAttackDamage = 7;

        public Archer() : base(ArcherHealth, ArcherAttackDamage)
        {
        }
    }
}
