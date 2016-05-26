using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.Interfaces
{
    using Ships;

    public interface IAttack
    {
        string Attack(Ship target);

    }
}
