namespace SystemSplit.Models
{
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Hardware : Component
    {
        public Hardware(string name, int maxCapacity, int maxMemory)
            : base(name)
        {
            this.MaxCapacity = maxCapacity;
            this.MaxMemory = maxMemory;
            this.SoftwareComponents = new List<Software>();
        }

        public virtual int MaxCapacity { get; set; }

        public virtual int MaxMemory { get; set; }

        public List<Software> SoftwareComponents { get; set; }

        public int TotalMemoryInUse
        {
            get
            {
                return this.SoftwareComponents.Sum(x => x.MemoryConsumption);
            }
        }

        public int TotalUsedCapacity
        {
            get
            {
                return this.SoftwareComponents.Sum(x => x.CapacityConsumption);
            }
        }

        public bool IsMemoryCapable(Software software)
        {
            return this.MaxMemory >= this.TotalMemoryInUse + software.MemoryConsumption;
        }

        public bool IsCapacityCapable(Software software)
        {
            return this.MaxCapacity >= this.TotalUsedCapacity + software.CapacityConsumption;
        }
    }
}
