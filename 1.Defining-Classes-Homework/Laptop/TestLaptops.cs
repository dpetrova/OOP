using System;

    class TestLaptops
    {
        static void Main()
        {
            Console.Write("Enter model: ");
            string model = Console.ReadLine();

            Console.Write("Enter manufacturer: ");
            string manufacturer = Console.ReadLine();

            Console.Write("Enter processor: ");
            string processor = Console.ReadLine();

            Console.Write("Enter RAM in GB: ");
            string ramAsString = Console.ReadLine();
            int ram;
            bool isIntRam = int.TryParse(ramAsString, out ram);
            if (isIntRam)
            {
                ram = int.Parse(ramAsString);
            }            

            Console.Write("Enter graphic card: ");
            string graphicCard = Console.ReadLine();

            Console.Write("Enter HDD: ");
            string hddAsString = Console.ReadLine();
            int hdd;
            bool isIntHdd = int.TryParse(hddAsString, out hdd);
            if (isIntHdd)
            {
                hdd = int.Parse(hddAsString);
            }
            
            Console.Write("Enter screen size in inchs: ");
            string screenAsString = Console.ReadLine();
            double screen;
            bool isDoubleScreen = double.TryParse(screenAsString, out screen);
            if (isDoubleScreen)
            {
                screen = double.Parse(screenAsString);
            }
           
            Console.Write("Enter battery type: ");
            string batteryType = Console.ReadLine();

            Console.Write("Enter battery life in hours: ");
            string batteryLifeAsString = Console.ReadLine();
            double batteryLife;
            bool isDoubleBatteryLife = double.TryParse(batteryLifeAsString, out batteryLife);
            if (isDoubleBatteryLife)
            {
                batteryLife = double.Parse(batteryLifeAsString);
            }
            
            Console.Write("Enter price: ");
            string priceAsString = Console.ReadLine();
            decimal price;
            bool isDecimalPrice = decimal.TryParse(priceAsString, out price);
            if (isDecimalPrice)
            {
                price = decimal.Parse(priceAsString);
            }
            
            try
            {
                Battery battery = new Battery(batteryType, batteryLife);
                Laptop laptop = new Laptop(model, manufacturer, processor, ram, graphicCard, hdd, screen, battery, price);
                Console.WriteLine(laptop.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot create person object: " + ex);
            }


        }
    }

