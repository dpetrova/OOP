using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS.Engine.Factories
{
    using Models.Attacks;

    public class AttackFactory
    {
        public Attack Create(AttackType attackType, int damage)
        {
            switch (attackType)
            {
                case AttackType.Paris:
                    return new Paris(damage);
                case AttackType.SU24:
                    return new SU24(damage);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
