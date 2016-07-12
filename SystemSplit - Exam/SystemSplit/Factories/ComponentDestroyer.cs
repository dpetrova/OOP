namespace SystemSplit.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using SystemSplit.Models;

    public static class ComponentDestroyer
    {
        public static void DestroyComponent(string input, List<Hardware> components)
        {
            var match = ProcessInput(input);

            string[] tokens =
                match.Groups[2].Value.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string hardwareComponentName = tokens[0];
            string softwareComponentName = tokens[1];
            var hardwareComponent = components.FirstOrDefault(x => x.Name == hardwareComponentName);

            if (hardwareComponent != null)
            {
                var softwareComponent =
                    hardwareComponent.SoftwareComponents.FirstOrDefault(x => x.Name == softwareComponentName);

                if (softwareComponent != null)
                {
                    hardwareComponent.SoftwareComponents.Remove(softwareComponent);
                }
            }
        }

        public static void DumpComponent(string input, List<Hardware> components, List<Hardware> dump)
        {
            var match = ProcessInput(input);
            string hardwareComponentName = match.Groups[2].Value;
            var hardwareComponent = components.FirstOrDefault(x => x.Name == hardwareComponentName);

            if (hardwareComponent != null)
            {
                dump.Add(hardwareComponent);
                components.Remove(hardwareComponent);
            }
        }

        public static void RestoreComponent(string input, List<Hardware> components, List<Hardware> dump)
        {
            var match = ProcessInput(input);
            string hardwareComponentName = match.Groups[2].Value;
            var hardwareComponent = dump.FirstOrDefault(x => x.Name == hardwareComponentName);

            if (hardwareComponent != null)
            {
                components.Add(hardwareComponent);
                dump.Remove(hardwareComponent);
            }
        }

        public static void DestroyComponentPermanently(string input, List<Hardware> dump)
        {
            var match = ProcessInput(input);
            string hardwareComponentName = match.Groups[2].Value;
            var hardwareComponent = dump.FirstOrDefault(x => x.Name == hardwareComponentName);

            if (hardwareComponent != null)
            {
                dump.Remove(hardwareComponent);
            }
        }

        public static Match ProcessInput(string input)
        {
            string pattern = @"(\w+)\((.+)\)";
            Regex rgx = new Regex(pattern);

            if (!rgx.IsMatch(input))
            {
                throw new ArgumentException("Invalid input!");
            }

            Match match = rgx.Match(input);
            return match;
        }
    }
}
