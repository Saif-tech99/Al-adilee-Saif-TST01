using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TST01_Vraag1
{
    class Program
    {
        static void Main(string[] args)
        {
            string l1 = new string('!', 33);
            string l2 = new string('-', 53);
            string l3 = new string('!', 33);
            double ammount;
            double ammountAfterDiscount;
            double ammountToDiscount1 = 5000;
            double ammountToDiscount2;
            bool start = true;
            int answer;
            int discount = 5;
            do
            {
                // note: it look fine so i made it like this
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{l1}{l2}{l3}");
                Console.WriteLine("Welkom bij de GOBLIN-app voor het berekenen van kortingen op rekeningen");
                do
                {
                    Console.WriteLine($"{l1}{l2}{l3}");
                    Console.Write("vul het bedrag van de factuur in : ");
                    ammount = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"{l1}{l2}{l3}");
                    Console.Clear();
                    if (ammount > 5000)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("gefeliciteerd je komt in aanmerking voor een korting van (5 %) wat een geweldige dag voor je");
                        ammountAfterDiscount = ammount - (ammount * discount / 100);
                        Console.WriteLine($"uw totaal na de korting is €{ammountAfterDiscount}");
                        Console.WriteLine($"{l1}{l2}{l3}");
                        Console.ReadLine();
                    }
                    else if (ammount < 5000)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{l1}{l2}{l3}");
                        ammountToDiscount2 = ammountToDiscount1 - ammount;
                        Console.WriteLine($"helaas heb je geen korting, maar maak je geen zorgen, we kunnen je helpen, het enige wat je hoeft te doen is wat meer te betalen : €{ammountToDiscount2} en de absolute korting van 5 % op je aankopen te krijgen");
                        Console.WriteLine($"{l1}{l2}{l3}");
                    }
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($"{l1}{l2}{l3}");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("wil je opnieuw opstarten of niet ");
                    Console.WriteLine("1 / 0");
                    Console.WriteLine($"{l1}{l2}{l3}");
                    Console.Write("your answer : ");
                    answer = Convert.ToInt32(Console.ReadLine().ToLower());
                    Console.ReadLine();
                    Console.Clear();
                    if (answer == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{l1}{l2}{l3}");
                        Console.WriteLine("wat een geweldige keuze, betaal nu meer geld");
                        start = true;
                    }
                    else if (answer == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{l1}{l2}{l3}");
                        Console.WriteLine("TE SLECHT OM U TE VERLATEN, AFSUIT");
                        start = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("tour answer is not correct");
                        Console.ResetColor();
                    }
                    Console.ReadLine();
                    Console.Clear();
                } while (start);
            } while (start);

        }
    }
}
