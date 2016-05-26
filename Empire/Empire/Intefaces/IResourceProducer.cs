using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire.Intefaces
{
    using Models;

    public interface IResourceProducer
    {
        IResource ProduceResource();
    }
}
