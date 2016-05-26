using System;

    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicCard;
        private int hdd;
        private double screen;
        private Battery battery;
        private decimal price;
        
        public Laptop(string model, decimal price): 
            this(        
                model: model,
                manufacturer: null,
                processor: null,
                ram: 0,
                graphicCard: null,
                hdd: 0,
                screen: 0.0,
                battery: null,
                price: price
                )
        {
        }
       
        
        public Laptop(string model, string manufacturer, string processor, int ram, string graphicCard,
                                                    int hdd, double screen, Battery battery, decimal price)            
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicCard = graphicCard;
            this.HDD = hdd;
            this.Screen = screen;
            this.Battery = battery;
            this.Price = price;
        }


        public string Model
        {
            get{return this.model;}
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be empty!");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (!String.IsNullOrEmpty(value) && String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid value for manufacturer!");
                }
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (!String.IsNullOrEmpty(value) && String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid value for processor!");
                }
                this.processor = value;
            }
        }

        public int RAM
        {
            get { return this.ram; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid value for RAM!");
                }
                this.ram = value;
            }
        }

        public string GraphicCard
        {
            get { return this.graphicCard; }
            set
            {
                if (!String.IsNullOrEmpty(value) && String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid value for graphic card!");
                }
                this.graphicCard = value;
            }
        }

        public int HDD
        {
            get { return this.hdd; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid value for HDD!");
                }
                this.hdd = value;
            }
        }

        public double Screen
        {
            get { return this.screen; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid value for screen!");
                }
                this.screen = value;
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid value for price!");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Model: {0}\n" +
                                 "Manufacturer: {1}\n" +
                                 "Processor: {2}\n" +
                                 "RAM: {3} GB\n" +
                                 "Graphics Card: {4}\n" +
                                 "HDD: {5} GB\n" +
                                 "Screen Size: {6} inches\n" +
                                 "Battery: {7}\n" +                                 
                                 "Price: {8} lv\n",
                                 this.Model,
                                 this.Manufacturer ?? "N/A", //The ?? operator is called the null-coalescing operator. It returns the left-hand operand if the operand is not null; otherwise it returns the right hand operand.
                                 this.Processor ?? "N/A",
                                 this.RAM != 0 ? this.RAM.ToString() : "N/A",
                                 this.GraphicCard ?? "N/A",
                                 this.HDD != 0 ? this.HDD.ToString() : "N/A",
                                 this.Screen != 0 ? this.Screen.ToString() : "N/A",
                                 this.Battery != null ? this.Battery.ToString() : "N/A",                                 
                                 this.Price);
        } 
    }

