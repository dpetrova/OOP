using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentSystem.Models.Objects
{
    public class Explosion : Tail
    {
        public Explosion(int x, int y, int lifetime = 2) 
            : base(x, y, lifetime)
        {
        }
    }
}
