using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS.Engine.Commands
{
    using Interfaces;

    public class StatusCommand : Command
    {
        public StatusCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            var groups = this.GameEngine.MilitantGroups
                .OrderByDescending(g => g.Health)
                .ThenByDescending(g => g.Damage)
                .ToList();
            

            foreach (var group in groups)
            {
                Console.WriteLine(group.ToString());
            }
        }
    }
}
