using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire
{
    using Database;
    using Engine;

    class Program
    {
        static void Main()
        {
            var buildingFactory = new BuildingFactory();
            var unitFactory = new UnitFactory();
            var resourceFactory = new ResourceFactory();
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            var data = new EmpiresData();

            var engine = new Engine.Engine(buildingFactory, resourceFactory, unitFactory, data, reader, writer);
            engine.Run();


        }
    }
}
