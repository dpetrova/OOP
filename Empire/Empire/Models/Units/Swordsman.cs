using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire.Models.Units
{
    public class Swordsman : Unit
    {
        private const int SwordsmanHealth = 40;
        private const int SwordsmanAttackDamage = 13;

        public Swordsman() : base(SwordsmanHealth, SwordsmanAttackDamage)
        {
        }
    }
}
