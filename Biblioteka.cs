using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Autor
    {
        private string imie;
        private string nazwisko;
    }
    class Ksiazka
    {
        private Autor autor;
        private int numer;
        private string tytuł;
        public Ksiazka(Autor aautor)
        {
            this.autor = aautor;
        }
    }
    class Polka
    {
        private int nrPolki;
    }
    class Regal
    {
        private Polka polka;
        private int nrRegal;
        public Regal(Polka polkaa)
        {
            this.polka = polkaa;
        }
    }
    class Dzial
    {
        private int nrDzial;
        private string gatunek;
        private Ksiazka ksiazka;

    }
    class Stanowisko
    {
        private string nazwa;
    }
    class Pracownik
    {
        private int idPracownik;
        private Stanowisko stanowisko;
        public Pracownik(Stanowisko astanowisko)
        {
            this.stanowisko = astanowisko;
        }

    }
    class Biblioteka
    {

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Bibliotekar");
        }
    }
}
