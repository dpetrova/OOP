using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire.Engine
{
    using Intefaces;
    using Models.Units;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            switch (unitType)
            {
                case "Archer": 
                    return  new Archer();
                case "Swordsman":
                    return new Swordsman();
                default:
                    throw new ArgumentException("Unknown unit type.");
            }
        }
    }
}
