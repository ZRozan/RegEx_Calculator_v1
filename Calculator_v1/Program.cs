using System;
using System.Collections.Generic;
using System.Globalization;

namespace GeneralTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool aplicationRunning = true;

            do
            {
                Console.WriteLine("\t************************");
                Console.WriteLine("\t WELCOME TO THE PROGRAM");
                Console.WriteLine("\t************************");
                Console.WriteLine();

                Console.WriteLine
                (
                "What do you want to do?\n\n" +
                "\t[1] - Calculations.\n" +
                "\t[2] - Not implemented yet.\n" +
                "\t[3] - Also not implemented, but with option 3.\n\n" +
                "\t[0] - Close this thing, please."
                );

                int choice;
                bool aplicationChoice = Int32.TryParse(Console.ReadLine(), out choice);

                if (!aplicationChoice)
                {
                    Console.Clear();
                    Console.WriteLine("\n\tTsk, tsk.\nIf you want to close the aplication, be nice.\n");
                }
                else
                {
                    switch (choice)
                    {
                        case 0:
                            Console.Clear();
                            aplicationRunning = false;
                            break;
                        case 1:
                            Console.Clear();
                            Calculations.StartCalculator();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("\nWell, I said this was not implemented. But good try.\n");
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("\nBrah... I know you can not read this, because you have not read the description, but anyway:" +
                                "\n\tLearn to read.\n");
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("\nNice try, smartass. Now choose a valid option.\n");
                            break;
                    }
                }
            }
            while (aplicationRunning);

            Console.WriteLine("\n\t## Press Enter to exit.");
            Console.WriteLine();
        }

    }
}