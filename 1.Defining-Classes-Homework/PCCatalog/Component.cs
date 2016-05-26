using System;


class Component
{
    private string name;
    private string details;
    private decimal price;
    public Component(string name, decimal price) :
        this(name: name, details: null, price: price)
    {
    }

    public Component(string name, string details, decimal price)
    {
        this.Name = name;
        this.Details = details;
        this.Price = price;
    }
    
    public string Name
    {
        get { return this.name; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty!");
            }
            this.name = value;
        }
    }

    public string Details
    {
        get { return this.details; }
        set{ this.details = value; }
    }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Incorrect price!");
            }
            this.price = value;
        }
    }

    public override string ToString()
    {
        return String.Format(" - Name: {0}\n" +
                             " - Details: {1}\n" +
                             " - Price: {2}\n",                             
                             this.name,
                             this.details ?? "N/A",
                             this.price
                             );
    }

}

