using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_15_Szimulátor
{
    internal class Ember
    {
        private string nev;
        private int kor;
        private bool ferfi;
        private int penz;
        private int reszegseg;
        private bool kocsmaban;
        public string Nev
        {
            get { return nev; }
        }

        public int Kor
        {
            get { return kor; }
        }
        public int Penz
        {
            get { return penz; }
            set { penz = value; }
        }
        public int Reszegseg
        {
            get { return reszegseg; }
        }
        public bool Ferfi
        {
            get { return ferfi; }
        }
        public bool Kocsmaban
        {
            get { return kocsmaban; }
        }

        public Ember(string nev, int kor, bool ferfi, int penz)
        {
            this.nev = nev;
            this.kor = kor;
            this.ferfi = ferfi;
            this.penz = penz;
            this.reszegseg = 0;
            this.kocsmaban = false;
        }
        public void iszik(Kocsmaros kocsmaros, Ital ital)
        {
            if (kocsmaban)
            {
                penz -= 1;
                reszegseg += 1;
                Kocsmaros.koszospohar += ital.Ar;
                kocsmaros.Penz += ital.Alkoholtartalom;
            }
            else
            {
                Console.WriteLine("Nincs a kocsmában.");
            }
            if(reszegseg == 40)
            {
                alszik();
            }
        }
        public void iszik(Kocsmaros kocsmaros)
        {
            if (kocsmaban)
            {
                penz -= 1;
                reszegseg += 1;
                Kocsmaros.koszospohar += 1;
                kocsmaros.Penz += 1;
            }
            else
            {
                Console.WriteLine("Nincs a kocsmában.");
            }
            if (reszegseg == 40)
            {
                alszik();
            }
        }
        public void alszik()
        {
            reszegseg = 0;
            Console.WriteLine("Elaludt");
        }
        public void Hazamegy()
        {
            kocsmaban = false;
        }
        public void jon()
        {
            kocsmaban = true;
        }
    }
}
