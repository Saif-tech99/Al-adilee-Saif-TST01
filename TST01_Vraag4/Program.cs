using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TST01_Vraag4
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            char[,] x = new char[10, 10];
            int eegx = 0;
            int eegy = 0;
            var eegIX = -1;
            var eegIY = -1;
            var end = false;
            var chances = 6;
            var guess = 0;
            var chancesLimet = 6;
            var sta = true;
            do
            {
                sta = true;
                end = false;
                eegx = rand.Next(0, 10);
                eegy = rand.Next(0, 10);
                Console.WriteLine("wilcome to find the eeg game you have there chancec to win");
                for (int i = 0; i < x.GetLength(0); i++)
                {
                    Console.WriteLine();
                    for (int e = 0; e < x.GetLength(1); e++)
                    {
                        x[i, e] = '-';
                    }
                }
                
                do
                {
                    Compare(eegIX, eegx, 'x');
                    Compare(eegIY, eegy, 'y');
                    Console.WriteLine($"{eegx},{eegy}");

                    for (int i = 0; i < x.GetLength(0); i++)
                    {
                        for (int e = 0; e < x.GetLength(1); e++)
                        {
                            Console.Write($"{x[e, i]}\t");
                            guess++;
                            
                        }
                        Console.WriteLine();
                        
                    }
                    Console.WriteLine($" you have {chancesLimet} your have left : {chances--}");
                    Console.WriteLine("enter the your gess for the line x ");
                    Console.Write("x = ");
                    eegIX = int.Parse(Console.ReadLine());
                    Console.WriteLine("now enter your gees for the line y ");
                    Console.Write("y = ");
                    eegIY = int.Parse(Console.ReadLine());
                    x[eegIX, eegIY] = 'x';
                    Console.Clear();
                    ;
                    if (eegIX == eegx && eegIY == eegy)
                    {
                        Console.WriteLine("gongragultions you have fund the eeg now you my eet it ");
                        sta = false;
                    }
                    if (chances == 0)
                    {
                        Console.WriteLine("your have no more chances");
                        sta = false;
                    }
                } while (sta == true);
            } while (end == true);
        }
        //i have not worked on the compare method i used the one that belongs to Timothy, however, i did not just copy and past it, i did understand its logic
        static void Compare(int input, int pos, char orientation)
        {
            if (input != -1)
            {
                if (orientation == 'x')
                {
                    if (input > pos)
                    {
                        Console.WriteLine("Het ei ligt meer in het westen.");
                    }
                    else if (input < pos)
                    {
                        Console.WriteLine("Het ei ligt meer in het oosten.");
                    }
                }
                else if (orientation == 'y')
                {
                    if (input > pos)
                    {
                        Console.WriteLine("Het ei ligt meer in het noorden.");
                    }
                    else if (input < pos)
                    {
                        Console.WriteLine("Het ei ligt meer in het zuiden.");
                    }
                }
            }

        }
    }
}
