namespace MassEffect.Engine.Commands
{
    using System;
    using System.Linq;
    using Exceptions;
    using MassEffect.Interfaces;

    public class AttackCommand : Command
    {
        public AttackCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string attackerName = commandArgs[1];
            string targetName = commandArgs[2];

            var attackingShip = this.GameEngine.Starships
                .FirstOrDefault(s => s.Name == attackerName);
            var targetShip = this.GameEngine.Starships
                .FirstOrDefault(s => s.Name == targetName);

            this.ProcessStarshipBattle(attackingShip, targetShip);

        }

        private void ProcessStarshipBattle(IStarship attackingShip, IStarship targetShip)
        {
            this.ValidateAlive(attackingShip);
            this.ValidateAlive(targetShip);

            this.ValidateIsInTheSameStarSystem(attackingShip, targetShip);

            IProjectile attack = attackingShip.ProduceAttack();
            targetShip.RespondToAttack(attack);

            Console.WriteLine(Messages.ShipAttacked, attackingShip.Name, targetShip.Name);

            if (targetShip.Shields < 0)
            {
                targetShip.Shields = 0;
            }

            if (targetShip.Health < 0)
            {
                targetShip.Health = 0;
                Console.WriteLine(Messages.ShipDestroyed, targetShip.Name);
            }
        }

        
        private void ValidateAlive(IStarship ship)
        {
            if (ship.Health <= 0)
            {
                throw new ShipException(Messages.ShipAlreadyDestroyed);
            }
        }

        private void ValidateIsInTheSameStarSystem(IStarship attackingShip, IStarship targetShip)
        {
            if (attackingShip.Location != targetShip.Location)
            {
                throw new ShipException(Messages.NoSuchShipInStarSystem);
            }
        }
    }
}
