using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    internal class Truck : Car
    {
        protected int weight;
        protected int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (weight > 0)
                {
                    weight = value;
                }
            }
        }
        public string firmName;
        public string FirmName
        {
            get { return firmName; }
            set
            {
                firmName = value;
            }
        }

        private string tahometrNubmer;

        public string TahometrNubmer
        {
            get { tahometrNubmer = firmName + weight.ToString();
                return tahometrNubmer;
               }
            set { 
                tahometrNubmer = value;
            }
        }

        public Truck(string firmName, string tahometr, int weight) { 
            this.firmName = firmName;
            tahometrNubmer = tahometr;
            this.weight = weight;
            EngenWasStarted();
        
        }
        public Truck() {
            firmName = null;
            tahometrNubmer = null;
            weight = 0;
        }

        public void newDisctanation()
        {
            Console.WriteLine("Был построен новый маршрут");
        }
        private void GettedNewPappers(int numbers)
        {
            Console.WriteLine($"Были получены новые бумаги на погрузку, смотреть номер {numbers}");

        }
        protected string Break()
        {
            Console.WriteLine("Вам надо сделать перерыв, вы ехали: ");
            return tahometrNubmer;
        }

    }
}
