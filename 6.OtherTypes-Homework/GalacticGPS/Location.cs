using System;

namespace GalacticGPS
{
    public struct Location
    {
        private double latitude;
        private double longitude;
        private Planet planet;
       
        public Location(double latitude, double longitude, Planet planet): this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.planet = planet;
        }

        public double Latitude
        {
            get { return this.latitude; }
            set
            {
                if (value < 0 || value > 90)
                {
                    throw new ArgumentOutOfRangeException("Latitude is ranging from 0° at the Equator to 90° at the poles");
                }
                this.latitude = value;
            }
        }

        public double Longitude
        {
            get { return this.longitude; }
            set
            {
                if (value < -180 || value > 180)
                {
                    throw new ArgumentOutOfRangeException("Longitude is ranging from 0° at the Prime Meridian to +180° eastward and −180° westward");
                }
                this.longitude = value;
            }
        }

        public Planet Planet
        {
            get { return this.planet; }
            set
            {
                if (value.GetType() != typeof(Planet))
                {
                    throw new FormatException("Invalid planet.");
                }
                this.planet = value;
            }
        }
        

        public override string ToString()
        {
            string str = String.Format("{0}, {1} - {2}", this.Latitude, this.Longitude, this.Planet);
            return str;
        }
    }
}
