using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vlastnosti
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Jan Tůma", true, 15);
            student.Vek = 25;
            student.Vek = 30;
            Console.WriteLine(student.ToString());
            Console.ReadKey();
        }
    }
}
