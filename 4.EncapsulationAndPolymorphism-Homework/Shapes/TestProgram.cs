using System;

namespace Shapes
{
    class TestProgram
    {
        static void Main()
        {
            var shapes = new IShape[]
            {
                new Rectangle(12.5, 5),
                new Triangle(10, 5, 7, 6.4),
                new Circle(6.4),
                new Rhombus(5, 7.5)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("{0} -> Area: {1:F2}; Perimeter: {2:F2}", 
                                                    shape.GetType().Name, shape.CalculateArea(), shape.CalculatePerimeter());
            }
            
        }
    }
}
