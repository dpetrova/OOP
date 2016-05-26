using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire.Engine
{
    using Intefaces;
    using Models.Buildings;
    using Models.Resources;

    public class ResourceFactory : IResourceFactory
    {
        public IResource CreateResource(ResourceType resourceType, int quantity)
        {
            var resource = new Resource(resourceType, quantity);
            return resource;
        }
    }
}
