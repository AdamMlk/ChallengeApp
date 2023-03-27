// program - home work day 4

// zmienna imię
using System.ComponentModel.Design;

string name = "Ewa";

// zmienna płeć
string sex = "Kobieta";

//zmienna wiek
int age = 33;

// weryfikacja
string result = name + "," + "lat " + age;

if (age < 30 && age > 18 && sex == "Kobieta")
{
            Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (age == 33 && name == "Ewa" && sex == "Kobieta")
{
    Console.WriteLine(result);
}
else if (age < 18 && sex == "Mężczyzna")
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("Osoba spoza zbioru");
}