using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS.Engine.Commands
{
    using Interfaces;

    public class AttackCommand : Command
    {
        public AttackCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string attacker = commandArgs[0];
            string target = commandArgs[2];

            var attackingGroup = this.GetGroupByName(attacker);
            var targetGroup = this.GetGroupByName(target);

            this.ProcessAttack(attackingGroup, targetGroup);
        }

        private void ProcessAttack(IMilitantGroup attacker, IMilitantGroup target)
        {
            this.ValidateAlive(attacker);
            this.ValidateAlive(target);

            var attack = attacker.Attack;
            if (attack.GetType().Name == "SU24")
            {
                attacker.Health -= attacker.Health/2;
                if (attacker.Health <= 0)
                {
                    attacker.Health = 0;
                }
            }
            target.RespondToAttack(attack);
            

            Console.WriteLine(Messages.AttackGroup, attacker.Name, target.Name); //Group Petya toggled Jihad

            if (target.Health <= 0)
            {
                target.Health = 0;
                Console.WriteLine(Messages.GroupDestroyed, target.Name); //Group Petya was killed
            }
        }
    }
}
