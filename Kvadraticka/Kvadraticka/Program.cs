using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kvadraticka
{
    class Program
    {
        static void Main(string[] args)
        {
            Kvadraticka kvadraticka = new Kvadraticka(-1, 6, 2);
            Console.WriteLine(kvadraticka.Resitelnost());
            kvadraticka.Vypocet();
            Console.ReadKey();
        }
    }
}
