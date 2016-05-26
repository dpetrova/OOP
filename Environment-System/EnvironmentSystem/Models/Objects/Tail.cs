using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentSystem.Models.Objects
{
    using DataStructures;

    public class Tail : EnvironmentObject
    {
        private const char DefaultTailCharacter = '*';
        private const int TailWidth = 1;
        private const int TailHeight = 1;

        private int lifetime;

        public Tail(int x, int y, int lifetime = 1) 
            : base(x, y, TailWidth, TailHeight)
        {
            this.lifetime = lifetime;
            this.ImageProfile = new char[,] { { DefaultTailCharacter } };
        }

        
        public override void Update()
        {
            this.lifetime--;
            if (lifetime <= 0)
            {
                this.Exists = false;
            }
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
