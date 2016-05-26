using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassEffect.GameObjects.Projectiles
{
    using Interfaces;

    public class ShiledReaver : Projectile
    {
        public ShiledReaver(int damage) : base(damage)
        {
        }

        public override void Hit(IStarship targetShip)
        {
            targetShip.Health -= this.Damage;
            targetShip.Shields -= this.Damage*2;
        }
    }
}
