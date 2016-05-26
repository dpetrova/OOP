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

    public class Cruiser : Starship
    {
        private const int CruiserHealth = 100;
        private const int CruiserShields = 100;
        private const int CruiserDamage = 50;
        private const int CruiserFuel = 300;

        public Cruiser(string name, StarSystem location)
            : base(name, location, CruiserHealth, CruiserShields, CruiserDamage, CruiserFuel)
        {
        }

        public override IProjectile ProduceAttack()
        {
            return new PenetrationShell(this.Damage);
        }
        
    }
}
