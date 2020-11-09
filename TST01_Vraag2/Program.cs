using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TST01_Vraag2
{
    class Program
    {
        static Random ranpass = new Random();

        static void Main(string[] args)
        {
            string l = new string('°', 77);
            bool start = true;
            string answer;
            while (start)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Welkom bij de wachtwoordgenerator van iets, voor de test");
                do
                {
                    Console.WriteLine(l);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("druk op enter om een wachtwoord te genereren");
                    Console.ReadKey();
                    string pasword = Passowrd(5);
                    Console.WriteLine(pasword);
                    Console.ReadKey();
                    Console.WriteLine(l);
                    Console.WriteLine("wil je er nog een");
                    Console.WriteLine("Ja / Nee");
                    Console.Write(".... ");
                    answer = Console.ReadLine().ToLower();
                    if (answer == "nee")
                    {
                        Console.WriteLine("TE SLECHT OM U TE VERLATEN, AFSUIT");
                        start = false;
                    }
                    else if (answer == "ja")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        start = true;
                    }
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                } while (start);

            }

        }
        static string Passowrd(int lingth)
        {
            StringBuilder sb = new StringBuilder();
            string chara = ("azertyuiopmlkjhgfdsqwxcvbn1234567890NBVCXWMLKJHGFDSQAZERTYUIOP");
            for (int i = 0; i < lingth; i++)
            {
                int index = ranpass.Next(chara.Length);
                sb.Append(chara[index]);
            }
            return sb.ToString();
        }
    }
}
