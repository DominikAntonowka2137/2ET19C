using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp26
{
    interface IBlock
    {
        void WyswietlBlock();
    }
    interface ILine
    {
        void WyswietlLine();
    }
    abstract class AbstractDisplay
    {

    }
    abstract class Element
    {
        public abstract string nazwa { get; set; }
        public abstract string opis { get; set; }
    }
    class Block : Element
    {
        public override string nazwa { get; set; }
        public override string opis { get; set; }
        public void span()
        {
            Console.WriteLine("span");
        }
    }
    class Line : Element 
    {
        public override string nazwa { get; set; }
        public override string opis { get; set; }
        public void b()
        {
            Console.WriteLine("b");
        }
        public void div()
        {
            Console.WriteLine("div");
        }
    }
    class HTML:AbstractDisplay, ILine, IBlock
    {
        public string tytul { get; set; }
        public string podtytul { get; set; }
        public void WyswietlLine() { Console.WriteLine("Wyświetlam Linie"); }
        public void WyswietlBlock() { Console.WriteLine("Wyświetlam Blok"); }
    }
    class JSON:AbstractDisplay
    {

    }
    class PDF:AbstractDisplay
    {

    }
    class Layout:HTML
    {
        List<HTML> html;
        public void Wypisz()
        {
            html.ForEach(Console.WriteLine);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<HTML> html;
            Layout l = new Layout();
            HTML h = new HTML();
            Console.WriteLine("Podaj tytul");
            h.tytul = Console.ReadLine();
            Console.WriteLine("Podaj podtytul");
            h.podtytul = Console.ReadLine();
            h.WyswietlLine();
            h.WyswietlBlock();
            l.Wypisz();

        }
    }
}
