using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassEffect.Engine.Commands
{
    using Interfaces;

    public class SystemReportCommand : Command
    {
        public SystemReportCommand(IGameEngine gameEngine) : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string locationName = commandArgs[1];
            var location = this.GameEngine.Galaxy.StarSystems
                .FirstOrDefault(s => s.Name == locationName);

            IEnumerable<IStarship> intactShips = this.GameEngine.Starships
                .Where(s => s.Location == location && s.Health > 0)
                .OrderByDescending(s => s.Health)
                .ThenByDescending(s => s.Shields);

            StringBuilder output = new StringBuilder();
            output.AppendLine("Intact ships:");
            output.AppendLine(intactShips.Any() ? String.Join("\n", intactShips) : "N/A");

            IEnumerable<IStarship> destroyedShips = this.GameEngine.Starships
                .Where(s => s.Location == location && s.Health <= 0)
                .OrderBy(s => s.Name);

            output.AppendLine("Destroyed ships:");
            output.AppendLine(destroyedShips.Any() ? String.Join("\n", destroyedShips) : "N/A");

            Console.WriteLine(output.ToString());
        }
    }
}
