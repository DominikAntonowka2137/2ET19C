using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            /*
                        for (int i = 1; i <= 30; i++)
                        {
                            Console.WriteLine(i + " listopad 2022");
                        }
            */


            //2
            /*
                        for (int i = 1; i < 100; i++)
                        {
                            if (i%2==1)
                            {
                                Console.WriteLine(i*i);
                            }
                        }
            */

            //3
            /*
                        for (int i = 1000; i <= 9999; i++)
                        {
                            if (i%379==0)
                            {
                                Console.WriteLine(i);
                            }
                        }
            */

            //4
            /*
                        for (int i = 100; i <= 999; i++)
                        {
                            if (i%5==0 && i%6==0 || i%11==0)
                            {
                                Console.WriteLine(i);
                            }
                        }
            */

            //5
            /*
                        int a = int.Parse(Console.ReadLine());
                        int suma = 0;
                        for (int i = 1; i <= a; i++)
                        {
                            suma += i;
                        }
                        Console.WriteLine(suma);
            */

            //6
            /*
                        int suma = 0, pow = 0;
                        for (int i = 1; i < 100; i++)
                        {
                            pow = 0;
                            for (int j = 2; j < i; j++)
                            {
                                if (i % j == 0)
                                {
                                    pow = pow + 1;
                                    break;
                                }
                            }
                            if (pow == 0)
                            {
                                if (i%2==0)
                                {
                                    suma += i;
                                }
                                Console.WriteLine($"pierwsza to {i}");

                            }
                        }
                        Console.WriteLine(suma);
            */

            //7
            /*
                        int n = int.Parse(Console.ReadLine());
                        int suma = 0, pow = 0;
                            for (int i = 10; i < n; i++)
                            {
                                pow = 0;
                                for (int j = 2; j < i; j++)
                                {
                                    if (i % j == 0)
                                    {
                                        pow = pow + 1;
                                        break;
                                    }
                                }
                                if (pow == 0)
                                {
                                    if (i % 2 == 1)
                                    {
                                        suma += i;
                                    }
                                    Console.WriteLine($"pierwsza to {i}");

                                }
                            }

                        Console.WriteLine(suma);
            */

            //8
            Console.WriteLine("Podaj ile lat");
            float lata = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj kwote");
            double kwota = double.Parse(Console.ReadLine());
            double wynik = 0;
            double mc = lata * 12;
            for (int i = 0; i <= lata; i++)
            {
                wynik += kwota * 6.00 / 100;
                
            }
            kwota += wynik;
            Console.WriteLine(kwota);

        }
    }
}
