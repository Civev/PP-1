using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    public class SalaryForL3 : IFactory
    {
        
        private float A { get; set; }

        private float B { get; set; }
        public SalaryForL3(float A, float B)
        {
           
            this.A = A;
            this.B = B;
        }
        public IBonus GetA(float costOneHour)
        {
            return new BonusAL3(costOneHour, A, B);
        }

        public IBonus GetB(float costOneHour, float x)
        {
            return new BonusBL3(costOneHour, x, A, B);
        }

        public IBonus GetC(float costOneHour, float x, float y)
        {
            return new BonusCL3(costOneHour,x,y, A, B);    
        }
    }
}
