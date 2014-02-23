using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatumACas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime();
            Console.WriteLine(d);

            DateTime da = new DateTime(2013, 05, 17);
            Console.WriteLine(da);

            DateTime dat = new DateTime(2013, 05, 17, 16, 29, 58);
            Console.WriteLine(dat);

            DateTime datu = DateTime.Now;
            Console.WriteLine("Dnes je: {0}", datu);

            DateTime datum = DateTime.Today;
            Console.WriteLine("Dnes je: {0}", datum);

            DateTime datumm = DateTime.Now;
            Console.WriteLine("Dnes je {0}, {1}", datumm.DayOfWeek, datumm.Day);
            Console.WriteLine("Je  {0}. měsíc a rok {1}",datumm.Month,datumm.Year);
            Console.WriteLine("{0} hodin, {1} minut, {2} sekund",datumm.Hour,datumm.Minute,datumm.Second);
            /*
            DateTime datummm;
            DateTime.TryParse(Console.ReadLine(), out datummm);
            Console.WriteLine(datummm.ToString("dd.MM.yyyy"));

            DateTime datummmm = DateTime.ParseExact(Console.ReadLine(), "dd.M.yyyy", null);
            Console.WriteLine(datummmm.ToString("dd.M.yyyy"));
            */
            TimeSpan dd = new TimeSpan(13, 23, 21);

            Console.WriteLine("Zadej datum narození: ");
            DateTime narozen = DateTime.Parse(Console.ReadLine());
            TimeSpan vek = DateTime.Today - narozen;
            Console.WriteLine("Je ti {0} let.", Math.Floor(vek.Days/365.255));
            Console.WriteLine("To je ve dnech {0} a v hodinách {1}.", vek.TotalDays, vek.TotalHours);
            Console.ReadKey();
        }
    }
}
