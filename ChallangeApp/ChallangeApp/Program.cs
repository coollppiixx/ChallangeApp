var Name = "Andrzej";
var sex = "Męzczyzna";
var Age = 32;

if (sex == "kobieta")
{
    if (Name == "Ewa")
    {
        Console.WriteLine("Ewa");
    }
    else
    {
    Console.WriteLine("Kobieta");
    }

}
else
{
    Console.WriteLine("mężczyzna");
}
if (Age <18)
{
    Console.WriteLine("niepełnoletni/a");
}
else if (Age >= 18 && Age > 30) 
{
    Console.WriteLine("pełnoletni/a, po 30-stce");
}
else if (Age >= 30)
{
    if (Age == 33)
    {
        Console.WriteLine("lat 33");
    }
}
else
{
    Console.WriteLine("po 30-stce");
}

