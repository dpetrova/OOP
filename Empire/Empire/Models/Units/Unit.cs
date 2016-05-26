using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire.Models.Units
{
    using Intefaces;

    public abstract class Unit : IUnit
    {
        protected Unit(int attackDamage, int health)
        {
            this.AttackDamage = attackDamage;
            this.Health = health;
        }

        public int AttackDamage { get; private set; }
        public int Health { get; private set; }

        //private int health;
        //private int damage;

        //public Unit(int health, int damage)
        //{
        //    this.Health = health;
        //    this.Damage = damage;
        //}

        //public int Health
        //{
        //    get { return this.health; }
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            throw new ArgumentOutOfRangeException("Health", "Health cannot be negative.");
        //        }
        //        this.health = value;
        //    }
        //}


        //public int Damage
        //{
        //    get { return this.damage; }
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            throw new ArgumentOutOfRangeException("Damage", "Damage cannot be negative.");
        //        }
        //        this.damage = value;
        //    }
        //}
        
    }
}
