using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS.Engine
{
    using System.Text.RegularExpressions;
    using Commands;
    using Interfaces;

    public class CommandManager : ICommandManager
    {
        protected readonly Dictionary<string, Command> commandsByName;

        public CommandManager()
        {
            this.commandsByName = new Dictionary<string, Command>();
        }

        public IGameEngine Engine { get; set; }

        public void ProcessCommand(string commandString)
        {
            string input = Regex.Replace(commandString, @"\(", " ");
            input = Regex.Replace(input, @"\)", " ");
            input = Regex.Replace(input, @"\,", " ");
            input = Regex.Replace(input, @"\.", " ");
            input = Regex.Replace(input, @"\s+", " ");
            
            string[] commandArgs = input.Split(' ');
            string commandName = commandArgs[1];

            if (!this.commandsByName.ContainsKey(commandName))
            {
                throw new NotSupportedException(string.Format(
                    "Command {0} does not exist.", commandName));
            }

            var command = this.commandsByName[commandName];
            command.Execute(commandArgs);
        }

        public virtual void SeedCommands()
        {
            this.commandsByName["create"] = new CreateCommand(this.Engine);
            this.commandsByName["attack"] = new AttackCommand(this.Engine);
            this.commandsByName["status"] = new StatusCommand(this.Engine);
            //this.commandsByName["akbar"] = new AkbarCommand(this.Engine);
            this.commandsByName["apocalypse"] = new ApocalypseCommand(this.Engine);
        }


    }
}
