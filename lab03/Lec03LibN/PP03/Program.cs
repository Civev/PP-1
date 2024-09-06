using Lec03LibN;
using PP03;

IFactory l1 = Lec03LibN.Lec03LibN.GetL1();

Emploee emploee = new Emploee(l1.GetB(25, 1.1f));

Console.WriteLine(emploee.CalculateBonus(4));

Emploee emploee2= new Emploee(l1.GetC(25, 1.1f, 5.0f));

Console.WriteLine(emploee2.CalculateBonus(4));

IFactory l2 = Lec03LibN.Lec03LibN.getL2(1);

Emploee emploeeL2 = new Emploee(l2.GetB(25,1.1f));
Console.WriteLine(emploeeL2.CalculateBonus(4));

