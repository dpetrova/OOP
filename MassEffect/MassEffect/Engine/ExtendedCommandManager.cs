using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassEffect.Engine
{
    using Commands;
    using Interfaces;

    public class ExtendedCommandManager : CommandManager
    {
        
        public override void SeedCommands()
        {
            base.SeedCommands();

            this.commandsByName["system-report"] = new SystemReportCommand(this.Engine);
        }
    }
}
