using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_04_ÓraiMunka
{
    internal class Program
    {
        static List<Haromszog> haromszogek = new List<Haromszog>();
        static void Main(string[] args)
        {
            FajlBeolvasas();
            Feladat1();
            Feladat2();
            Feladat3();

            Console.ReadLine();
        }
        static void Feladat1()
        {
            Console.WriteLine("{0} darab nem szerkeszthető 3szög van a listában", HanyNemSzerkeszthetoVan());
        }
        static void Feladat2()
        {
            int index = MaxTeruletuHaromszogIndexe();
            Haromszog sv = haromszogek[index];
            Console.WriteLine("Max területű 3szög oldalai: a={0} b={1} c={2}", sv.A, sv.B, sv.C);
        }
        static void Feladat3()
        {
            string szoveg = VanESzabalyosHaromszog() ? "Van szabályos 3szög" : "Nincs szabályos 3szög";
            Console.WriteLine(szoveg);
        }
        private static bool VanESzabalyosHaromszog()
        {
            for(int i = 0; i < haromszogek.Count; i++)
            {
                if (haromszogek[i].SzabalyosE())
                {
                    return true;
                }
            }
            return false;
        }
        private static int MaxTeruletuHaromszogIndexe()
        {
            int maxi = 0;
            for(int i = 1; i < haromszogek.Count; i++)
            {
                if (haromszogek[i].SzerkeszthetoE() && haromszogek[i].Terulet() > haromszogek[maxi].Terulet())
                {
                    maxi = i;
                }
            }
            return maxi;
        }
        private static int HanyNemSzerkeszthetoVan()
        {
            int szamlalo = 0;
            for (int i = 0; i < haromszogek.Count; i++)
            {
                if (!haromszogek[i].SzerkeszthetoE())
                {
                    szamlalo++;
                }
            }
            return szamlalo;
        }

        private static void FajlBeolvasas()
        {
            StreamReader f = new StreamReader("haromszogek.txt");

            f.ReadLine();
            while (!f.EndOfStream)
            {
                Haromszog sh = new Haromszog(f.ReadLine());
                haromszogek.Add(sh);
            }
            f.Close();
        }
    }
}
