using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS.Engine.Commands
{
    using Interfaces;
    using Models.Attacks;
    using Models.WarEffects;

    public class CreateCommand : Command
    {
        public CreateCommand(IGameEngine gameEngine) : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string name = commandArgs[0];
            string health = commandArgs[2];
            string damage = commandArgs[3];
            string effect = commandArgs[4];
            string attack = commandArgs[5];

            bool groupAlreadyExists = this.GameEngine.MilitantGroups
                .Any(s => s.Name == name);

            if (groupAlreadyExists)
            {
                throw new ArgumentException(Messages.DuplicateGroupName);
            }

            var effectType = (EffectType)Enum.Parse(typeof(EffectType), effect);
            var warEffect = this.GameEngine.EffectFactory.Create(effectType);

            var attackType = (AttackType)Enum.Parse(typeof(AttackType), attack);
            var battleAttack = this.GameEngine.AttackFactory.Create(attackType, int.Parse(damage));

            var group = this.GameEngine.GroupFactory.CreateGroup(name, int.Parse(health), int.Parse(damage), warEffect, battleAttack);
            this.GameEngine.MilitantGroups.Add(group);

            Console.WriteLine(Messages.CreatedGroup, group.Name, group.Health, group.Damage); //Group Cenko: 50 HP, 15 Damage
        }
    }
}
