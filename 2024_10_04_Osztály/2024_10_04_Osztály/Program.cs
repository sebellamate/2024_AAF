using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_04_Osztály
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Felhasznalo f1 = new Felhasznalo("szabdan", "123456");
            Console.WriteLine(f1.ToString());
            f1.jelszo = "987654";
            Console.WriteLine(f1.ToString());

            Console.ReadLine();
        }
    }
    static string Jelszo()
    {
        Console.WriteLine("Jelszo: ");
        string sz = "";

        ConsoleKeyInfo key = Console.ReadKey();
        switch (key.Key)
        {
            case ConsoleKey.Backspace:
                if(sz.Length > 0)
                {
                    sz = sz.Substring(sz.Length - 1);
                    Console.WriteLine("\b \b");
                }
                break;
            default:
                sz += key.KeyChar;
                Console.Write("*");
                break;
        }
        return sz;
    }
    class Felhasznalo
    {
        public string azon, jelszo;

        public Felhasznalo(string azon, string jelszo)
        {
            this.azon = azon;
            this.jelszo = jelszo;
        }

        public string Azon
        {
            get
            {
                return azon;
            }
            set
            {
                azon = value;
            }
        }

        //public int Pin { get; set; }
        //public string GetAzon()
        //{
        //    return azon;
        //}
        //public void SetAzon(string ujazon)
        //{
        //    azon = ujazon;
        //}
        public override string ToString()
        {
            return azon + " " + jelszo;
        }
    }
}
