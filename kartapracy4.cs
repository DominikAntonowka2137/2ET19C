using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        public static int kp1z1(int a, int b)
        {
            return a * a + b * b;
        }

        public static bool kp2z2(int a)
        {
            if (a >= 100 && a<=999 && a%17==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool kp2z6(int a, int b)
        {
            if ((Math.Pow(a, b) - a) % b == 0) return true;
            return false;
        }

        public static void kp3z1(int a)
        {
            for (int i = 0; i <= a; i++)
            {
                Console.WriteLine(i * i * i + 3);
            }
        }

        public static void kp3z3(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                if (a%i==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {

            //kp1z1
            /*
                        int a = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine(kp1z1(a, b));
            */

            //kp2z2

            /*
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine(kp2z2(a));
            */

            //kp2z6

            /*
                        int a = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine(kp2z6(a, b));
            */


            //kp3z1
            /*
                        int a = int.Parse(Console.ReadLine());
                        kp3z1(a);
            */


            //kp3z3
            int a = int.Parse(Console.ReadLine());
            kp3z3(a);

        }
    }
}
