using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIS.Models.MilitantGroups
{
    using Attacks;
    using Interfaces;
    using WarEffects;

    public class MilitantGroup : IMilitantGroup
    {
        private int cyclesCount = 0;
        private string name;
        private int health;
        private int damage;

        public MilitantGroup(string name, int health, int damage, IWarEffect warEffect, IAttack attack)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
            this.WarEffect = warEffect;
            this.Attack = attack;
        }


        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name of group cannot be null or empty.");
                }
                this.name = value;
            }
        }

        public int Health
        {
            get { return this.health; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Health cannot be negative.");
                }
                this.health = value;
            }
        }

        public int Damage
        {
            get { return this.damage; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Damage cannot be negative.");
                }
                this.damage = value;
            }
        }

        public IWarEffect WarEffect { get; set; }

        public IAttack Attack { get; set; }

        public virtual void RespondToAttack(IAttack attack)
        {
            attack.Hit(this);
        }


        public virtual void Update()
        {
            this.cyclesCount++;
            if (this.WarEffect.GetType().Name == "Jihad")
            {
                if (this.Health >= 5)
                {
                    this.Health -= 5;
                }
            }
            if (this.WarEffect.GetType().Name == "Kamikaze")
            {
                if (this.Health >= 10)
                {
                    this.Health -= 10;
                }
            }
            if (this.Health <= 0)
            {
                this.Health = 0;
            }
        }

        //Group {name}: {health} HP, {damage} Damage
        //Group Cenko AMEN
        public override string ToString() 
        {
            StringBuilder output = new StringBuilder();

            if (this.Health <= 0)
            {
                output.AppendLine(string.Format("Group {0} AMEN", this.Name));
            }
            else
            {
                output.AppendLine(string.Format("Group {0}: {1} HP, {2} Damage", this.Name, this.Health, this.Damage));
            }
           
            return output.ToString();
        }
    }
}
