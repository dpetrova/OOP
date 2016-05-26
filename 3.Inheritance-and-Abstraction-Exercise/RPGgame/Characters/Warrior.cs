using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGgame.Characters
{
    public class Warrior : Character
    {
        public Warrior() : base(300, 0, 120)
        {
        }

        public override void Attack(Character target)
        {
            target.Health -= this.Damage;
        }
    }
}
