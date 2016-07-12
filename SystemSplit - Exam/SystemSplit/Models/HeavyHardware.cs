namespace SystemSplit.Models
{
    public class HeavyHardware : Hardware
    {
        public HeavyHardware(string name, int maxCapacity, int maxMemory)
            : base(name, maxCapacity, maxMemory)
        {
        }

        public override int MaxCapacity
        {
            get
            {
                return base.MaxCapacity * 2;
            }
        }

        public override int MaxMemory
        {
            get
            {
                return (int)(base.MaxMemory * 0.75);
            }
        }
    }
}
