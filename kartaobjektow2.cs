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
        public int getId()
        {
            return this.id;
        }
        public void setId(int aid)
        {
            this.id = aid;
        }
        public void operation()
        {
            Console.WriteLine("Operacja");
        }
        public void setUzytkownik(Uzytkownik auzytkownik)
        {
            this.uzytkownik = auzytkownik;
        }
        public Koszyk(Produkt aprodukt)
        {
            this.produkt=aprodukt;
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
        public Uzytkownik(Profil aprofil)
        {
            this.profil = aprofil;   
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
        public string getNazwa()
        {
            return this.nazwa;
        }
        public double getCena()
        {
            return this.cena;
        }
        public string getOpis()
        {
            return this.opis;
        }

        public Produkt(string anazwa,double acena,string aopis)
        {
            this.nazwa = anazwa;
            this.cena = acena;
            this.opis = aopis;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Profil p = new Profil();
            Uzytkownik u = new Uzytkownik(p);
            Produkt prod = new Produkt("nazwa", 312.99, "opis");
            Koszyk k = new Koszyk(prod);
            k.setUzytkownik(u);
        }
    }
}
