using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_14_Static
{
    internal class DatumIdo
    {
        /// <summary>
        /// Dátum értékéből kiszedi a(z) év értékét.
        /// </summary>
        /// <param name="datum">
        /// Formátuma: év*hónap*nap
        /// * egykarakterből álló elválasztó
        /// pl. 2024_11_14
        /// </param>
        /// <returns>A(z) év kialakítása konvertálással</returns>
        public static int DatumEv(string datum)
        {
            char sc = datum[4];
            string[] st = datum.Split(sc);
            return Convert.ToInt32(st[0]);
        }
        /// <summary>
        /// Dátum értékéből kiszedi a(z) hónap értékét.
        /// </summary>
        /// <param name="datum">
        /// Formátuma: év*hónap*nap
        /// * egykarakterből álló elválasztó
        /// pl. 2024_11_14
        /// </param>
        /// <returns>A(z) hónap kialakítása konvertálással</returns>
        public static string DatumHonap(string datum)
        {
            char sc = datum[4];
            string[] st = datum.Split(sc);
            return st[1];
        }
        /// <summary>
        /// Dátum értékéből kiszedi a(z) nap értékét.
        /// </summary>
        /// <param name="datum">
        /// Formátuma: év*hónap*nap
        /// * egykarakterből álló elválasztó
        /// pl. 2024_11_14
        /// </param>
        /// <returns>A(z) nap kialakítása konvertálással</returns>
        public static string Datumnap(string datum)
        {
            char sc = datum[4];
            string[] st = datum.Split(sc);
            return st[2];
        }
        public static bool SzokoEv(string datum)
        {
            char sc = datum[4];
            string[] st = datum.Split(sc);

            if (Convert.ToInt32(st[0]) % 4 == 0 && Convert.ToInt32(st[0]) % 100 != 0)
            {
                return true;
            }
            else
            {
                if(Convert.ToInt32(st[0]) % 400 == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
