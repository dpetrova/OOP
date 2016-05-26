namespace MassEffect.Engine.Commands
{
    using System;
    using System.Linq;
    using Exceptions;
    using MassEffect.Interfaces;

    public class PlotJumpCommand : Command
    {
        public PlotJumpCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string shipName = commandArgs[1];
            string destinationName = commandArgs[2];

            var ship = this.GameEngine.Starships
                .FirstOrDefault(s => s.Name == shipName);

            this.ValidateAlive(ship);

            var previousLocation = ship.Location;

            var destination = this.GameEngine.Galaxy.GetStarSystemByName(destinationName);

            if (previousLocation.Name == destinationName)
            {
                throw new ShipException(String.Format(Messages.ShipAlreadyInStarSystem, destinationName));
            }

            this.GameEngine.Galaxy.TravelTo(ship, destination);

            Console.WriteLine(Messages.ShipTraveled, ship.Name, previousLocation.Name, destination.Name);
                
        }

        private void ValidateAlive(IStarship ship)
        {
            if (ship.Health <= 0)
            {
                throw new ShipException(Messages.ShipAlreadyDestroyed);
            }
        }
    }
}
