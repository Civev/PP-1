﻿namespace Lec03LibN
{
    public class Lec03LibN
    {
        static public  IFactory GetL1()
        {
            return new SalaryForL1();
        }

        static public  IFactory getL2(float a)
        {
            return new SalaryForL2(a);
        }
        static public  IFactory getL3(float a, float b)
        {
            return new SalaryForL3(a, b);
        }
    }
}
