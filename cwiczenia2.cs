using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ZADANIE 1
            Napisz program, który w 100 elementowej tablicy umieszcza liczby losowo wybrane z przedziału 
            podanego przez użytkownika, a następnie je sumuje, a wynik wyświetla. Użyj pętli foreach.
            */
            Console.WriteLine("---------------------- Zadanie 1 ----------------------");

            Console.WriteLine("Podaj początek przedziału: ");
            double poczatek = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj koniec przedziału: ");
            double koniec = Convert.ToDouble(Console.ReadLine());

            Random rand = new Random();
            double[] tablica = new double[100];
            double suma = 0;

            Console.WriteLine("\nTablica: ");
            foreach (int i in tablica)
            {
                tablica[i] = Math.Round(rand.NextDouble() * (koniec - poczatek) + poczatek, 2);
                Console.Write(tablica[i] + "  ");

                suma += tablica[i];
            }
            Console.WriteLine("\nSuma elementów tablicy: " + Math.Round(suma, 2));


            /* ZADANIE 2
            Napisz zgodnie z zasadami programowania obiektowego program, który oblicza pierwiastki równania 
            kwadratowego ax2 + bx + c = 0 z wykorzystaniem instrukcji wyboru case. Klasa powinna zawierać trzy 
            metody:
                czytaj_dane() — wczytuje dane do programu i obsługuje sytuację, kiedy a = 0. Zmienne a, b, c to 
                liczby rzeczywiste wprowadzane z klawiatury.

                przetworz_dane() — wykonuje niezbędne obliczenia 

                wyswietl_wynik() — wyświetla wyniki na ekranie komputera.
            Dla zmiennych a, b, c, x1, x2 należy przyjąć format ich wyświetlania na ekranie z dokładnością do dwóch 
            miejsc po przecinku.
             */
            Console.WriteLine("---------------------- Zadanie 2 ----------------------");

            Pierwiastki p = new Pierwiastki();
            p.czytaj_dane();
            p.przetworz_dane();
            p.wyswietl_wynik();


            /* ZADANIE 3
            Napisz zgodnie z zasadami programowania obiektowego program, który w tablicy 10 x 10 umieszcza 
            losowo na przekątnej liczby z przedziału od 0 do 9, a poza przekątną zera. Dodatkowo program oblicza 
            sumę liczb znajdujących się na przekątnej. Klasa powinna zawierać trzy metody:
                • czytaj_dane() — umieszcza liczby w tablicy.
                • przetworz_dane() — oblicza i wyświetla sumę liczb znajdujących się na przekątnej.
                • wyswietl_wynik() — wyświetla zawartość tablicy na ekranie komputera.
             */
            Console.WriteLine("\n---------------------- Zadanie 3 ----------------------");

            Macierz m = new Macierz();
            m.czytaj_dane();
            m.wyswietl_wynik();
            m.przetworz_dane();


            /* ZADANIE 4
            Napisz program, który rekurencyjnie znajduje 10 pierwszych liczb Fibonacciego i wyświetla je na 
            ekranie komputera.
             */
            Console.WriteLine("\n---------------------- Zadanie 4 ----------------------");

            static int Fibonacci(int n)
            {
                if (n == 0)
                {
                    return 0;
                }
                if (n < 3)
                {
                    return 1;
                }
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }

            Console.WriteLine("Podaj ile wyrazów ciągu Fibonacciego chcesz wyświetlić: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ciąg Fibonacciego o " + n + " wyrazach:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }


            /* ZADANIE 5
            Utwórz klasę Osoba, która zawiera następujące pola: nazwisko, imie, ulica, kod i miasto oraz dwie 
            metody: wczytaj() i wyswietl(). Pierwsza z metod umożliwia wprowadzanie danych, natomiast druga 
            wyświetla je na ekranie komputera.
             */
            Console.WriteLine("\n---------------------- Zadanie 5 ----------------------");

            Osoba o = new Osoba();
            o.wczytaj();
            o.wyswietl();


            /* ZADANIE 6
            Napisz program, w którym klasa Kadra dziedziczy właściwości po klasie bazowej Osoba i zawiera dwa 
            dodatkowe pola: wyksztalcenie i stanowisko oraz dwie dodatkowe metody: wczytaj1() i wyswietl1().
             */
            Console.WriteLine("---------------------- Zadanie 6 ----------------------");

            Kadra k = new Kadra();
            k.wczytaj1();
            k.wyswietl1();
        }
    }

    class Pierwiastki
    {
        double a;
        double b;
        double c;
        double x1;
        double x2;
        int liczbaPierwiastkow;
        public void czytaj_dane()
        {
            do
            {
                Console.WriteLine("Podaj liczbę a (różną od 0): ");
                a = Convert.ToDouble(Console.ReadLine());

                if (a == 0)
                {
                    Console.WriteLine("Nieprawidłowa wartość. Podaj wartość liczby a różną od 0");
                }
            } while (a == 0);
            Console.WriteLine("Podaj liczbę b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbę c: ");
            c = Convert.ToDouble(Console.ReadLine());
        }

        public void przetworz_dane()
        {
            double delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                liczbaPierwiastkow = 2;
            }
            else if (delta == 0)
            {
                liczbaPierwiastkow = 1;
            }
            else
            {
                liczbaPierwiastkow = 0;
            }

            switch (liczbaPierwiastkow)
            {
                case 1:
                    x1 = Math.Round(-b / (2 * a), 2);
                    break;
                case 2:
                    x1 = Math.Round((-b - Math.Sqrt(delta)) / (2 * a), 2);
                    x2 = Math.Round((-b + Math.Sqrt(delta)) / (2 * a), 2);
                    break;
            }
        }

        public void wyswietl_wynik()
        {
            Console.WriteLine("Równanie kwadratowe: " + Math.Round(a, 2) + "x^2 + " + Math.Round(b, 2) + "x + " + Math.Round(c, 2) + " = 0");
            switch (liczbaPierwiastkow)
            {
                case 0:
                    Console.WriteLine("Brak pierwiastków równania");
                    break;
                case 1:
                    Console.WriteLine("Pierwiastek podwójny podanego równania kwadratowego x = : " + x1);
                    break;
                case 2:
                    Console.WriteLine("Pierwszy pierwiastek podanego równania kwadratowego x1 = : " + x1);
                    Console.WriteLine("Drugi pierwiastek podanego równania kwadratowego x2 = : " + x2);
                    break;
            }
        }
    }

    class Macierz
    {
        int[,] tab = new int[10, 10];
        public void czytaj_dane()
        {
            Random r = new Random();

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        tab[i, j] = r.Next(0, 9);
                    }
                    else
                    {
                        tab[i, j] = 0;
                    }
                }
            }
        }

        public void przetworz_dane()
        {
            int suma = 0;

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                suma += tab[i, i];
            }
            Console.WriteLine("\n\nSuma liczb na przekątnej: " + suma);
        }

        public void wyswietl_wynik()
        {
            Console.WriteLine("Zawartość tablicy: ");
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (j % 10 == 0)
                    {
                        Console.WriteLine();
                    }
                    Console.Write(tab[i, j] + " ");
                }
            }
        }

    }

    class Osoba
    {
        string nazwisko;
        string imie;
        string ulica;
        string kod;
        string miasto;

        public void wczytaj()
        {
            Console.WriteLine("------------- WPROWADŹ NASTĘPUJĄCE DANE ---------------");
            Console.WriteLine("Podaj swoje imie: ");
            imie = Console.ReadLine();
            Console.WriteLine("Podaj swoje nazwisko: ");
            nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj ulicę: ");
            ulica = Console.ReadLine();
            Console.WriteLine("Podaj kod pocztowy: ");
            kod = Console.ReadLine();
            Console.WriteLine("Podaj miasto: ");
            miasto = Console.ReadLine();
        }

        public void wyswietl()
        {
            Console.WriteLine("------------------ WPROWADZONO DANE -------------------");
            Console.WriteLine("Imię: " + imie);
            Console.WriteLine("Nazwisko: " + nazwisko);
            Console.WriteLine("Ulica: " + ulica);
            Console.WriteLine("Kod pocztowy: " + kod);
            Console.WriteLine("Miasto: " + miasto);
        }
    }

    class Kadra : Osoba
    {
        string wyksztalcenie;
        string stanowisko;

        public void wczytaj1()
        {
            wczytaj();
            Console.WriteLine("Podaj swoje wykształcenie: ");
            wyksztalcenie = Console.ReadLine();
            Console.WriteLine("Podaj swoje stanowisko: ");
            stanowisko = Console.ReadLine();
        }
        public void wyswietl1()
        {
            wyswietl();
            Console.WriteLine("Wykształcenie: " + wyksztalcenie);
            Console.WriteLine("Stanowisko: " + stanowisko);
        }
    }
}