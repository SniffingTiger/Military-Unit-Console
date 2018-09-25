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
                                "\n     Input 1 for Yes, 2 for No:");

                Console.WriteLine();
                int oneortwo = Convert.ToInt32(Console.ReadLine());
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
    }
}