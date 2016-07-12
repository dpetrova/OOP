namespace SystemSplit.Models
{
    public class LightSoftware : Software
    {
        public LightSoftware(Hardware hardware, string name, int capacityConsumption, int memoryConsumption)
            : base(hardware, name, capacityConsumption, memoryConsumption)
        {
        }

        public override int CapacityConsumption
        {
            get
            {
                return (int)(base.CapacityConsumption * 1.5);
            }
        }

        public override int MemoryConsumption
        {
            get
            {
                return (int)(base.MemoryConsumption * 0.5);
            }
        }
    }
}
