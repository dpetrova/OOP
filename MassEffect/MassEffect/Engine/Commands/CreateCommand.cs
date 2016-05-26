namespace MassEffect.Engine.Commands
{
    using System;
    using System.Linq;
    using Exceptions;
    using GameObjects.Enhancements;
    using GameObjects.Ships;
    using MassEffect.Interfaces;

    public class CreateCommand : Command
    {
        public CreateCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] args)
        {
            string type = args[1];
            string shipName = args[2];
            string locationName = args[3];

            bool shipAlreadyExists = this.GameEngine.Starships
                .Any(s => s.Name == shipName);

            if (shipAlreadyExists)
            {
                throw new ShipException(Messages.DuplicateShipName);
            }

            var location = this.GameEngine.Galaxy.GetStarSystemByName(locationName);
            var shipType = (StarshipType) Enum.Parse(typeof (StarshipType), type);

            var ship = this.GameEngine.ShipFactory.CreateShip(shipType, shipName, location);
            
            for (int i = 4; i < args.Length; i++)
            {
                var enhancementType = (EnhancementType) Enum.Parse(typeof (EnhancementType), args[i]);
                var enhancement = this.GameEngine.EnhancementFactory.Create(enhancementType);
                ship.AddEnhancement(enhancement);
            }

            this.GameEngine.Starships.Add(ship);

            Console.WriteLine(Messages.CreatedShip, shipType, shipName);

        }
    }
}
