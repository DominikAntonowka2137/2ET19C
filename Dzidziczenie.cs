using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Pojazd
    {
        string nazwa;
        string vin;

        public void jedz()
        {
            Console.WriteLine("Jadę");
        }
        public void tankuj()
        {
            Console.WriteLine("tankuję");
        }
    }

    class Samochód : Pojazd
    {
        string oc;

        public void zaparkuj()
        {
            Console.WriteLine("Parkuję");
        }
    }

    class Motur : Pojazd
    {
        public void zalozKask()
        {
            Console.WriteLine("Zakladam");
        }
    }

    class Koparka : Pojazd
    {
        string udt;

        public void kop()
        {
            Console.WriteLine("Kopię");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Samochód s = new Samochód();
            Motur m = new Motur();
            s.jedz();
            m.tankuj();
        }
    }
}
