using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS.Interfaces
{
    public interface IAttack
    {
        int Damage { get; set; }

        void Hit(IMilitantGroup group);
    }
}
