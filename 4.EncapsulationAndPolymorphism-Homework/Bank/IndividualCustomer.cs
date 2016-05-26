using System;


namespace Bank
{
    public class IndividualCustomer : Customer
    {
        private long id;

        public IndividualCustomer(string name, long id): base(name)
        {
            this.Id = id;
        }
    
        public long Id
        {
            get { return this.id; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("ID cannot be empty");
                }
                this.id = value;
            }
        }
    }
}
