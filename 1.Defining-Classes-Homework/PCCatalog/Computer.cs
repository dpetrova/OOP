using System;
using System.Collections.Generic;
using System.Linq;

class Computer
{
    private string name;
    private ICollection<Component> components;
    private decimal price;

    public Computer(string name)
        : this(name: name, components: null)
    {
    }

    public Computer(string name, ICollection<Component> components)
    {
        this.Name = name;
        this.Components = components;
    }

    // с params могат да се подават колкото си искаме аргументи:
    //public Computer(string name, params Component[] component)
    //{
    //    this.Name = name;
    //    foreach (var item in component)
    //    {
    //        this.components.Add(item);
    //        this.Price += item.Price;
    //    }
    //}

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
    
    public ICollection<Component> Components
    {
        get { return this.components; }
        set
        {
            this.components = value;
            foreach (var component in components)
            {
                this.price += component.Price;
            }
        }
    }
    
    public decimal Price
    {
        get { return this.price; }
    }

    public void AddComponent(Component component)
    {
        this.components.Add(component);
        this.price += component.Price;
    }

    public override string ToString()
    {
        return String.Format("Name: {0}\n" +
                             "Components: {1}\n" +
                             "Total Price: {2}\n",
                             this.name,
                             String.Join("\n", this.components.Select(x => x.ToString()).ToArray()),
                             this.price);
    }

}



