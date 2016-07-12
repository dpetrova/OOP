namespace SystemSplit.Models
{
    public abstract class Software : Component
    {
        public Software(Hardware hardware, string name, int capacityConsumption, int memoryConsumption)
            : base(name)
        {
            this.Hardware = hardware;
            this.CapacityConsumption = capacityConsumption;
            this.MemoryConsumption = memoryConsumption;
        }

        public Hardware Hardware { get; set; }

        public virtual int CapacityConsumption { get; set; }

        public virtual int MemoryConsumption { get; set; }
    }
}
