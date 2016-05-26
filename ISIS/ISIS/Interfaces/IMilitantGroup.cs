using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS.Interfaces
{
    public interface IMilitantGroup
    {
        string Name { get; set; }

        int Health { get; set; }

        int Damage { get; set; }

        IWarEffect WarEffect { get; set; }

        IAttack Attack { get; set; }

        void RespondToAttack(IAttack attack);

        void Update();


    }
}
