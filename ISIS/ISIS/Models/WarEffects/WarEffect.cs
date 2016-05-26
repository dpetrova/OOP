using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS.Models.WarEffects
{
    using Interfaces;

    public abstract class WarEffect : IWarEffect
    {
        //protected WarEffect(IMilitantGroup group)
        //{
        //    this.Group = group;
        //}

        //public IMilitantGroup Group { get; set; }

        public abstract void TriggerEffect(IMilitantGroup group);

    }
}
