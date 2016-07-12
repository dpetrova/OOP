namespace SystemSplit.Models
{
    public class PowerHardware : Hardware
    {
        public PowerHardware(string name, int maxCapacity, int maxMemory)
            : base(name, maxCapacity, maxMemory)
        {
        }

        public override int MaxCapacity
        {
            get
            {
                return (int)(base.MaxCapacity * 0.25);
            }
        }

        public override int MaxMemory
        {
            get
            {
                return (int)(base.MaxMemory * 1.75);
            }
        }
    }
}
