using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Priklady
{
    class Kalkulacka
    {
        public float scitani(float a, float b)
        {
            return (a + b);
        }
        public float odcitani(float a, float b, int volba)
        {
            switch(volba)  {
                case 1:  return (a-b);
                case 2:  return (b-a);
                default: return(0);
            } 
        }
        public float nasobeni(float a, float b)
        {
            return (a * b);
        }
        public float deleni(float a, float b, int volba)
        {
            switch (volba)
            {
                case 1: return (a / b);
                case 2: return (b / a);
                default: return 0;
            }
        }
    }
}
