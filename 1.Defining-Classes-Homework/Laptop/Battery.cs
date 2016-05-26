using System;

    class Battery
    {
        private string batteryType;
        private double batteryLife;

        public Battery()
            : this(batteryType: null, batteryLife: 0)
        {
        } 

        public Battery(string batteryType, double batteryLife)
        {
            this.BatteryType = batteryType;
            this.BatteryLife = batteryLife;
        }
        

        public string BatteryType
        {
            get { return this.batteryType; }
            set 
            {
                if (!String.IsNullOrEmpty(value) && String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid value for battery!");
                }
                this.batteryType = value;
            }
        }

        public double BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Battery life cannot be negative!");
                }
                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Model: {0} / Life: {1} hours", this.batteryType, this.batteryLife);
        }
    }

