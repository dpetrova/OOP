using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS.Models.Attacks
{
    using Interfaces;

    public class SU24 : Attack
    {
        public SU24(int damage)
            : base(damage)
        {
        }

        public override void Hit(IMilitantGroup targetGroup)
        {
            //this.Group.Health -= this.Group.Health/2;
            targetGroup.Health -= this.Damage*2;
            
        }

        
    }
}
