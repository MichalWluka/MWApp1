
int liczba = 15555425; // podaj liczbę
string liczbaString = liczba.ToString();
char[] litery = liczbaString.ToArray();

Console.WriteLine("Podana liczba wynosi: " + liczbaString);

int licznik0 = 0;
int licznik1 = 0;
int licznik2 = 0;
int licznik3 = 0;
int licznik4 = 0;
int licznik5 = 0;
int licznik6 = 0;
int licznik7 = 0;
int licznik8 = 0;
int licznik9 = 0;


foreach (char i in litery)
{
    if (i == '0')
    {
        licznik0++;
    }
    else if (i == '1')
    {
        licznik1++;
    }
    else if (i == '2')
    {
        licznik2++;
    }
    else if (i == '3')
    {
        licznik3++;
    }
    else if (i == '4')
    {
        licznik4++;
    }
    else if (i == '5')
    {
        licznik5++;
    }
    else if (i == '6')
    {
        licznik6++;
    }
    else if (i == '7')
    {
        licznik7++;
    }
    else if (i == '8')
    {
        licznik8++;
    }
    else if (i == '9')
    {
        licznik9++;
    }
}

List<int> liczniki = new List<int>();
liczniki.Add(licznik0);
liczniki.Add(licznik1);
liczniki.Add(licznik2);
liczniki.Add(licznik3);
liczniki.Add(licznik4);
liczniki.Add(licznik5);
liczniki.Add(licznik6);
liczniki.Add(licznik7);
liczniki.Add(licznik8);
liczniki.Add(licznik9);

for (int n = 0; n < liczniki.Count; n++) 
{
    Console.WriteLine(n + " => "+ liczniki[n]);
}
