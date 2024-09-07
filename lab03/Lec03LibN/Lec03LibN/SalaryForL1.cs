using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    internal class SalaryForL1 : IFactory
    {
       

        public IBonus GetA(float costOneHour)
        {
            IBonus bonus =  new BonusA(costOneHour);
            return bonus;
            
        }

        public IBonus GetB(float costOneHour, float x)
        {
         return new BonusB(costOneHour, x);
        }

        public IBonus GetC(float costOneHour, float x, float y)
        {
            return new BonusC(costOneHour, x, y);
        }
    }
}
