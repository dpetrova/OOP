using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS.Interfaces
{
    public interface ITriggered
    {
        IEnumerable<IWarEffect> TriggeredEffects { get; }

        void TriggerEffect(IWarEffect effect);
    }
}
