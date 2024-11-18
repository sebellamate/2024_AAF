using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_15_Szimulátor
{
    internal class Kocsmaros
    {
        private int penz;
        public static int koszospohar;

        public int Penz
        {
            get { return penz; }
            set { penz = value; }
        }
        public Kocsmaros(int penz)
        {
            this.penz = penz;
        }
    }
}
