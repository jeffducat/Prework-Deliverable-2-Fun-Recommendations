using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunRecommendations2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!  Welcome to the Fun Recommendations Guide! ");
            Console.WriteLine("Today you will enter a couple of selections and my program will recommend what you should do to have a good time today. ");

            bool run = true;
            while (run)
            {
                run = false;
                Console.WriteLine("Please select one of these choices(0,1,2,3, or 4) for the type of activity you'd enjoy:  ");
                Console.WriteLine(" (0) Action \n (1) Chilling \n (2) Danger \n (3) Good Food \n (4) To exit the program ");

                char selection = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");

                switch (selection)
                {
                    case '0':
                        Console.WriteLine("You should go Stock Car Racing");
                        break;
                    case '1':
                        Console.WriteLine("You should go Hiking");
                        break;
                    case '2':
                        Console.WriteLine("You should go Sky Diving");
                        break;
                    case '3':
                        Console.WriteLine("You should go to Taco Bell");
                        break;
                    case '4':
                        Console.WriteLine("Have a great time!  Goodbye!\n");
                        Console.WriteLine("Press any key to exit...");
                        Console.ReadKey();
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Entry:  Please enter one of the following for your selection: 0,1,2,3, or 4");
                        run = true;
                        break;
                }
            }

            Console.WriteLine("\n");

            run = true;
            while (run)
            {
                run = false;
                Console.WriteLine("Please select one of these choices(0,1,2,3, or 4) for the number of people you are bringing with you today:  ");
                Console.WriteLine(" (0) 0 \n (1) 1-4 \n (2) 5-10 \n (3) 11 or more \n (4) To exit the program ");

                char groupSize = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");

                switch (groupSize)
                {
                    case '0':
                        Console.WriteLine("You should travel in sneakers");
                        break;
                    case '1':
                        Console.WriteLine("You should travel in a sedan");
                        break;
                    case '2':
                        Console.WriteLine("You should travel in a Volkswagen Bus");
                        break;
                    case '3':
                        Console.WriteLine("You should travel in an airplane");
                        break;
                    case '4':
                        Console.WriteLine("Have a great time!  Goodbye!\n");
                        Console.WriteLine("Press any key to exit...");
                        Console.ReadKey();
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Entry:  Please enter one of the following for your selection: 0,1,2,3, or 4");
                        run = true;
                        break;
                }
            }

            Console.WriteLine("\nHave a great time!  Goodbye!\n");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
