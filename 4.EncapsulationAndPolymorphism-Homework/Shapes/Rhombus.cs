using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rhombus : BasicShape
    {
        public Rhombus(double width, double height) : base(width, height)
        {
        }

        public override double CalculateArea()
        {
            return this.Width * this.Heigth;
        }

        public override double CalculatePerimeter()
        {
            return this.Width * 4;
        }
    }
}
