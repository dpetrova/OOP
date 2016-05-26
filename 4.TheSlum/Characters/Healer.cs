using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Characters
{
    using Interfaces;
    using Items;

    public class Healer : Character, IHeal
    {
        private const int DefaultHealthPoints = 75;
        private const int DefaultDefensePoints = 50;
        private const int DefaultHealingPoints = 60;
        private const int DefaultRange = 6;

        public Healer(string id, int x, int y, Team team) 
            : base(id, x, y, team, DefaultHealthPoints, DefaultDefensePoints, DefaultRange)
        {
            this.HealingPoints = DefaultHealingPoints;
        }

        public int HealingPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var alliedTeam = targetsList.Where(t => t.Team == this.Team);
            var alivesAllies = alliedTeam.Where(t => t.IsAlive == true);
            var target = alivesAllies.FirstOrDefault(t => t.HealthPoints == alivesAllies.Min(h => h.HealthPoints));                                                                                                                                                                                                                                                                                                                                           
            return target;
        }

        
        public override string ToString()
        {
            return base.ToString() + ", Healing: " + this.HealingPoints;
        }
    }
}
