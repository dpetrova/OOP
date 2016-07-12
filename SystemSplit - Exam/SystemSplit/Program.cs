namespace SystemSplit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using SystemSplit.Factories;
    using SystemSplit.Models;

    public class Program
    {
        public static void Main()
        {
            List<Hardware> components = new List<Hardware>();
            List<Hardware> dump = new List<Hardware>();
            string input = Console.ReadLine();

            while (input != "System Split")
            {
                if (input.StartsWith("Register"))
                {
                    input = input.Replace("Register", String.Empty);
                    try
                    {
                        ComponentFactory.CreateComponent(input, components);
                    }
                    catch (ArgumentException ex)
                    {
                        //Console.WriteLine(ex.Message);
                    }
                }
                else if (input.StartsWith("Release"))
                {
                    ComponentDestroyer.DestroyComponent(input, components);
                }
                else if (input.StartsWith("Analyze"))
                {
                    Console.WriteLine(SystemAnalizator.AnalyzeSystem(components));
                }
                else if (input.StartsWith("Dump"))
                {
                    if (input.StartsWith("DumpAnalyze"))
                    {
                        Console.WriteLine(SystemAnalizator.AnalyzeDump(dump));
                    }
                    else
                    {
                        ComponentDestroyer.DumpComponent(input, components, dump);
                    }
                }
                else if (input.StartsWith("Restore"))
                {
                    ComponentDestroyer.RestoreComponent(input, components, dump);
                }
                else if (input.StartsWith("Destroy"))
                {
                    ComponentDestroyer.DestroyComponentPermanently(input, dump);
                }
                else
                {
                    throw new ArgumentException("Invalid input");
                }

                input = Console.ReadLine();
            }
            
            var orderedHardwareComponents = components.OrderByDescending(x => x.GetType().Name);

            foreach (var comp in orderedHardwareComponents)
            {
                Console.WriteLine("Hardware Component - " + comp.Name);
                Console.WriteLine("Express Software Components - " 
                    + comp.SoftwareComponents.Count(x => x.GetType().Name == "ExpressSoftware"));
                Console.WriteLine("Light Software Components - " 
                    + comp.SoftwareComponents.Count(x => x.GetType().Name == "LightSoftware"));
                Console.WriteLine("Memory Usage: {0} / {1}", comp.SoftwareComponents.Sum(x => x.MemoryConsumption), comp.MaxMemory);
                Console.WriteLine("Capacity Usage: {0} / {1}", comp.SoftwareComponents.Sum(x => x.CapacityConsumption), comp.MaxCapacity);
                Console.WriteLine("Type: " + comp.GetType().Name.Replace("Hardware", String.Empty));
                if (comp.SoftwareComponents.Any())
                {
                    Console.WriteLine("Software Components: " + string.Join(", ", comp.SoftwareComponents.Select(x => x.Name)));
                }
                else
                {
                    Console.WriteLine("Software Components: None");
                }
            }
        }
    }
}
