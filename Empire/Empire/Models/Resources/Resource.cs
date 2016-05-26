using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire.Models.Resources
{
    using Intefaces;

    public class Resource : IResource
    {
        public Resource(ResourceType resourceType, int quantity)
        {
            this.ResourceType = resourceType;
            this.Quantity = quantity;
        }

        public ResourceType ResourceType { get; private set; }
        public int Quantity { get; private set; }
    }
}
