using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Kalk
    {
        /// <summary>
        /// Vypočítá součet zadaných čísel
        /// </summary>
        /// <param name="a">První číslo</param>
        /// <param name="b">Druhé číslo</param>
        /// <returns>Vrací součet čísel</returns>
        public int soucet(int a, int b)
        {
            return (a + b);
        }
        /// <summary>
        /// Vypočítá rozdil zadaných čísel
        /// </summary>
        /// <param name="a">První číslo</param>
        /// <param name="b">Druhé číslo</param>
        /// <returns>Vrací rozdil čísel</returns>
        public int rozdil(int a, int b)
        {
            return (a - b);
        }
        /// <summary>
        /// Vypočítá soucin zadaných čísel
        /// </summary>
        /// <param name="a">První číslo</param>
        /// <param name="b">Druhé číslo</param>
        /// <returns>Vrací soucin čísel</returns>
        public int soucin(int a, int b)
        {
            return (a * b);
        }
        /// <summary>
        /// Vypočítá podil zadaných čísel
        /// </summary>
        /// <param name="a">První číslo</param>
        /// <param name="b">Druhé číslo</param>
        /// <returns>Vrací podil čísel</returns>
        public double podil(double a, double b)
        {
            return (a / b);
        }
        /// <summary>
        /// Vypočte a vrátí druhou mocninu dvou čísel
        /// </summary>
        /// <param name="a">První číslo</param>
        /// <param name="b">Druhé číslo</param>
        /// <returns>Vrací druhou mocninu dvou zadaných čísel</returns>
        public string nadruhou(int a, int b)
        {
            return (String.Format("\nPrvní číslo na druhou je: {0}\nDruhé číslo na druhou je: {1}", a * a, b * b));
        }
        /// <summary>
        /// Vypočte a vrátí druhou odmocninu ze dvou čísel
        /// </summary>
        /// <param name="a">První číslo</param>
        /// <param name="b">Druhé číslo</param>
        /// <returns>Vrátí druhou odmocninu ze zadaných čísel</returns>
        public string druhaodmocnina(int a, int b)
        {
            return (String.Format("\nDruhá odmocnina z prvního čísla je: {0}\nDruhá odmocnina z druhého je: {1}", Math.Sqrt(a), Math.Sqrt(b)));
        }
    }
}
