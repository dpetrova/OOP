using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    [AttributeUsage(AttributeTargets.Struct |
                        AttributeTargets.Class |
                        AttributeTargets.Interface |
                        AttributeTargets.Enum |
                        AttributeTargets.Method,
                        AllowMultiple = true)]
    public class VersionAttribute : System.Attribute
    {
        public VersionAttribute(int major, int minor)
        {
            this.Version = String.Format("{0}.{1}", major, minor);
        }
        
        public string Version { get; private set; }
    }
}
