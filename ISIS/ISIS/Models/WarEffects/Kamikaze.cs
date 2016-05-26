using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS.Models.WarEffects
{
    using Interfaces;

    //Kamikaze - The group gains 50 health points. Each consecutive day the group loses 10 health points

    public class Kamikaze : WarEffect
    {
        //public Kamikaze(IMilitantGroup group) : base(group)
        //{
        //}

        //public override void TriggerEffect()
        //{
        //    this.Group.Health += 50;
        //}

        public override void TriggerEffect(IMilitantGroup group)
        {
            group.Health += 50;
        }
    }
}
