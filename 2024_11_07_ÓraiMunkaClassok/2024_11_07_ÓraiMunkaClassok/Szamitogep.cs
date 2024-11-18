using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_07_ÓraiMunkaClassok
{
    internal class Szamitogep
    {
       public double Szabadmemoria;
       public bool BeVanEKapcsolva;

        public Szamitogep(double Szabadmemoria, bool BeVanEKapcsolva)
        {
            this.Szabadmemoria = Szabadmemoria;
            this.BeVanEKapcsolva = BeVanEKapcsolva;
        }
        public Szamitogep()
        {
            Szabadmemoria = 1024;
            BeVanEKapcsolva = false;
        }
        public Szamitogep(string sor)
        {
            string[] st = sor.Split('\t');
            Szabadmemoria = sor[0];
            if (sor[1] == 'x')
            {
                BeVanEKapcsolva = true;
            }
            else
            {
                BeVanEKapcsolva = false;
            }
        }
        public void Kapcsol()
        {
            //if (!BeVanEKapcsolva)
            //{
            //    BeVanEKapcsolva = true;
            //}
            //else
            //{
            //    BeVanEKapcsolva = false;
            //}
            BeVanEKapcsolva = !BeVanEKapcsolva;
        }
        public bool ProgramMasol(double MegaByte)
        {
            if(BeVanEKapcsolva && Szabadmemoria-MegaByte >= 0)
            {
                Szabadmemoria -= MegaByte;
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return string.Format("Szabad memória: " + Szabadmemoria + " " + (BeVanEKapcsolva ? "Be van kapcsolva a gép" : "Nincs bekapcsolva a gép"));
        }
    }
}
