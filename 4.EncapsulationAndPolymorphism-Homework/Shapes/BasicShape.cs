using System;


namespace Shapes
{
    public abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        protected BasicShape(double width, double height)
        {
            this.Width = width;
            this.Heigth = height;
        }
        

        public double Width
        {
            get { return this.width; }
            set
            {
                if (value.GetType().Name != "Double")
                {
                    throw new FormatException("Invalid format value!");
                }
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid value! Width cannot be negative.");
                }
                this.width = value;
            }
        }

        public double Heigth
        {
            get { return this.height; }
            set
            {
                if (value.GetType().Name != "Double")
                {
                    throw new FormatException("Invalid format value!");
                }
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid value! Heigth cannot be negative.");
                }
                this.height = value;
            }
        }

        public abstract double CalculateArea();


        public abstract double CalculatePerimeter();
        
    }
}
