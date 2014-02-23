using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Priklady
{
    class GeneratorVet
    {
        
        public string VygenerujVetu(Random rand)
        {
            
            string s = "";
            string[] podstatna = {"kůň","pes","Vojta","Šustek","Dan","Vávra"};
            string[] pridavna = {"bílý","zábavný","automatizovaný","zhulený","sklízící","hulící","jezdící"};
            string[] prislovce = {"rychle","uhoněně","zbrkle","s oblibou","podstivě"};
            string[] slovesa = {"sklízel","honil","jezdil","psal","uklízel","zařizoval","štěkal"};
            string[] prislovceMista = {"v lese","na poli","ve škole","doma","u paní mámy"};
            s += pridavna[rand.Next(pridavna.Length)] + " " + podstatna[rand.Next(podstatna.Length)] + " " + prislovce[rand.Next(prislovce.Length)] + " " + slovesa[rand.Next(slovesa.Length)] + " " + prislovceMista[rand.Next(prislovceMista.Length)];
            return (s);
        }
    }
}
