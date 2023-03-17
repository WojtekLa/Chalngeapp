

var name = "Ewa";
bool female = false;
var age = 17;


if (name == "Ewa" && age == 33 && female)
{
    Console.WriteLine("Ewa lat 33");
}
else if (!female && age < 18)
{
Console.WriteLine("niepe lnoletni mężczyzna");
}
else if (female && age < 33)
{
    Console.WriteLine("kobieta ponizej  33 lat");
}
