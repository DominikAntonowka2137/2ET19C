using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 suma n poczarowych liczb 3 cyfrowych
            /*
                        int n = int.Parse(Console.ReadLine());
                        int suma = 0;
                        for (int i = 100; i < 100+n; i++)
                        {
                            suma += i;
                        }
                        Console.WriteLine(suma);
            */
            //2 suma k poczatkowych liczb ciagu fibonaciego
            /*
                        int k = int.Parse(Console.ReadLine()), suma = 1;
                        for (int i = 2; i < k; i++)
                        {
                            suma += i;
                            Console.WriteLine(i);
                        }
                        Console.WriteLine(suma);
            */

            //3 sprawdzenie czy liczba n jest doskonała 
            /*
                        int n = int.Parse(Console.ReadLine()),suma=0;
                        for (int i = 1; i < n; i++)
                        {
                            if (x%i==0)
                            {
                                suma+=i
                            }
                        }
                        if (suma==n)
                        {
                            Console.WriteLine("tak");
                        }
                        else Console.WriteLine("nie");
            */
            //4 znajdz sume n liczb poczatkowych wyrazów ciągu
            int n = int.Parse(Console.ReadLine()), suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma += ((int)(3 * Math.Pow(2, i)));
            }
            Console.WriteLine(suma);

        }
    }
}
