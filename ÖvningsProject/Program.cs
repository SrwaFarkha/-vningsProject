
using ÖvningsProject;



var animals = new List<Animal>() {
    new Animal(){Name="Ko", Age= 4 , Legs= 4 , Size= "big"},
    new Animal(){ Name="Tupp", Age= 2 , Legs= 2 , Size= "Smal"},
    new Animal(){ Name="Häst", Age= 14 , Legs= 4 , Size= "big"},
    new Animal(){ Name="Katt", Age= 8 , Legs= 4 , Size= "Smal"}
};

Console.WriteLine($"Here is the list of the animals: ");

foreach (var result in animals)
{
    Console.WriteLine($" Name: {result.Name}, Age: {result.Age}, Number  of legs: {result.Legs}, Size: {result.Size}");
}

Console.WriteLine();
Console.WriteLine("Would you like to add another animal?");
string answear = Console.ReadLine().ToLower();
if (answear == "yes")
{
    Console.WriteLine("Write: Name, Age, Legs and size. klick tap after each one.");
    string _name = Console.ReadLine();
    string _age = Console.ReadLine();
    string _legs = Console.ReadLine();
    string _size = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine($"Your animal is: Name: {_name}, Age: {_age}, Number os legs: {_legs} and size: {_size}");
}
else
{
    Console.WriteLine("Okej, have a good day!");
}

