﻿namespace EnvironmentSystem
{
    using EnvironmentSystem.Core;
    using EnvironmentSystem.Core.Generator;

    public class EnvironmentSystemMain
    {
        private const int WorldWidth = 50;
        private const int WorldHeight = 30;

        static void Main()
        {
            var objectGenerator = new ObjectGenerator(WorldWidth, WorldHeight);
            var consoleRenderer = new ConsoleRenderer(WorldWidth, WorldHeight);
            var collisionHandler = new CollisionHandler(WorldWidth, WorldHeight);
            var keyboardController = new KeyboardController();

            //var engine = new Engine(WorldWidth, 
            //    WorldHeight, 
            //    objectGenerator, 
            //    collisionHandler, 
            //    consoleRenderer);
            
            var engine = new ExtendedEngine(WorldWidth, 
                WorldHeight, 
                objectGenerator, 
                collisionHandler, 
                consoleRenderer,
                keyboardController);

            engine.Run();
        }
    }
}
