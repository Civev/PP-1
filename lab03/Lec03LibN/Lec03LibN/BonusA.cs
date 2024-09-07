using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    internal class BonusA : IBonus
    {
        public float costOneHour { get; set; }

        public BonusA(float costOneHour) {
            this.costOneHour = costOneHour;
            
            }

        public float Calculate(float hoursOfWork)
        {
            return costOneHour * hoursOfWork;
        }
    }
}
