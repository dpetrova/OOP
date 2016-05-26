using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS.Models.Attacks
{
    using Interfaces;

    public class Paris : Attack
    {
        public Paris(int damage)
            : base(damage)
        {
        }


        public override void Hit(IMilitantGroup targetGroup)
        {
            targetGroup.Health -= this.Damage;
        }

        
    }
}
