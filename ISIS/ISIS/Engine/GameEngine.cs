using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS.Engine
{
    using Exceptions;
    using Factories;
    using Interfaces;
    using IO;

    public sealed class GameEngine : IGameEngine
    {
        private IInputReader reader;
        private IOutputWriter writer;

        public GameEngine(ICommandManager commandManager, IInputReader reader, IOutputWriter writer)
        {
            this.CommandManager = commandManager;
            this.GroupFactory = new GroupFactory();
            this.AttackFactory = new AttackFactory();
            this.EffectFactory = new EffectFactory();
            this.MilitantGroups = new List<IMilitantGroup>();
            this.reader = reader;
            this.writer = writer;
        }

        public GroupFactory GroupFactory { get; private set; }

        public AttackFactory AttackFactory { get; private set; }

        public EffectFactory EffectFactory { get; private set; }

        public IList<IMilitantGroup> MilitantGroups { get; private set; }

        public ICommandManager CommandManager { get; private set; }

        public IInputReader Reader { get; private set; }

        public IOutputWriter Writer { get; private set; }

        public bool IsRunning { get; set; }

        public void Run()
        {
            this.IsRunning = true;
            this.CommandManager.Engine = this;
            this.CommandManager.SeedCommands();

            do
            {
                string command = this.reader.ReadLine();

                try
                {
                    this.CommandManager.ProcessCommand(command);
                    this.UpdateStatus();
                }
                catch (MilitanGroupsException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (this.IsRunning);
        }

        private void UpdateStatus()
        {
            foreach (IMilitantGroup group in this.MilitantGroups)
            {
                group.Update();
            }
        }
    }
}
