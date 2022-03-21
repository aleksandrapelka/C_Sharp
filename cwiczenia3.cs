using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ZADANIE 1
            Utwórz klasę Osoba, która zawiera następujące pola: nazwisko, imie, ulica, nr ulicy, kod i 
            miasto oraz wirtualne metody wczytaj i wyświetl służące do ich obsługi. Następnie stwórz 
            klasę Kadra, która dziedziczy po klasie Osoba i zawiera dodatkowe pola: wykształcenie, 
            stanowisko i PESEL oraz funkcje wczytujące i wyświetlające zawartości pól. Klasa Kadra 
            powinna zawierać funkcję sprawdzającą poprawność numeru PESEL. Następnie przetestuj w 
            programie działanie mechanizmu polimorfizmu.
            */
            Console.WriteLine("--------------------- Zadanie 1 -----------------------");

            void dane(Osoba o)
            {
                o.wczytaj();
                o.wyswietl();
            }
            
            Osoba o = new Osoba();
            o.wczytaj();
            o.wyswietl();

            Kadra k = new Kadra();
            k.wczytaj();
            k.wyswietl();

            Osoba o2 = new Osoba();
            Kadra k2 = new Kadra();
            dane(o2);
            dane(k2);


            /* ZADANINE 2
              Utwórz prostą klasę, która implementuje wzorzec singleton(można stworzyć 
              tylko jeden egzemplarz danej klasy).
             */
            Console.WriteLine("--------------------- Zadanie 2 -----------------------");

            Singleton s = Singleton.Instance;
            s.przywitajSie();
            Singleton s2 = Singleton.Instance;
            s2.przywitajSie();

            if(s == s2)
            {
                Console.WriteLine("Obiekty są tą samą instancją");
            }
            else
            {
                Console.WriteLine("Obiekty są dwiema różnymi instancjami");
            }


            /* ZADANIE 3
              Napisz program, w którym należy stworzyć tablicę krotek o rozmiarze podanym przez użytkownika. 
              Krotka ma być zbudowana w następujący sposób: nazwisko, imię, nr_id. Następnie należy 
              przetestować działanie tablicy.
             */
            Console.WriteLine("--------------------- Zadanie 3 -----------------------");

            Console.WriteLine("Podaj rozmiar tablicy: ");
            int rozmiar = Convert.ToInt32(Console.ReadLine());
            (string nazwisko, string imie, int nr_id)[] tablica = new (string nazwisko, string imie, int nr_id)[rozmiar];

            string nazwisko;
            string imie;
            for(int i = 0; i < rozmiar; i++)
            {
                Console.WriteLine("Podaj imię: ");
                imie = Console.ReadLine();
                Console.WriteLine("Podaj nazwisko: ");
                nazwisko = Console.ReadLine();

                tablica[i] = (nazwisko, imie, i);
            }

            Console.WriteLine();
            for(int i = 0; i < rozmiar; i++)
            {
                Console.WriteLine(tablica[i].nr_id + ".  " + tablica[i].imie + " " + tablica[i].nazwisko);
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

        public virtual void wczytaj()
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

        public virtual void wyswietl()
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
        string PESEL;

        public override void wczytaj()
        {
            base.wczytaj();
            Console.WriteLine("Podaj swoje wykształcenie: ");
            wyksztalcenie = Console.ReadLine();
            Console.WriteLine("Podaj swoje stanowisko: ");
            stanowisko = Console.ReadLine();

            do
            {
                Console.Write("Podaj swój PESEL: ");
                PESEL = Console.ReadLine();
                czyPoprawny();

            }while(!sprawdzPesel());           
        }

        public void czyPoprawny()
        {
            Console.WriteLine("\n----------- SPRAWDZANIE POPRAWNOŚCI PESEL -------------\n");
            if (sprawdzPesel())
            {
                Console.WriteLine("***************** | PESEL poprawny | *****************\n");
            }
            else
            {
                Console.WriteLine("******* | PESEL niepoprawny. Spróbuj ponownie. | *******\n");
            }
        }

        public bool sprawdzPesel()
        {
            int[] waga = {1, 3, 7, 9, 1, 3, 7, 9, 1, 3};
            bool czyPoprawny = false;

            if (PESEL.Length == 11)
            {
                int suma = 0;
                for(int i = 0; i < PESEL.Length-1; i++)
                {
                    suma += waga[i] * (Convert.ToInt32(PESEL[i])-48);
                }

                int kontrolna = (int)PESEL[PESEL.Length - 1] - 48;
                if (((10 - (suma % 10)) == kontrolna) || (suma % 10 == kontrolna))
                {
                    czyPoprawny = true;
                }             
            }
            return czyPoprawny;
        }     
        
        public override void wyswietl()
        {
            base.wyswietl();
            Console.WriteLine("Wykształcenie: " + wyksztalcenie);
            Console.WriteLine("Stanowisko: " + stanowisko);
            Console.WriteLine("PESEL: " + PESEL);
        }
    } 

    class Singleton
    {
        private static Singleton instance;
        private Singleton() { }
        public static Singleton Instance 
        { 
            get 
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance; 
            } 
        }

        public void przywitajSie()
        {
            Console.WriteLine("Cześć, jestem Singleton");
        }
    }
}
