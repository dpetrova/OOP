using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS.Exceptions
{
    public class MilitanGroupsException : ApplicationException
    {
        public MilitanGroupsException(string msg)
            : base(msg)
        {
        }
    }
}
