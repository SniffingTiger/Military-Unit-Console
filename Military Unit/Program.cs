using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Military_Unit.Personnel_Classes;
using Military_Unit.Personnel_Classes.Navy;
using Military_Unit.Personnel_Classes.USMC;

namespace Military_Unit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here, you will create a fireteam, after which it will advance and secure the objective!");
            Console.WriteLine();

            // Create fireteam
            Fireteam Fireteam1 = new Fireteam();

            bool fireteamcreationdone = false;
            do
            {
                Fireteam1.AddToFireteam();

                Console.Write("\nWould you like to add another member to the fireteam?" +
                                "\n     Input 1 for Yes, 2 for No: ");

                int oneortwo = GetInt();

                while (oneortwo != 1 && oneortwo != 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\n     Input 1 for Yes, 2 for No:");
                    oneortwo = GetInt();
                    Console.WriteLine();
                }

                if (oneortwo == 2)
                {
                    fireteamcreationdone = true;
                }
            } while (fireteamcreationdone == false);

            Console.WriteLine();

            // Fireteam advances
            Fireteam1.FireteamAdvance();
            Console.WriteLine();

            // Fireteam secures objective
            Fireteam1.FireteamObjectiveSecured();
            Console.ReadLine();
        }

        public static int GetInt()
        {
            try
            {
                int inputInt = Convert.ToInt32(Console.ReadLine());
                return inputInt;
            }
            catch (FormatException fEx)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("\nYour input must be a number! Try again: ");
                Console.ResetColor();
                return GetInt();
            }
        }
    }
}