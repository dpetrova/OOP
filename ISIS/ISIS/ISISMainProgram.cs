using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS
{
    using System.Text.RegularExpressions;
    using Engine;
    using Interfaces;
    using IO;

    class ISISMainProgram
    {
        static void Main()
        {
            ICommandManager commandManager = new CommandManager();
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            IGameEngine engine = new GameEngine(commandManager, reader, writer);
            engine.Run();
        }
    }
}
