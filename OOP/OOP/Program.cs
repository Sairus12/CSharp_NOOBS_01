using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Zdravic zdravic = new Zdravic();
            zdravic.text = "Ahoj Uživateli ";
            zdravic.Pozdrav("Honza");
            zdravic.Pozdrav("Nikča");
            zdravic.text = "Vítej programátore ";
            zdravic.Pozdrav("TUNE servis");
            Console.ReadKey();
            zdravic.text = "Ahoj uživateli ";
            Console.WriteLine(zdravic.Pozdravv("Hanys"));
            Console.WriteLine(zdravic.Pozdravv("Nikča"));
            zdravic.text = "Vítám tě automechaniku společnosti ";
            Console.WriteLine(zdravic.Pozdravv("TUNE servis"));
            Console.ReadKey();
            */
            Kalk kalk = new Kalk();
            Console.WriteLine("Vítej v kalkulačce.");
            Console.WriteLine("===========================================");
            bool pokracovat = true;
            while (pokracovat)
            {
                Console.WriteLine("\nZadej prvni číslo: ");
                int a,b;
                while (!int.TryParse(Console.ReadLine(), out a))
                    Console.WriteLine("Nezadal jsi číslo, zadej znova: ");
                Console.WriteLine("Zadej druhé číslo: ");
                while (!int.TryParse(Console.ReadLine(), out b))
                    Console.WriteLine("Nezadal jsi číslo, zadej znova: ");

                Console.Write("Vyber si jednu z operací: \n\t1. Sčítání\n\t2. Odčítání\n\t3. Násobení\n\t4. Dělení\n\t5.Druhá mocnina\n\t6.Druhá odmocnina\n");
                while (pokracovat)
                {
                    switch (Console.ReadKey().KeyChar)
                    {
                        case '1':
                            {
                                Console.WriteLine("\nVýsledek sčítání je: {0}",kalk.soucet(a, b));
                                break;
                            }
                        case '2':
                            {
                                Console.WriteLine("\nVýsledek odčítání je: {0}", kalk.rozdil(a, b));
                                break;
                            }
                        case '3':
                            {
                                Console.WriteLine("\nVýsledek násobení je: {0}", kalk.soucin(a, b));
                                break;
                            }
                        case '4':
                            {
                                Console.WriteLine("\nVýsledek dělení je: {0}",kalk.podil((double)a, (double)b));
                                break;
                            }
                        case '5':
                            {
                                Console.WriteLine(kalk.nadruhou(a, b));
                                break;
                            }
                        case '6':
                            {
                                Console.WriteLine(kalk.druhaodmocnina(a, b));
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("\nZadal si špatnou volbu, zadej znova: ");
                                break;
                            }
                    }
                    pokracovat = false;
                }



                Console.WriteLine("\nChceš počítat znovu? [a/n]");
                bool pokr = true;
                while (pokr)
                {
                    switch (Console.ReadKey().KeyChar.ToString().ToLower())
                    {
                        case "a":
                            {
                                pokracovat = true;
                                pokr = false;
                                break;
                            }
                        case "n":
                            {
                                pokracovat = false;
                                pokr = false;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("\nZadali jste šptaně. Chcete opakovat? [a/n]\n");
                                break;
                            }
                    }
                }



            }
            Console.WriteLine("\n\n\nDěkujeme za použití kalkulačky, naschledanou.\n\nAplikaci vypnete stisknutím libovolné klávesy.");


            /************** znaky ************
 
            string zn;
            zn = Console.ReadLine();
            Console.WriteLine("{0}",test.znaky(zn[0]));
             */

            /************** sude ************
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}",test.sude(x));
             */

            /************** interval *********
            int d = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}",test.interval(d,h,n));
             */

            Console.ReadKey();
        }
    }
}
