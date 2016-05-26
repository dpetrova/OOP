using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Characters
{
    using Interfaces;
    using Items;

    public class Mage : Character, IAttack
    {
        private const int DefaultHealthPoints = 150;
        private const int DefaultDefensePoints = 50;
        private const int DefaultAttackPoints = 300;
        private const int DefaultRange = 5;

        public Mage(string id, int x, int y, Team team)
            : base(id, x, y, team, DefaultHealthPoints, DefaultDefensePoints, DefaultRange)
        {
            this.AttackPoints = DefaultAttackPoints;
        }

        public int AttackPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var opponentTeam = targetsList.Where(t => t.Team != this.Team);
            var alivedOpponents = opponentTeam.Where(o => o.IsAlive == true);
            //var target = alivedOpponents.FirstOrDefault(t => t.X + t.Y == alivedOpponents.Max(p => p.X + p.Y));
            var target = alivedOpponents.LastOrDefault();
            return target;
        }

       
        protected override void ApplyItemEffects(Item item)
        {
            this.HealthPoints += item.HealthEffect;
            this.DefensePoints += item.DefenseEffect;
            this.AttackPoints += item.AttackEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            this.HealthPoints -= item.HealthEffect;
            this.DefensePoints -= item.DefenseEffect;
            this.AttackPoints -= item.AttackEffect;
            if (this.HealthPoints < 0)
            {
                this.HealthPoints = 1;
            }
        }

        public override string ToString()
        {
            return base.ToString() + ", Attack: " + this.AttackPoints;
        }
        
    }
}
