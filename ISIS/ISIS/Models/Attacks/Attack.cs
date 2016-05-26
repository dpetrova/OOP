using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS.Models.Attacks
{
    using Interfaces;

    public abstract class Attack : IAttack
    {
        private int damage;

        protected Attack(int damage)
        {
            this.Damage = damage;
           
        }

        //public IMilitantGroup Group { get; set; } 

        public int Damage
        {
            get { return this.damage; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Damage cannot be negative.");
                }
                this.damage = value;
            }

        }

        public abstract void Hit(IMilitantGroup targetGroup);
        
    }
}
