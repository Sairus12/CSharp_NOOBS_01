using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arena
{
    class Test
    {
        private char znak;
        private int d,h,n,sum=0;
        /// <summary>
        /// Fce na zjištění znaků
        /// </summary>
        /// <param name="znak">Zjišťovaný znak</param>
        /// <returns>Vrací 1 - malé písmeno, 2 - velké písmeno, 3 - cifra, 0 - cokoliv ostatního</returns>
        public int znaky(char znak)
        {
            this.znak = znak;
            if ((znak >= 'a') && (znak <= 'z'))
                return 1;
            else
                if ((znak >= 'A') && (znak <= 'Z'))
                    return 2;
                else
                    if ((znak >= '0') && (znak <= '9'))
                        return 3;
                    else
                        return 0;
        }
        /// <summary>
        /// Fce, která zjistí zda jde o sudé nebo liché číslo
        /// </summary>
        /// <param name="cislo">Zjišťované číslo</param>
        /// <returns>Vrací 1 - sudé, 0 - liché</returns>
        public int sude(int cislo)
        {
            if (cislo % 2 == 0)
                return 1;
            else
                return 0;
        }
        /// <summary>
        /// Fce, která vrací součet čísel dělitelných n v intervalu <n,d>
        /// </summary>
        /// <param name="d">Dolní hranice intervalu</param>
        /// <param name="h">Horní hranice intervalu</param>
        /// <param name="n">Číslon ,kterým se bude dělit</param>
        /// <returns>Součet čísel dělitelných n</returns>
        public int interval(int d, int h, int n)
        {
            this.d = d;
            this.h = h;
            this.n = n;
            for (int i = d; i <= h; i++)
            {
                if (i % n == 0)
                    sum += i;
            }
            return sum;

        }
    }
}
