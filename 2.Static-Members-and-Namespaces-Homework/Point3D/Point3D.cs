using System;


namespace Point3D
{
    class Point3D
    {
        private double x;
        private double y;
        private double z;
        private static readonly Point3D startingPoint;

        public Point3D(double xCoord, double yCoord, double zCoord)
        {
            this.X = xCoord;
            this.Y = yCoord;
            this.Z = zCoord;
        }

        public double X 
        {
            get {return this.x; }
            set {this.x = value; }
        }

        public double Y
        {
            get {return this.y; }
            set {this.y = value; }
        }

        public double Z
        {
            get {return this.z; }
            set {this.z = value; }
        }

        public static Point3D StartingPoint
        {
            get { return Point3D.startingPoint; }
        }
        
        static Point3D()
        {
            Point3D.startingPoint = new Point3D(0, 0, 0);            
        }

        public override string ToString()
        {
            return String.Format("Point({0},{1},{2})", this.X, this.Y, this.Z);
        }

    }
}
