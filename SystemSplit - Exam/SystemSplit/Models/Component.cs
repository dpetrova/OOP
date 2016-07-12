namespace SystemSplit.Models
{
    public abstract class Component
    {
        protected Component(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
