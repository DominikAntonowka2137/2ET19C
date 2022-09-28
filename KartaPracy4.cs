using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                        int a, b;
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine((a*a)+(b*b));
                        Console.ReadKey();
            */

            /*
                        int x = int.Parse(Console.ReadLine());
                        int y = int.Parse(Console.ReadLine());
                        int z = int.Parse(Console.ReadLine());
                        int a, b, c;

                        if (x==y && x==z && y==z)
                        {
                            a = x;
                            b = y;
                            c = z;
                            Console.WriteLine($"{a} {b} {c}");
                        }
                        else if (x<y && x<z)
                        {
                            a = x;
                            if (y<z)
                            {
                                b = y;
                                c = z;
                                Console.WriteLine($"{a} {b} {c}");
                            }
                            else
                            {
                                b = z;
                                c = y;
                                Console.WriteLine($"{a} {b} {c}");
                            }
                        }
                        else if (y < z && y < x)
                        {
                            a = y;
                            if (z<x)
                            {
                                b = z;
                                c = x;
                                Console.WriteLine($"{a} {b} {c}");
                            }
                            else
                            {
                                b = x;
                                c = z;
                                Console.WriteLine($"{a} {b} {c}");
                            }
                        }
                        else
                        {
                            a = z;
                            if (x<y)
                            {
                                b = x;
                                c = z;
                                Console.WriteLine($"{a} {b} {c}");
                            }
                            else
                            {
                                b = z;
                                c = x;
                                Console.WriteLine($"{a} {b} {c}");
                            }
                        }
                        Console.ReadKey();*/
            /*
                        int wynik = 1;
                        int x = int.Parse(Console.ReadLine());
                        for (int i = 1; i < x; i++)
                        {
                            wynik *= i;
                        }
                        Console.WriteLine(wynik);
                        Console.ReadKey();
            */

            /*
                        for (int i = -7; i <= 17; i+=4)
                        {
                            Console.WriteLine(i);
                        }


                        int x = -7;
                        while (x<=17)
                        {
                            Console.WriteLine(x);
                            x += 4;
                        }

                        //zad 6

                        for (int i = 2; i <= 486; i*=3)
                        {
                            Console.WriteLine(i);
                        }

                        int a = 2;
                        while (a<=486)
                        {
                            Console.WriteLine(a);
                            a *= 3;
                        }
            */
            /*
                        int cyfry = 0;
                        int liczba = int.Parse(Console.ReadLine());
                        while (liczba > 0)
                        {
                            liczba /= 10;
                            Console.WriteLine(liczba);
                            cyfry += 1;
                        }
                        Console.WriteLine(cyfry);
            */
            /*
                        int x = 0, suma = 0;
                        int liczba = int.Parse(Console.ReadLine());
                        while (liczba > 0)
                        {
                            x = liczba % 10;
                            suma += x;
                            liczba /= 10;
                        }
                        Console.WriteLine(suma);
            */
            int n = int.Parse(Console.ReadLine());
            int dzielniki = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    dzielniki += 1;
                }
            }
            if (dzielniki ==2)
            {
                Console.WriteLine("Tak");
            }
            else
            {
                Console.WriteLine("Nie");
            }
        }
    }
}
