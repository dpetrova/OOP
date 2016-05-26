using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS.Engine.Commands
{
    using Interfaces;

    public class AkbarCommand : Command
    {
        public AkbarCommand(IGameEngine gameEngine) : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            throw new NotImplementedException();
        }
    }
}
