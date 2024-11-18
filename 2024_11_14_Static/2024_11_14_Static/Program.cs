﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_14_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static - példányosítás nélkül felhasználható adattagok és metódusok.
            //Random rnd = new Random();
            //Math.Sqrt(2);

            //Szalagavato 12a = new Szalagavato(12, "a");
            // - tánc, jegyek eladása, osztályfőnök ...
            // Static - bevétel, igazgató
            string datum = "2024_11_14";
            Console.WriteLine(datum);
            Console.WriteLine($"Év: {DatumIdo.DatumEv(datum)}");
            Console.WriteLine($"Hónap: {DatumIdo.DatumHonap(datum)}");
            Console.WriteLine($"Nap: {DatumIdo.Datumnap(datum)}");
            Console.WriteLine($"Év: {DatumIdo.SzokoEv(datum)}");
            Console.ReadLine();
        }
    }
}
