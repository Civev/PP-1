using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    internal class Car
    {
        public string model;
        protected int startedAge;
        private string radioPin;

        public string Model { get
            {
                return model;
            }
            set
            { model = value; }
        }

        public int StartedAge
        {
            get
            {
                return startedAge;
            }
            set
            {
                startedAge = value;
            }
        }

        private string RadioPin
        {
            get
            {
                return radioPin;
            }
            set
            {
                radioPin = value;
            }
        }






        public Car(string model, int age, string radioPin) { 
            this.model = model;
            this.startedAge = age;
            this.radioPin = radioPin;
        }
        public Car() {
            model = null;
            startedAge = 0;
            radioPin = null;
        }

        protected void EngenWasStarted()
        {
            Console.WriteLine("Двигатель запущен");
        }
        public bool OldCarOrNot()
        {
            return (startedAge < 2005);
        }
        private bool IsCarExisted()
        {
            if(model == null && radioPin == null && startedAge == 0)
                return false;
            return true;
        }
    }
}
