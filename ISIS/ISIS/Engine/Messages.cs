using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS.Engine
{
    public static class Messages
    {
        public const string GroupDestroyed = "Group {0} was killed"; //Group Petya was killed
        public const string DuplicateGroupName = "Militan group with such name already exists";
        public const string CreatedGroup = "Group {0}: {1} HP, {2} Damage"; //Group Cenko: 50 HP, 15 Damage
        public const string AttackGroup = "Group {0} toggled {1}"; //Group Petya toggled Jihad
    }
}
