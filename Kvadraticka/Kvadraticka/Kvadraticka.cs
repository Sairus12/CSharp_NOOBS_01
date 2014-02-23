using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kvadraticka
{
    class Kvadraticka
    {
        protected int a;
        protected int b;
        protected int c;
        protected double x1;
        protected double x2;
        public Kvadraticka(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Vypocet()
        {
            if (Resitelnost() == 1)
            {
                x1 = (-b + Math.Sqrt(VypocetDiskriminantu())) / (2.0 * a);
                x2 = (-b - Math.Sqrt(VypocetDiskriminantu())) / (2.0 * a);
                Console.WriteLine("Výsledky kvadratiké rovnice {0}x^2 + {1}x + {2} = 0 je: \n\tx1 = {3}\n\tx2 = {4}",a,b,c,x1,x2);
            }
            else if (Resitelnost() == 0)
            {
                x1 = (-b / (2.0 * a));
                Console.WriteLine("Výsledek kvadratiké rovnice {0}x^2 + {1}x + {2} = 0 je: \n\tx1 = {3}",a,b,c,x1);
            }
            else
                Console.WriteLine("Kvadratická rovnice {0}x^2 + {1}x + {2} = 0 nemá řešení.", a, b, c);

        }
        public int Resitelnost()
        {
            if (((b * b) - (4 * a * c)) > 0)
                return 1;

            else if (((b * b) - (4 * a * c)) < 0)
                return -1;

            else
                return 0;
        }
        public int VypocetDiskriminantu()
        {
            if (Resitelnost() >= 1)
                return (((b * b) - (4 * a * c)));
            else if (Resitelnost() == 0)
                return 0;
            else
                return -1;
        }
    }
}
