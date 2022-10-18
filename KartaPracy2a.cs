using System;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sprawdź czy suma dwóch wpisanych przez użytkownika jest liczbą parzystą.
            /*
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int wynik = a + b;
                if (wynik%2==0)
                {
                    Console.WriteLine("Tak");
                }
                else
                    Console.WriteLine("Nie");
    */


            //2
/*
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sredniaary = a + b / 2;
            int sredniageo = 
*/
            //4
            /*
                        Console.WriteLine("Podaj liczbę całkowite: ");
                        int a = int.Parse(Console.ReadLine());
                        int wynik = 0;
                        wynik = a;
                        Console.WriteLine("Podaj kolejną liczbę:");
                        int b = int.Parse(Console.ReadLine());
                        if (wynik > b) { wynik = b; }
                        Console.WriteLine("Podaj kolejną liczbę:");
                        int c = int.Parse(Console.ReadLine());
                        if (wynik > c) { wynik = c; }
                        Console.WriteLine("Podaj kolejną liczbę:");
                        int d = int.Parse(Console.ReadLine());
                        if (wynik > d) { wynik = d; }
                        Console.WriteLine($"Najmniejsza liczba spośród podanych to {wynik}");
            */



            // 5/6
            /*
                        Console.WriteLine("Podaj 3 liczby- całkowite: ");
                        int a = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        int c = int.Parse(Console.ReadLine());
                        if (a < b + c && b < a + c && c < a + b)
                        {
                            Console.WriteLine("Trójkąt spełnia równanie");
                            if (a * a + b * b == c * c || a * a + c * c == b * b || c * c + b * b == a * a)
                            {
                                Console.WriteLine("Trójkąt prostokątny");
                            }
                            else if (a * a + b * b < c * c || a * a + c * c < b * b || c * c + b * b < a * a)
                            {
                                Console.WriteLine("Trójkąt ostrokątny");
                            }
                            else if (a * a + b * b > c * c || a * a + c * c > b * b || c * c + b * b > a * a)
                            {
                                Console.WriteLine("Trójkąt rozwartokątny");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Trójkąt nie spełnia równania");
                        }
            */
        }
    }
}
