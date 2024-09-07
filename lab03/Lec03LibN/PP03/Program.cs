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

IFactory l3 = Lec03LibN.Lec03LibN.getL3(1.0f, 0.5f);
//Emploee empBA = new Emploee(l3.GetA(25));
//Console.WriteLine(emp.CalculateBonus(4));
var Emp = new Emploee(l3.GetB(25, 1.1f));
Console.WriteLine(Emp.CalculateBonus(4));
var Emp3 = new Emploee(l3.GetC(25, 1.1f, 0.5f));
Console.WriteLine(Emp3.CalculateBonus(4));

