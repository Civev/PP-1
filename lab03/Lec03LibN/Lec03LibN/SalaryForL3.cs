using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    internal class SalaryForL3 : IFactory
    {
        public IBonus GetA(float costOneHour)
        {
            throw new NotImplementedException();
        }

        public IBonus GetB(float costOneHour, float x)
        {
            throw new NotImplementedException();
        }

        public IBonus GetC(float costOneHour, float x, float y)
        {
            throw new NotImplementedException();
        }
    }
}
