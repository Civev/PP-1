using lab01;

static void SensSMS()
{
    Console.WriteLine($"Отправленно SMS");
}

FamilyMember Ivan = new FamilyMember(33, "Иван", 123321);

Console.WriteLine(Ivan.Name);
Console.WriteLine(Ivan.name);
Console.WriteLine(Ivan.SameAdress("Ул. Симонова"));

FamilyMember newIvan = new FamilyMember(Ivan);

Console.WriteLine(newIvan.Name);

Person person = new Person("Сергей", 23, 2121, "М");

Console.WriteLine(person.Name);

var truck = new Truck("tirex", "23123", 25);

Console.WriteLine(truck.TahometrNubmer);


