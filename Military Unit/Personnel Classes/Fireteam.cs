using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Military_Unit;
using Military_Unit.Personnel_Classes.USMC;
using Military_Unit.Personnel_Classes.Navy;

namespace Military_Unit.Personnel_Classes
{
    class Fireteam
    {
        public PersonnelBase[] fireteamArray;

        // Initialize a fireteam with a NULL PersonnelBase array
        public Fireteam()
        {
            fireteamArray = new PersonnelBase[0];
        }

        public void AddPersonnel(PersonnelBase person)
        {
            Array.Resize(ref fireteamArray, fireteamArray.Length + 1);
            fireteamArray[fireteamArray.Length - 1] = person;
        }

        public void AddToFireteam()
        {
            Console.WriteLine("Input a number 1 - 5 to add a fireteam member:" +
                            "\n1 - USMC Enlisted" +
                            "\n2 - USMC Officer" +
                            "\n3 - Navy Enlisted" +
                            "\n4 - Navy Officer" +
                            "\n5 - Warrant Officer" +
                            "\n");

            int menuselection = Convert.ToInt32(Console.ReadLine());
            while (menuselection < (int)PersonnelTypes.USMCEnlisted || menuselection > (int)PersonnelTypes.WarrantOfficer)
            {
                menuselection = Convert.ToInt32(Console.ReadLine());
            }

            switch (menuselection)
            {
                case ((int)PersonnelTypes.USMCEnlisted):
                    // Create and add to fireteam a new USMC Enlisted Marine
                    AddPersonnel(new USMCEnlisted());
                    fireteamArray[fireteamArray.Length - 1].CreatePersonnel();

                    // Display full info of created person
                    Console.WriteLine();
                    Console.WriteLine("Here is your Marine's information: ");
                    Console.WriteLine(fireteamArray[fireteamArray.Length - 1].FullInfo());
                    break;

                case ((int)PersonnelTypes.USMCOfficer):
                    // Create and add to fireteam a new USMC Officer Marine
                    AddPersonnel(new USMCOfficer());
                    fireteamArray[fireteamArray.Length - 1].CreatePersonnel();

                    // Display full info of created person
                    Console.WriteLine();
                    Console.WriteLine("Here is your Marine's information: ");
                    Console.WriteLine(fireteamArray[fireteamArray.Length - 1].FullInfo());
                    break;

                case ((int)PersonnelTypes.NavyEnlisted):
                    // Create and add to fireteam a new Navy Enlisted Sailor
                    AddPersonnel(new NavyEnlisted());
                    fireteamArray[fireteamArray.Length - 1].CreatePersonnel();

                    // Display full info of created person
                    Console.WriteLine();
                    Console.WriteLine("Here is your Sailor's information: ");
                    Console.WriteLine(fireteamArray[fireteamArray.Length - 1].FullInfo());
                    break;

                case ((int)PersonnelTypes.NavyOfficer):
                    // Create and add to fireteam a new Navy Officer Sailor
                    AddPersonnel(new NavyOfficer());
                    fireteamArray[fireteamArray.Length - 1].CreatePersonnel();
                    // Display full info of created person
                    Console.WriteLine();
                    Console.WriteLine("Here is your Sailor's information: ");
                    Console.WriteLine(fireteamArray[fireteamArray.Length - 1].FullInfo());
                    break;

                case ((int)PersonnelTypes.WarrantOfficer):
                    // Create and add to fireteam a new Warrant Officer
                    AddPersonnel(new WarrantOfficer());
                    fireteamArray[fireteamArray.Length - 1].CreatePersonnel();
                    // Display full info of created person
                    Console.WriteLine();
                    Console.WriteLine("Here is your officer's information: ");
                    Console.WriteLine(fireteamArray[fireteamArray.Length - 1].FullInfo());
                    break;

                default:
                    break;
            }
        }

        public void FireteamAdvance()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (PersonnelBase item in fireteamArray)
            {
                Console.WriteLine(item.FullName() + "advances toward the objective.");
            }
            Console.ResetColor();
        }

        public void FireteamObjectiveSecured()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Your fireteam has secured the objective!");
            Console.ResetColor();
        }
    }
}