using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_07_ÓraiMunkaClassok
{
    internal class Program
    {
        static List<Szamitogep> lista = new List<Szamitogep>();
        static void Main(string[] args)
        {
            Feladat0();
            Feladat1();
            Feladat2();
            Feladat3();
            Console.ReadLine();
        }
        static void Feladat3()
        {
            LegmagasabbMemoria();
        }
        static bool LegmagasabbMemoria()
        {
            int index = 0;
            for(int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Szabadmemoria > lista[index].Szabadmemoria)
                {
                    index = i;
                }
                return lista[index].BeVanEKapcsolva;
            }
            return false;
        }
        static void Feladat2()
        {
            HolVanBekapcsolva();
        }
        static int HolVanBekapcsolva()
        {
            int db = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].BeVanEKapcsolva)
                {
                    db++;
                }
            }
            return db;
        }
        static void Feladat1()
        {
            FajlBeolvasas();
        }
        static void FajlBeolvasas()
        {
            StreamReader f = new StreamReader("Szamitogep.txt");

            f.ReadLine();
            while (!f.EndOfStream)
            {
                Szamitogep sh = new Szamitogep(f.ReadLine());
                lista.Add(sh);
            }
            f.Close();
        }
        static void Feladat0()
        {
            Szamitogep szg2 = new Szamitogep();
            Szamitogep szg1 = new Szamitogep(2048, false);

            Console.WriteLine(szg1.ToString()); 
            Console.WriteLine(szg2.ToString());

            szg1.Kapcsol();
            ProgramMasolas(szg1, 800);
            ProgramMasolas(szg1, 400);
            szg2.Kapcsol();
            ProgramMasolas(szg2, 1);
        }
        static void ProgramMasolas(Szamitogep sz, double hely)
        {
            if (sz.ProgramMasol(hely))
            {
                Console.WriteLine("Sikerült a másolás.");
            }
            else
            {
                Console.WriteLine("Nem sikerült a másolás");
            }
            Console.WriteLine(sz.ToString());
        }
    }
}
