using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS.Models.WarEffects
{
    using Interfaces;

    //Jihad - doubles the group’s damage. Each consecutive day the group loses 5 damage points.
    //The damage cannot fall below its initial value (the damage before the effect was toggled)

    public class Jihad : WarEffect
    {
        //public Jihad(IMilitantGroup group) : base(group)
        //{
        //}

        //public override void TriggerEffect()
        //{
        //    this.Group.Damage *= 2;
        //}


        public override void TriggerEffect(IMilitantGroup group)
        {
            group.Damage *= 2;
        }
    }
}
