using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGgame.Characters
{
    public class Mage : Character
    {
        public Mage() : base(100, 300, 75)
        {
        }

        public override void Attack(Character target)
        {
            this.Mana -= 100;
            target.Health -= 2 * this.Damage;
        }
    }
}
