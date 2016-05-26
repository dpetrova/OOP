using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassEffect.GameObjects.Projectiles
{
    using Interfaces;

    public class Laser : Projectile
    {
        public Laser(int damage) : base(damage)
        {
        }

        public override void Hit(IStarship targetShip)
        {
            if (this.Damage > targetShip.Shields)
            {
                targetShip.Health -= (this.Damage - targetShip.Shields);
            }

            targetShip.Shields -= this.Damage;
        }
    }
}
