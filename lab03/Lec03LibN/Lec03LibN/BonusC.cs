using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    internal class BonusC : IBonus
    {
        public float costOneHour { get; set; }
        private float x;
        private float y;

        public BonusC(float costOneHour, float x, float y)
        {
            this.costOneHour = costOneHour;
            this.x = x;
            this.y = y;
        }

        public float Calculate(float hoursOfWork)
        {
            return costOneHour * hoursOfWork * x + y;
        }
    }
}
