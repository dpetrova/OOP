using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS.Engine.Commands
{
    using Interfaces;

    public class ApocalypseCommand : Command
    {
        public ApocalypseCommand(IGameEngine gameEngine) : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            this.GameEngine.IsRunning = false;
        }
    }
}
