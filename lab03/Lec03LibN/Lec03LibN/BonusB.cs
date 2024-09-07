using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    public class BonusB : IBonus
    {
        private  float x {get;set;}
        public float costOneHour { get; set; }

        public BonusB(float costOneHour, float x) {
            this.x = x;
            this.costOneHour = costOneHour;
        }

        public float Calculate(float hoursOfWork)
        {
            return costOneHour * hoursOfWork * x;
        }
    }
}
