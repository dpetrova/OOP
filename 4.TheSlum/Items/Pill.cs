using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Items
{
    public class Pill : Bonus
    {
        private const int HealthEffect = 0;
        private const int DefenseEffect = 0;
        private const int AttackEffect = 100;
        private const int Timeout = 1;

        public Pill(string id)
            : base(id, HealthEffect, DefenseEffect, AttackEffect, Timeout)
        {
        }
    }
}
