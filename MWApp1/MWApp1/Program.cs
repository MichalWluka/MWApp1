
// Podaj Imię?
var imię = "Ewa";
// Podaj Wiek?
var wiek = 33;
// Podaj płeć, k lub m 
var płeć = 'k';


if (imię == "Ewa" && płeć == 'k' && wiek == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
if(płeć == 'k' && wiek < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
if (płeć == 'm' && wiek >= 18)
{
    Console.WriteLine("Pełnoletni Mężczyzna");
}
else if (wiek < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
