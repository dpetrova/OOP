using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire.Intefaces
{
    using Models;
    using Models.Resources;

    public interface IResource
    {
        ResourceType ResourceType { get; }

        int Quantity { get; }
    }
}
