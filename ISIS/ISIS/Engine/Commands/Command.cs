using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS.Engine.Commands
{
    using Exceptions;
    using Interfaces;

    public abstract class Command
    {
        protected Command(IGameEngine gameEngine)
        {
            this.GameEngine = gameEngine;
        }

        public IGameEngine GameEngine { get; set; }

        public abstract void Execute(string[] commandArgs);

        protected IMilitantGroup GetGroupByName(string name)
        {
            return this.GameEngine.MilitantGroups
                .First(s => s.Name == name);
        }

        protected void ValidateAlive(IMilitantGroup group)
        {
            if (group.Health <= 0)
            {
                throw new MilitanGroupsException(Messages.GroupDestroyed);
            }
        }
    }
}
