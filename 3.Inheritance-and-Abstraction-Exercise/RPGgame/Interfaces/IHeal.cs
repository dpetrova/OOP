using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGgame.Interfaces
{
    using Characters;

    public interface IHeal
    {
        void Heal(Character target);
    }
}
