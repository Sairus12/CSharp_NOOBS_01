using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statika
{
    static class Nastaveni
    {
        private static string jazyk = "CZ";
        private static string barevneSchema = "modré";
        private static bool spustitPoStartu = true;

        public static string Jazyk()
        {
            return jazyk;
        }
        public static string BarevneSchema()
        {
            return barevneSchema;
        }
        public static bool SpustitPoStartu()
        {
            return spustitPoStartu;
        }
    }
}
