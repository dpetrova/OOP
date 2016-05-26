using System;
using System.Collections.Generic;

class PCCatalog
{
    static void Main()
    {
        Computer asus = new Computer("Asus M12AD-RO016D", new List<Component>
                                  {new Component("Processor", "Intel® Core™ i5-4460S 2.90GHz", 700.00m),
                                   new Component("HDD", "1TB", 200.00m), 
                                   new Component("RAM", "4GB", 150.00m),
                                   new Component("Graphic card", "NVIDIA GeForce GTX 745 4GB", 459.00m),
                                  });

        Computer lenovo = new Computer("Lenovo IdeaCentre B50-30 All-In-One", new List<Component>
                                  {new Component("Processor", "Intel® Core™ i5-4460T 1.90GHz", 1200.00m),
                                   new Component("HDD", "1TB", 278.00m), 
                                   new Component("RAM", "8GB", 477.90m),
                                   new Component("Graphic card", "Intel® HD Graphics 4600", 999.00m),
                                  });

        Computer apple = new Computer("Apple Mac Pro", new List<Component>
                                  {new Component("Processor", " Intel® Xeon® E5-1650 v2", 3200.00m),
                                   new Component("HDD", 1240.00m), 
                                   new Component("RAM", "16GB", 700.90m),
                                   new Component("Graphic card", "FirePro™ D500", 2900.00m),
                                  });

        apple.AddComponent(new Component("SSD", "256GB", 1199.00m));
        

        List<Computer> computers = new List<Computer>(){asus, lenovo, apple};
        computers.Sort((a, b) => a.Price < b.Price ? -1 : a.Price > b.Price ? 1 : 0);

        foreach (var computer in computers)
        {
            Console.WriteLine(computer);
        }
    }
}

