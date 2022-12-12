using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
        class Koszyk
    {
        private int id;
        private Produkt produkt;
        private Uzytkownik uzytkownik;
        public string getId()
        {
            return this.id;
        }
       public void operation()
        {
            Console.WriteLine("Operacja");
        }
    }
    class Uzytkownik
    {
        private Profil profil;
        private string login;
        private string haslo;
        public void loguj()
        {
            Console.WriteLine("loguje");
        }
    }
    class Profil
    {
        private string imie;
        private string drugieimie;
        private string nazwisko;
        public string getImie()
        {
            return this.imie;
        }
       public string getNazwisko()
        {
            return this.nazwisko;
        }
    }
    class Produkt
    {
        private string nazwa;
        private double cena;
        private string opis;
        public void getNazwa()
        {
            return this.nazwa;
        }
        public void getCena()
        {
            return this.cena;
        }
        public void getOpis()
        {
            return this.opis;
        }

        public void produkt(nazwa, cena, opis)
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Profil p = new Profil();
            Uzytkownik u = new Uzytkownik();
            Produkt r = new Produkt();
        }
    }
}