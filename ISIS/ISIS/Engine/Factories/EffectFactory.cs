using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS.Engine.Factories
{
    using Interfaces;
    using Models.Attacks;
    using Models.WarEffects;

    public class EffectFactory
    {
        public WarEffect Create(EffectType effectType)
        {
            switch (effectType)
            {
                case EffectType.Jihad:
                    return new Jihad();
                case EffectType.Kamikaze:
                    return new Kamikaze();
                default:
                    throw new ArgumentException("There is not such effect type");
            }
        }
    }
}
