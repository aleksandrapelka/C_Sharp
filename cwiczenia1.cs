/* ZADANIE 1
Napisz program, który oblicza sumę, różnicę, iloczyn i iloraz dla dwóch liczb, x i y, wprowadzanych z 
klawiatury. W programie przyjmujemy, że zmienne x i y są typu double (typu rzeczywistego). Wszystkie 
zmienne należy wyświetlić z dokładnością do dwóch miejsc po przecinku.
*/
Console.WriteLine("---------------------- Zadanie 1 ----------------------");

Console.WriteLine("Podaj pierwszą liczbę: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Podaj drugą liczbę: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Suma: " + Math.Round((x+y), 2));
Console.WriteLine("Różnica: " + Math.Round((x-y), 2));
Console.WriteLine("Iloczyn: " + Math.Round((x*y), 2));
Console.WriteLine("Iloraz: " + Math.Round((x/y), 2));


/* ZADANIE 2
Napisz program, który oblicza objętość kuli o promieniu r. Wartość promienia r wprowadzamy z 
klawiatury. W programie należy przyjąć, że zmienne promień r i objętość są typu double (typu 
rzeczywistego). Dla tych zmiennych należy przyjąć format wyświetlania ich na ekranie z dokładnością 
do dwóch miejsc po przecinku.
*/
Console.WriteLine("---------------------- Zadanie 2 ----------------------");

Console.WriteLine("Podaj promień kuli: ");
double r = Convert.ToDouble(Console.ReadLine());
double objetosc = (4 * Math.PI * Math.Pow(r, 3)) / 3;

Console.WriteLine("Promień kuli: " + Math.Round(r, 2));
Console.WriteLine("Objętość kuli: " + Math.Round(objetosc, 2));


/* ZADANIE 3
Napisz program, który dla trzech liczb, a, b, c, wprowadzonych z klawiatury sprawdza, czy tworzą one 
trójkę pitagorejską.
*/
Console.WriteLine("---------------------- Zadanie 3 ----------------------");

Console.WriteLine("Podaj pierwszą liczbę: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Podaj drugą liczbę: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Podaj trzecią liczbę: ");
double c = Convert.ToDouble(Console.ReadLine());


if (c < b || c < a)
{
    double temp = c;
    c = Math.Max(a, b);

    if(a > b)
    {
        a = temp;
    }
    else
    {
        b = temp;
    }
}

if (a * a + b * b == c * c)
{
    Console.WriteLine("Liczby: " + a + ", " + b + ", " + c + " tworzą trójkę pitagorejską.");
}
else
{
    Console.WriteLine("Liczby: " + a + ", " + b + ", " + c + " NIE tworzą trójki pitagorejskiej.");
}


/* ZADANIE 4
Napisz program, który z wykorzystaniem instrukcji if oblicza pierwiastki równania kwadratowego ax2 + 
bx + c = 0, w którym zmienne a, b, c to liczby rzeczywiste wprowadzane z klawiatury. Wszystkie zmienne 
wyświetlamy na ekranie z dokładnością do dwóch miejsc po przecinku.
*/
Console.WriteLine("---------------------- Zadanie 4 ----------------------");

Console.WriteLine("Podaj pierwszą liczbę: ");
double a2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Podaj drugą liczbę: ");
double b2 = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Podaj trzecią liczbę: ");
double c2 = Convert.ToDouble(Console.ReadLine());

double delta = b2 * b2 - 4 * a2 * c2;
Console.WriteLine("Równanie kwadratowe: " + Math.Round(a2, 2) + "x^2 + " + Math.Round(b2, 2) + "x + " + Math.Round(c2, 2) + " = 0");
if (delta > 0)
{
    Console.WriteLine("Pierwszy pierwiastek równania: x1 = " + Math.Round((-b2 - Math.Sqrt(delta)) / (2 * a2), 2)); 
    Console.WriteLine("Drugi pierwiastek równania: x2 = " + Math.Round((-b2 + Math.Sqrt(delta)) / (2 * a2), 2)); 
}
else if(delta == 0)
{
    Console.WriteLine("Pierwiastek równania: x = " + Math.Round(-b2 / (2 * a2), 2));
}
else
{
    Console.WriteLine("Brak pierwiastków równania.");
}


/* ZADANIE 5
Napisz program, który z wykorzystaniem instrukcji switch oblicza pierwiastki równania kwadratowego 
ax2 + bx + c = 0, w którym zmienne a, b, c to liczby rzeczywiste wprowadzane z klawiatury. Wszystkie 
zmienne wyświetlamy z dokładnością do dwóch miejsc po przecinku.
*/
Console.WriteLine("---------------------- Zadanie 5 ----------------------");

Console.WriteLine("Równanie kwadratowe: " + Math.Round(a2, 2) + "x^2 + " + Math.Round(b2, 2) + "x + " + Math.Round(c2, 2) + " = 0");
switch (delta)
{
    case 0:
        
        Console.WriteLine("Pierwiastek równania: x = " + Math.Round(-b2 / (2 * a2), 2));
        break;

    case < 0:

        Console.WriteLine("Brak pierwiastków równania.");
        break;
        
    default:

        Console.WriteLine("Pierwszy pierwiastek równania: x1 = " + Math.Round((-b2 - Math.Sqrt(delta)) / (2 * a2), 2));
        Console.WriteLine("Drugi pierwiastek równania: x2 = " + Math.Round((-b2 + Math.Sqrt(delta)) / (2 * a2), 2));
        break;
}


/* ZADANIE 6
Napisz program, który oblicza wartość niewiadomej x z równania ax + b = c. Wartości a, b, c należą do 
zbioru liczb rzeczywistych i są wprowadzane z klawiatury. Dodatkowo należy zabezpieczyć program na 
wypadek sytuacji, kiedy wprowadzona wartość a = 0. Wszystkie zmienne wyświetlamy z dokładnością 
do dwóch miejsc po przecinku.
*/
Console.WriteLine("---------------------- Zadanie 6 ----------------------");

Console.WriteLine("Podaj pierwszą liczbę: ");
double a3 = Convert.ToDouble(Console.ReadLine());
while (a3 == 0)
{
    Console.WriteLine("Nie można dzielić przez 0!!!");
    Console.WriteLine("Podaj inną liczbę: ");
    a3 = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("Podaj drugą liczbę: ");
double b3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Podaj trzecią liczbę: ");
double c3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Równanie: " + Math.Round(a3, 2) + "x + " + Math.Round(b3, 2) + " = " + Math.Round(c3, 2));
double x3 = (c3 - b3) / a3;
Console.WriteLine("Wartość niewiadomej x = " + Math.Round(x3, 2));


/* ZADANIE 7
Napisz program, w którym użytkownik zgaduje całkowitą liczbę losową z przedziału od 0 do 9 
generowaną przez komputer.
*/
Console.WriteLine("---------------------- Zadanie 7 ----------------------");

Random losuj = new Random();
int los = losuj.Next(0, 9);
int liczba_prob = 4;

while(liczba_prob > 0)
{
    Console.WriteLine("Zgadnij liczbę 0 - 9. Pozostały: " +  liczba_prob + " próby");
    int liczba = Convert.ToInt32(Console.ReadLine());

    if(liczba > los)
    {
        Console.WriteLine("Za dużo!");
    }
    else if(liczba < los)
    {
        Console.WriteLine("Za mało!");
    }
    else
    {
        Console.WriteLine("Gratulacje!!! To liczba: " + los + ". Zgadłeś za " + (5-liczba_prob) + " razem.");
        break;
    }

    liczba_prob--;
}

if(liczba_prob == 0)
{
    Console.WriteLine("Gra skończona. Przegrałeś :(\nPoprawna liczba to: " + los);
}



/* ZADANIE 8
Napisz program, który za pomocą instrukcji while sumuje liczby parzyste z przedziału od 1 do 100.
*/
Console.WriteLine("---------------------- Zadanie 8 ----------------------");

int liczba2 = 1;
int suma = 0;
Console.WriteLine("Liczby parzyste z przedziału 1 - 100: ");

while(liczba2 <= 100)
{
    if(liczba2 % 2 == 0)
    {
        suma += liczba2;
        Console.Write(liczba2 + " ");
    }
    liczba2++;
}

Console.WriteLine("\nSuma: " + suma);


/* ZADANIE 9
Napisz program, który za pomocą instrukcji for znajduje największą i najmniejszą liczbę ze zbioru n 
wylosowanych liczb całkowitych z przedziału od 0 do 99 (w zadaniu n = 5) oraz oblicza średnią ze 
wszystkich wylosowanych liczb.
*/
Console.WriteLine("---------------------- Zadanie 9 ----------------------");

Console.WriteLine("Podaj ile liczb chcesz wylosować: ");
int n = Convert.ToInt32(Console.ReadLine());

Random rand = new Random();
List<int> liczby = new List<int>();
int suma3 = 0;

Console.WriteLine("Wylosowane liczby: ");
for(int i = 0; i < n; i++)
{
    liczby.Add(rand.Next(0, 99));
    Console.Write(liczby[i] + " ");

    suma3 += liczby[i];
}

int max = liczby[0];
int min = liczby[0];
for (int i = 1; i < n; i++)
{
    if (max < liczby[i])
    {
        max = liczby[i];
    }
    if (min > liczby[i])
    {
        min = liczby[i];
    }
}
Console.WriteLine("\nŚrednia arytmetyczna wylosowanych liczb: " + (suma3 / n));
Console.WriteLine("Wartość maksymalna: " + max);
Console.WriteLine("Wartość minimalna: " + min);


/* ZADANIE 10
Napisz program, który za pomocą instrukcji do ... while sumuje liczby parzyste z przedziału od 1 do 100
*/
Console.WriteLine("---------------------- Zadanie 10 ----------------------");

int liczba4 = 1;
int suma4 = 0;

Console.WriteLine("Liczby parzyste z przedziału 1 - 100: ");
do
{
    if(liczba4 % 2 == 0)
    {
        suma4 += liczba4;
        Console.Write(liczba4 + " ");
    }

    liczba4++;

}while(liczba4 <= 100);

Console.WriteLine("\nSuma: " + suma4);


/* ZADANIE 11
Wiedząc, że 1233 = 12^2 + 33^2, napisz program, który znajduje wszystkie liczby z przedziału od 1000 do 
9999 spełniające taką ciekawą zależność. Program dodatkowo liczy ich ilość.
*/
Console.WriteLine("---------------------- Zadanie 11 ----------------------");

int poczatek = 1000;
int koniec = 9999;
int ile = 0;

Console.WriteLine("Liczby spełniające podaną zależność: ");
for(int i = poczatek; i <= koniec; i++)
{
    int cz1 = Convert.ToInt32(i/100);
    int cz2 = i - (cz1 * 100);

    if (i == (cz1 * cz1 + cz2 * cz2))
    {
        Console.WriteLine(i + " = " + cz1 + "^2 + " + cz2 + "^2");
        ile++;
    }
}
Console.WriteLine("Ilość liczb spełniających warunek: " + ile);