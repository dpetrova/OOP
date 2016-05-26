using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentSystem.Models.Objects
{
    using DataStructures;

    public class Snow : EnvironmentObject
    {
        private const char SnowCharacter = '.';
        private const int SnowWidth = 1;
        private const int SnowHeight = 1;

        public Snow(int x, int y)
            : base(x, y, SnowWidth, SnowHeight)
        {
            this.ImageProfile = new char[,]{ { SnowCharacter } };
        }

       
        public override void Update()
        {
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            return new List<EnvironmentObject>();
        }

        
    }
}
