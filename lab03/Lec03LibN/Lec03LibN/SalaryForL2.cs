using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    internal class SalaryForL2 : IFactory
    {
        private readonly float A;
        public SalaryForL2(float A)
        {
            this.A = A;
        }

        public IBonus GetA(float costOneHour)
        {
          return  new BonusAL2(costOneHour, A);
        }

        public IBonus GetB(float costOneHour, float x)
        {
            return new BonusBL2(costOneHour, x, A);
        }

        public IBonus GetC(float costOneHour, float x, float y)
        {
            return new  BonusCL2(costOneHour, x, y, A);
        }
    }
}
