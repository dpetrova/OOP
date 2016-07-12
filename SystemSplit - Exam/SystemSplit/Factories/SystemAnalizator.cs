namespace SystemSplit.Factories
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using SystemSplit.Models;

    public static class SystemAnalizator
    {
        public static string AnalyzeSystem(List<Hardware> components)
        {
            var hardwareCount = components.Count;
            int softwareCount = 0;
            int totalOperationalMemoryInUse = 0;
            int maxMemory = 0;
            int totalCapacityTaken = 0;
            int maxCapacity = 0;

            foreach (var hardware in components)
            {
                softwareCount += hardware.SoftwareComponents.Count;
                totalOperationalMemoryInUse += hardware.TotalMemoryInUse;
                maxMemory += hardware.MaxMemory;
                totalCapacityTaken += hardware.TotalUsedCapacity;
                maxCapacity += hardware.MaxCapacity;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("System Analysis\n");
            sb.AppendFormat("Hardware Components: {0}\n", hardwareCount);
            sb.AppendFormat("Software Components: {0}\n", softwareCount);
            sb.AppendFormat("Total Operational Memory: {0} / {1}\n", totalOperationalMemoryInUse, maxMemory);
            sb.AppendFormat("Total Capacity Taken: {0} / {1}", totalCapacityTaken, maxCapacity);

            return sb.ToString();
        }

        public static string AnalyzeDump(List<Hardware> dump)
        {
            int expressSoftwareCount = 0;
            int lightSoftwareCount = 0;
            int totalDumpedMemory = 0;
            int totalDumpedCapacity = 0;

            foreach (var hardware in dump)
            {
                expressSoftwareCount += hardware.SoftwareComponents.Count(x => x.GetType().Name == "ExpressSoftware");
                lightSoftwareCount += hardware.SoftwareComponents.Count(x => x.GetType().Name == "LightSoftware");
                totalDumpedMemory += hardware.TotalMemoryInUse;
                totalDumpedCapacity += hardware.TotalUsedCapacity;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Dump Analysis\n");
            sb.AppendFormat("Power Hardware Components: {0}\n", dump.Count(x => x.GetType().Name == "PowerHardware"));
            sb.AppendFormat("Heavy Hardware Components: {0}\n", dump.Count(x => x.GetType().Name == "HeavyHardware"));
            sb.AppendFormat("Express Software Components: {0}\n", expressSoftwareCount);
            sb.AppendFormat("Light Software Components: {0}\n", lightSoftwareCount);
            sb.AppendFormat("Total Dumped Memory: {0}\n", totalDumpedMemory);
            sb.AppendFormat("Total Dumped Capacity: {0}", totalDumpedCapacity);

            return sb.ToString();
        }
    }
}
