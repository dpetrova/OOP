using System;


namespace Shapes
{
    public class Triangle : BasicShape
    {
        private double cathetus1;
        private double cathetus2;
        
        public Triangle(double width, double height, double firstCathethus, double secondCathetus): base(width, height)
        {
            this.Cathetus1 = firstCathethus;
            this.Cathetus2 = secondCathetus;
        }

        public double Cathetus1
        {
            get { return this.cathetus1; }
            set
            {
                if (value.GetType().Name != "Double")
                {
                    throw new FormatException("Invalid format value!");
                }
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid value! Cathetus cannot be negative.");
                }
                this.cathetus1 = value;
            }
        }

        public double Cathetus2
        {
            get { return this.cathetus2; }
            set
            {
                if (value.GetType().Name != "Double")
                {
                    throw new FormatException("Invalid format value!");
                }
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid value! Cathetus cannot be negative.");
                }
                this.cathetus2 = value;
            }
        }
    
        public override double CalculateArea()
        {
            return (this.Width * this.Heigth) / 2;
        }

        public override double CalculatePerimeter()
        {
            return this.Cathetus1 + this.Cathetus2 + this.Width;
        }
    }
}
