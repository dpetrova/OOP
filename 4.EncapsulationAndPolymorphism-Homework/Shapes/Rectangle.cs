﻿using System;


namespace Shapes
{
    public class Rectangle : BasicShape
    {
        public Rectangle(double width, double height): base(width, height)
        {
            
        }
    
        public override double CalculateArea()
        {
            return this.Width * this.Heigth;
        }

        public override double CalculatePerimeter()
        {
            return this.Width * 2 + this.Heigth * 2;
        }
    }
}
