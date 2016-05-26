using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class TestPoint3D
    {
        static void Main(string[] args)
        {
            //test Problem 1.Point3D
            Point3D myPoint = new Point3D(2, 4, 7);
            Point3D center = Point3D.StartingPoint;
            Console.WriteLine(myPoint);
            Console.WriteLine(center);

            //test Problem 2.Distance Calculator
            Point3D firstPoint = new Point3D(1, 2, 4);
            Point3D secondPoint = new Point3D(1.4, 4.9, 2);
            double dist = DistanceCalculator.CalcDistance(firstPoint, secondPoint);
            Console.WriteLine("The distance between the two points is {0:F}", dist);

            //test Problem 3.Paths
            Path3D myPath = new Path3D(myPoint, firstPoint, secondPoint, center);
            Console.WriteLine(myPath);
            Console.WriteLine("Save path: {0}", myPath);
            Storage.SavePathInFile("path.txt", myPath);
            Path3D loadPath = Storage.LoadPathFromFile("path.txt"); //the file is in: "2.Static-Members-and-Namespaces-Homework\Point3D\bin\Debug"
            Console.WriteLine("Load path: {0}", loadPath);
            
        }
    }
}
