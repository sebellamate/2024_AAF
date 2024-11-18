using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_15_Szimulátor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kocsmaros a1 = new Kocsmaros(50);
            Ember e1 = new Ember("Imre", 22, true, 100);
            e1.iszik(a1);
        }
    }
}
