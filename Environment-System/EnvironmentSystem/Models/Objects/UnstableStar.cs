using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentSystem.Models.Objects
{
    public class UnstableStar : FallingStar
    {
        private int lifetime;

        public UnstableStar(int x, int y, Point direction, int lifetime = 8) 
            : base(x, y, direction)
        {
            this.lifetime = lifetime;
        }

        public override void Update()
        {
            this.lifetime--;
            if (this.lifetime <= 0)
            {
                this.Exists = false;
            }

            base.Update();
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            if (this.Exists) //produce tail
            {
                return base.ProduceObjects();
            }
            else //produce explosion
            {
                var explosion = new List<EnvironmentObject>();
                for (int y = this.Bounds.TopLeft.Y - 2; y <= this.Bounds.TopLeft.Y + 2; y++)
                {
                    for (int x = this.Bounds.TopLeft.X - 2; x <= this.Bounds.TopLeft.X + 2; x++)
                    {
                        if (!(x == this.Bounds.TopLeft.X && y == this.Bounds.TopLeft.Y))
                        {
                            explosion.Add(new Explosion(x, y));
                        }
                    }
                }
                return explosion;
            }
        }


    }
}
