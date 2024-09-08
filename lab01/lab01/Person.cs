using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab01.IPerson;

namespace lab01
{
    internal class Person : IPerson
    {

        public Person(string name, int age, int pasportId, string Hair) { 
            this.name = name;
            this.age = age;
            this.passportId = passportId;
            this.hair = hair;

        }
        public Person(Person oldData)
        {
            this.name = oldData.name;
            this.age = oldData.age;
            this.passportId = oldData.passportId;
            this.Hair = oldData.Hair;

        }

        public const string HospitalAdress = "Ул. Красноармейска 12";
        private const int Index = 123;
        protected const string LivingAdress = "Ул. Орловского 13";

        protected int age;
        private int passportId;
        public string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name.Length > 0)
                {
                    name = value;
                }
            }

        }

        protected int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (age > 0)
                {
                    age = value;
                }
            }
        }
        private int MedId
        {
            get
            {
                return passportId + 1202123;
            }
            set
            {
                if (passportId > 0)
                {
                    passportId = value;
                }
            }

        }

        string[] licesnses = { "Годен", "1.0"};
        public string this[int ind] { get => licesnses[ind];
            set => licesnses[ind] = value; }

        public string hair;

        //public delegate void SendHandler(string m);
        //public event SendHandler SendSomthing;

        public string Hair { get
            {
                return hair;
            } set
            {
                if (hair.Length>0)
                    hair = value;    

            } }
        

        public void CheckBirthdatDate(DateTime date)
        {
            Console.WriteLine(date == DateTime.Now);
        }
        private int GetPassportId()
        {
            return MedId - 1202123;
        }
        public bool SameAdress(string adress)
        {
            return adress == LivingAdress;
        }

        public string WhatDistrict(int indx)
        {
            if (indx == 123)
                return "Ул.Орловского";
            else if (indx == 321)
                return "Ул. Симонова";
            return "Ул. Кутепова";

        }
       
    }
}
