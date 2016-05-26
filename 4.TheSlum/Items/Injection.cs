using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Items
{
    public class Injection : Bonus
    {
        private const int HealthEffect = 200;
        private const int DefenseEffect = 0;
        private const int AttackEffect = 0;
        private const int Timeout = 3;

        public Injection(string id)
            : base(id, DefenseEffect, AttackEffect, HealthEffect, Timeout)
        {
        }
    }
}
