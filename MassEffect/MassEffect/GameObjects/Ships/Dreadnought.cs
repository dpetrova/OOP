using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassEffect.GameObjects.Ships
{
    using Interfaces;
    using Locations;
    using Projectiles;

    public class Dreadnought : Starship
    {
        private const int DreadnoughtHealth = 200;
        private const int DreadnoughtShields = 300;
        private const int DreadnoughtDamage = 150;
        private const int DreadnoughtFuel = 700;

        public Dreadnought(string name, StarSystem location) 
            : base(name, location, DreadnoughtHealth, DreadnoughtShields, DreadnoughtDamage, DreadnoughtFuel)
        {
        }

        public override IProjectile ProduceAttack()
        {
            return new Laser(this.Shields / 2 + this.Damage);
        }

        public override void RespondToAttack(IProjectile projectile)
        {
            this.Shields += 50;
            
            base.RespondToAttack(projectile);

            this.Shields -= 50;
        }
    }
}
