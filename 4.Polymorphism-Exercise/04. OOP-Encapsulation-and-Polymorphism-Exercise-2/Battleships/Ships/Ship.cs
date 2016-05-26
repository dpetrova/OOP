namespace Battleships.Ships
{
    using System;

    public abstract class Ship
    {
        private string name;
        private double length;
        private double volume;

        protected Ship(string name, double lenthInMeters, double volume)
        {
            this.Name = name;
            this.Length = lenthInMeters;
            this.Volume = volume;
        }

        public string Name
        {
            get { return this.name; }
            protected set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }
                this.name = value;
            }
        }

        public double Length
        {
            get { return this.length; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Length cannot be negative");
                }
                this.length = value;
            }
        }

        public double Volume
        {
            get { return this.volume; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Volume cannot be negative");
                }
                this.volume = value;
            }
        }

       public bool IsDestroyed { get; set; }
    }
}
