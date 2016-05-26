using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.Ships
{
    using Interfaces;

    public abstract class Battleship : Ship, IAttack
    {
        protected Battleship(string name, double lenthInMeters, double volume) : base(name, lenthInMeters, volume)
        {
        }


        public void DestroyShip(Ship targetShip)
        {
            targetShip.IsDestroyed = true;
        }

        public virtual string Attack(Ship targetShip)
        {
           this.DestroyShip(targetShip);

           return "The target is destroyed.";
        }
        
    }
}
