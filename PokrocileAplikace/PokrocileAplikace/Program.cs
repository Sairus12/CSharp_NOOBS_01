using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokrocileAplikace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole;
            pole = new int[10];
            for (int i = 0; i < 10; i++)
            {
                pole[i] = i + 1;
            }
            foreach (int i in pole)
            {
                Console.Write("{0} ", i);
            }
            Console.ReadKey();


        }
    }
}
