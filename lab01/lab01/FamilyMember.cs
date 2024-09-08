using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    internal class FamilyMember
    {
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
        public FamilyMember() {
            Name = "Неизвестно";
            MedId = 0000000001202123;
            age = 0;
        }
        public FamilyMember(FamilyMember oldRecord)
        {
            name = oldRecord.name;
            passportId = oldRecord.passportId;
            age = oldRecord.age;
        }
        public FamilyMember(int age, string name, int passportId)
        {
            this.age = age;
            this.name = name;
            this.passportId = passportId;
        }

        private int GetPassportId()
        {
            return MedId - 1202123;
        }
        public bool SameAdress(string adress)
        {
            return adress == LivingAdress;
        }

        protected string WhatDistrict(int indx)
        {
            if (indx == 123)
                return "Ул.Орловского";
            else if (indx == 321)
                return "Ул. Симонова";
            return "Ул. Кутепова";

        }
    }
}

