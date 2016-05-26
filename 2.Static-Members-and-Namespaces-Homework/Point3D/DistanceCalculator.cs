using System;

namespace Point3D
{
    static class DistanceCalculator
    {
        public static double CalcDistance(Point3D point1, Point3D point2)
        {
            double deltaX = point1.X - point2.X;
            double deltaY = point1.Y - point2.Y;
            double deltaZ = point1.Z - point2.Z;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
            return distance; 
        }
    }
}
