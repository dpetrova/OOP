namespace SystemSplit.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using SystemSplit.Models;

    public static class ComponentFactory
    {
        public static void CreateComponent(string input, List<Hardware> components)
        {
            string pattern = @"(\w+)\((.+)\)";
            Regex rgx = new Regex(pattern);

            if (!rgx.IsMatch(input))
            {
                throw new ArgumentException("Invalid input!");
            }

            Match match = rgx.Match(input);
            string componentType = match.Groups[1].Value;
                
            switch (componentType)
            {
                case "PowerHardware":
                    CreatePowerHardware(match, components);
                    break;
                case "HeavyHardware":
                    CreateHeavyHardware(match, components);
                    break;
                case "ExpressSoftware":
                    CreateExpressSoftware(match, components);
                    break;
                case "LightSoftware":
                    CreateLightSoftware(match, components);
                    break;
                default: throw new ArgumentException("Unknown component type!");
            }
        }

        private static void CreatePowerHardware(Match match, List<Hardware> components)
        {
            string[] tokens =
                match.Groups[2].Value.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string name = tokens[0];
            int capacity = int.Parse(tokens[1]);
            int memory = int.Parse(tokens[2]);
            var newComponent = new PowerHardware(name, capacity, memory);
            components.Add(newComponent);
        }

        private static void CreateHeavyHardware(Match match, List<Hardware> components)
        {
            string[] tokens =
                match.Groups[2].Value.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string name = tokens[0];
            int capacity = int.Parse(tokens[1]);
            int memory = int.Parse(tokens[2]);
            var newComponent = new HeavyHardware(name, capacity, memory);
            components.Add(newComponent);
        }

        private static void CreateLightSoftware(Match match, List<Hardware> components)
        {
            string[] tokens =
                match.Groups[2].Value.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string hardwareName = tokens[0];
            var hardware = components.FirstOrDefault(x => x.Name == hardwareName);

            if (hardware != null)
            {
                string name = tokens[1];
                int capacity = int.Parse(tokens[2]);
                int memory = int.Parse(tokens[3]);
                var newComponent = new LightSoftware(hardware, name, capacity, memory);

                if (hardware.IsCapacityCapable(newComponent) && hardware.IsMemoryCapable(newComponent))
                {
                    hardware.SoftwareComponents.Add(newComponent);
                }
            }
        }

        private static void CreateExpressSoftware(Match match, List<Hardware> components)
        {
            string[] tokens =
                match.Groups[2].Value.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string hardwareName = tokens[0];
            var hardware = components.FirstOrDefault(x => x.Name == hardwareName);

            if (hardware != null)
            {
                string name = tokens[1];
                int capacity = int.Parse(tokens[2]);
                int memory = int.Parse(tokens[3]);
                var newComponent = new ExpressSoftware(hardware, name, capacity, memory);

                if (hardware.IsCapacityCapable(newComponent) && hardware.IsMemoryCapable(newComponent))
                {
                    hardware.SoftwareComponents.Add(newComponent);
                }
            }
        }
    }
}
