using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        public void setColor(string acolor)
        {
            this.color = acolor;
        }

        public string getColor()
        {
            return this.color;
        }
        public void setMaterial(Material amaterial)
        {
            this.material = amaterial;
        }
        public Rower(Producent aproducent)
        {
            this.producent = aproducent;
        }
    }
    class Producent
    {
        private string nazwa;
        private string nip;
        public string getNazwa()
        {
            return this.nazwa;
        }
        public string getNip()
        {
            return nip;
        }
        public void setNazwa(string anazwa)
        {
            this.nazwa = anazwa;
        }
    }
    class Material
    {
        private string typ;
        private int id;
        private double cena;
        public void setTyp(string atyp)
        {
            this.typ = atyp;
        }
        public string getTyp()
        {
            return this.typ;
        }
        public void setCena(double cena)
        {
            this.cena = cena;
        }
        public double getCena()
        {
            return this.cena;
        }
        public void setId(int aid)
        {
            this.id = aid;
        }
        public int getId()
        {
            return this.id;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Producent p = new Producent();
            Material m = new Material();
            Rower r = new Rower(p);
            p.setNazwa("romet");
            r.setColor("blue");
            m.setTyp("aluminium");
            m.setId(2137);
            Console.WriteLine($"Marka: {p.getNazwa()}, Kolor: {r.getColor()}, Typ materiału: {m.getTyp()}, Id: {m.getId()}");
        }
    }
}
