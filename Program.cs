using System;

namespace ConsoleApp6
{
    class Klasa {
        public string metoda()
        {
            string typ="Nie ma nic w tej metodzie";
            return typ;
        }
        public string metoda(int a)
        {
            string typ = "To jest int";
            return typ;
        }
        public string metoda(double a)
        {
            string typ = "To jest liczba zmienno przecinkowa";
            return typ;
        }
        public string metoda(string a)
        {
            string typ = "To jest string";
            return typ;
        }
        public string metoda(int a, int b)
        {
            string typ = "Dwie zmienne!";
            return typ;
        }
    };
    class Program
    {
        static void Main(string[] args)
        {
            Klasa k = new Klasa();
         Console.WriteLine(k.metoda(10));
         Console.WriteLine(k.metoda("Wpisuje"));
         Console.WriteLine(k.metoda(10.5));
         Console.WriteLine(k.metoda(10, 10));

            Console.ReadLine();
        }
    }
}
