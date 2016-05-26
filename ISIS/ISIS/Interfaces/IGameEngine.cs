using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS.Interfaces
{
    using Engine.Factories;

    public interface IGameEngine
    {
        GroupFactory GroupFactory { get; }

        AttackFactory AttackFactory { get; }

        EffectFactory EffectFactory { get; }

        IList<IMilitantGroup> MilitantGroups { get; }

        ICommandManager CommandManager { get; }

        IInputReader Reader { get; }

        IOutputWriter Writer { get; }

        bool IsRunning { get; set; }

        void Run();
    }
}
