using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentSystem.Models.Objects
{
    public class FallingStar : MovingObject
    {
        private const char DefaultFallingStarCharacter = 'O';
        private const int FallingStarWidth = 1;
        private const int FallingStarHeight = 1;

        public FallingStar(int x, int y, Point direction) 
            : base(x, y, FallingStarWidth, FallingStarHeight, direction)
        {
            this.ImageProfile = new char[,] { { DefaultFallingStarCharacter } };

        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            var hitObject = collisionInfo.HitObject;
            if (hitObject is Ground || hitObject is Snow || hitObject is Explosion)
            {
                this.Exists = false;
            }
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            var produedObjects = new List<EnvironmentObject>();
            produedObjects.Add(new Tail(this.Bounds.TopLeft.X - this.Direction.X, this.Bounds.TopLeft.Y - this.Direction.Y));
            produedObjects.Add(new Tail(this.Bounds.TopLeft.X - 2 * this.Direction.X, this.Bounds.TopLeft.Y - 2 * this.Direction.Y));
            produedObjects.Add(new Tail(this.Bounds.TopLeft.X - 3 * this.Direction.X, this.Bounds.TopLeft.Y - 3 * this.Direction.Y));

            return produedObjects;
        }
    }
}
