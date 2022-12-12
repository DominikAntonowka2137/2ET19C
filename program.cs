using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Rower
    {
        private Producent producent;
        private Material material;
        private string color;
        public void drive()
        {
            Console.WriteLine("jedź");
        }

        public void setColor(acolor)
        {
            this.color = acolor;
        }

        public string getColor(acolor)
        {
            return this.color;
        }
    }
    class Producent
    {
        private string nazwa()
        {
            return this.nazwa;
        }
        private string nip()
        {
            return this.nip;
        }
        public string getNazwa()
        {
            return this.nazwa;
        }
        public void getNip()
        {
            return this.Nip;
        }
        public void setNazwa(aid)
        {
            this.id=aid;
        }
    }
    class Material
    {
        private string typ()
        {
            return this.typ;
        }
        private int id()
        {
            return this.id;
        }
        private double cena()
        {
            return this.cena;
        }
        public void setTyp(atyp)
        {
            this.typ=atyp;
        }
        public void getCena()
        {
            return this.cena;
        }
        public void setId(aid)
        {
            this.id = aid;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Producent p = new Producent();
            Material m = new Material();
            Rower r = new Rower(r);
        }
    }
}