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

        // Initialize a fireteam with an empty PersonnelBase array
        public Fireteam()
        {
            fireteamArray = new PersonnelBase[0];
        }

        // Adds one more item to fireteamArray, and passes the selected person type into the last array index
        public void AddPersonnel(PersonnelBase person)
        {
            Array.Resize(ref fireteamArray, fireteamArray.Length + 1);
            fireteamArray[fireteamArray.Length - 1] = person;
        }

        // Adds a person to a fireteam
        public void AddToFireteam()
        {
            Console.WriteLine("Input a number 1 - 5 to add a fireteam member:" +
                            "\n1 - USMC Enlisted" +
                            "\n2 - USMC Officer" +
                            "\n3 - Navy Enlisted" +
                            "\n4 - Navy Officer" +
                            "\n5 - Warrant Officer" +
                            "\n");

            int menuselection = Program.GetInt();
            while (menuselection < (int)PersonnelTypes.USMCEnlisted || menuselection > (int)PersonnelTypes.WarrantOfficer)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Input a menu item between 1 and 5!");
                Console.ResetColor();
                menuselection = Program.GetInt();
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

        // Prints a message that shows the fireteam advancing toward objective
        public void FireteamAdvance()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (PersonnelBase item in fireteamArray)
            {
                Console.WriteLine(item.Rank + " " + item.LastName + " advances toward the objective.");
            }
            Console.ResetColor();
        }

        // Prints a message that shows the fireteam securing the objective
        public void FireteamObjectiveSecured()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Your fireteam has secured the objective!");
            Console.ResetColor();
        }
    }
}