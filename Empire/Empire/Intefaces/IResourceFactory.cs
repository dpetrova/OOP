using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire.Intefaces
{
    using Models.Resources;

    public interface IResourceFactory
    {
        IResource CreateResource(ResourceType resourceType, int quantity);
    }
}
