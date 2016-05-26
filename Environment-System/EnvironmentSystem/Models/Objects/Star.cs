using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentSystem.Models.Objects
{
    using DataStructures;

    public class Star : EnvironmentObject
    {
        private const char DefaultStarCharacter = 'O';
        private const int StarWidth = 1;
        private const int StarHeight = 1;
        private const int StarImageUpdateFrequence = 10;

        private static char[] StarImageProfiles = new char[]{'O', '0', '@'};
        private static Random randomizer = new Random();
        private int updateCount = 0;

        public Star(int x, int y)
            : base(x, y, StarWidth, StarHeight)
        {
            this.ImageProfile = new char[,]{ { DefaultStarCharacter } };
        }

        
        public override void Update()
        {
            if (this.updateCount == StarImageUpdateFrequence)
            {
                int index = randomizer.Next(0, StarImageProfiles.Length);
                this.ImageProfile =  new char[,]{ { StarImageProfiles[index] } };
                this.updateCount = 0;
            }
            this.updateCount++;
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            var hitObject = collisionInfo.HitObject;
            if (hitObject is Explosion)
            {
                this.Exists = false;
            }
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            return new List<EnvironmentObject>();
        }
    }
}
