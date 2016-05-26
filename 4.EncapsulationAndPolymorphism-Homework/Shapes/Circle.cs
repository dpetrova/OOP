using System;

namespace Shapes
{
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return this.radius; }
            set
            {
                if (value.GetType().Name != "Double")
                {
                    throw new FormatException("Invalid format value!");
                }
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid value! Radius cannot be negative.");
                }
                this.radius = value;
            }
        }
    
        public double CalculateArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }
    }
}
