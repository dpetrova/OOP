namespace SystemSplit.Models
{
    public class ExpressSoftware : Software
    {
        public ExpressSoftware(Hardware hardware, string name, int capacityConsumption, int memoryConsumption)
            : base(hardware, name, capacityConsumption, memoryConsumption)
        {
        }

        public override int MemoryConsumption
        {
            get
            {
                return base.MemoryConsumption * 2;
            }
        }
    }
}
