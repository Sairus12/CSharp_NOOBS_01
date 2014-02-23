using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Priklady
{
    class Auto
    {
        protected string spz;
        protected string barva;

        public Auto(string spz, string barva)
        {
            this.spz = spz;
            this.barva = barva;
        }
        public string VratSpz()
        {
            return spz;
        }
        
    }
}
