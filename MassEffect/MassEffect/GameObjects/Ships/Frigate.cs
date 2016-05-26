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

    public class Frigate : Starship
    {
        private const int FregateHealth = 60;
        private const int FregateShields = 50;
        private const int FregateDamage = 30;
        private const int FregateFuel = 220;

        private int projectilesFired;

        public Frigate(string name, StarSystem location)
            : base(name, location, FregateHealth, FregateShields, FregateDamage, FregateFuel)
        {
        }

        public override IProjectile ProduceAttack()
        {
            this.projectilesFired++;
            return new ShiledReaver(this.Damage);
        }
        
        public override string ToString()
        {
            var output =  base.ToString();
            
            if (this.Health > 0)
            {
                output += Environment.NewLine;
                output += String.Format("-Projectiles fired: {0}", this.projectilesFired);
            }

            return output;
        }
    }
}
