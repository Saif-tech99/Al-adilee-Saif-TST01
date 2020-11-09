using System;

namespace TST01_Vraag3
{
    class Program
    {
       

        static void Main(string[] args)
        {
            string[] stadName = new string[] { "Antwerpen", "Brussel", "Dendermonde", "Gent", "Kortrijk", "Oudenaarde", "Turnhout" };
            int[] PostCode = new int[] { 2000, 1000, 9200, 9000, 8500, 9700, 2300 };
            string x = new string('§', 77);
            int input;
            int index;
           string indexS;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(x);
                Console.WriteLine("welcome bij de stad zoeken app");
                Console.WriteLine("kies een manier van zoeken : \n\t1-met Post Code. \n\t2-met de Stad Name. \n\t3-exit");
                input = int.Parse(Console.ReadLine());


                switch (input)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(x);
                        Console.WriteLine("Geef de postcode in");
                        Console.Write(".... ");
                        index = Convert.ToInt32(Console.ReadLine());
                        index = Array.IndexOf(PostCode, index);
                        Console.WriteLine($"De stad van die postcode is: {stadName[index]}");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(x);
                        Console.WriteLine("Geef de stadNam in");
                        Console.Write(".... ");
                        indexS = Console.ReadLine();
                        if (indexS == stadName[0])
                        {
                            Console.WriteLine($"De stad van die postcode is: {PostCode[0]}");
                        }
                        else if (indexS == stadName[1])
                        {
                            Console.WriteLine($"De stad van die postcode is: {PostCode[1]}");
                        }
                        else if (indexS == stadName[2])
                        {
                            Console.WriteLine($"De stad van die postcode is: {PostCode[2]}");
                        }
                        else if (indexS == stadName[3])
                        {
                            Console.WriteLine($"De stad van die postcode is: {PostCode[3]}");
                        }
                        else if (indexS == stadName[4])
                        {
                            Console.WriteLine($"De stad van die postcode is: {PostCode[4]}");
                        }
                        else if (indexS == stadName[5])
                        {
                            Console.WriteLine($"De stad van die postcode is: {PostCode[5]}");
                        }
                        else if (indexS == stadName[6])
                        {
                            Console.WriteLine($"De stad van die postcode is: {PostCode[6]}");
                        }
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(x);
                        Console.WriteLine("see you next time");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("uw invoer komt niet overeen met de tabel, probeer het opnieuw");
                        break;
                }

            } while (input != 3);




        }
    }
}
