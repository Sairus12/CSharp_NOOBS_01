using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZooSystemUzivatelu
{
    class Vypisy
    {
        public Databaze databaze;
        public Vypisy()
        {
            databaze = new Databaze();
        }
        public string Plnoletost(Uzivatel u)
        {
            if ((u.Vek >= 18) && (u.Vek <= 120))
                return String.Format("Uživatel {0} je plnoletý.", u);
            else if (u.Vek < 0)
                return String.Format("Uživatel {0} se narodí za {1} let.", u, u.Vek * (-1));
            else if (u.Vek == 0)
                return String.Format("Uživatel {0} se právě narodil.", u);
            else if ((u.Vek >= 1) && (u.Vek <= 17))
                return String.Format("Uživatel {0} je mladistvý.", u);
            else if (u.Vek >= 120)
                return String.Format("Uživatel {0} je pravděpodobně zombie.", u);
            else
                return String.Format("Nevím kdo to je, ale rozhodně to není uživatel.");
        }
        public void VypisUvodniObrazovku(object obj)
        {
            Console.Clear();
            Console.WriteLine("Vítejte v informačním sytému ZOOmat.");
            Console.WriteLine("Dnes je: {0}", DateTime.Now);
            Prava(obj);
            
        }
        public void Prava(object obj)
        {
            if (obj.GetType() == typeof(Uzivatel))
                Console.WriteLine("Jste přihlášen jako obyčejný uživatel.");
            else if (obj.GetType() == typeof(Admin))
                Console.WriteLine("Jste přihlášen jako admin {0}. stupně.", (obj as Admin).Stupen);
        }
    }
}
