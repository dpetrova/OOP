using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Items
{
    public class Axe : Item
    {
        private const int HealthEffect = 0;
        private const int DefenseEffect = 0;
        private const int AttackEffect = 75;

        public Axe(string id) 
            : base(id, HealthEffect, DefenseEffect, AttackEffect)
        {
        }
    }
}
