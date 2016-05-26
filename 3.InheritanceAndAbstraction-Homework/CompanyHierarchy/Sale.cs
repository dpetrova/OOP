using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public class Sale
    {
        private string name;
        private DateTime date;
        private decimal price;

        public Sale(string name, DateTime date, decimal price)
        {
            this.Name = name;
            this.Date = date;
            this.Price = price;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Product name cannot be null or empty");
                }
                this.name = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Date cannot be empty");
                }
                this.date = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be null or negative");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Product name: {0}/Date: {1}/Price: {2}", this.Name, this.Date, this.Price);
        }
    }
}
