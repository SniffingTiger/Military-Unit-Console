using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit.Personnel_Classes.USMC
{
    class USMCOfficer : PersonnelBase
    {
        public USMCOfficer()
            : base() { }

        public override void CreatePersonnel()
        {
            // Input first name
            Console.Write("Input your Marine's first name: ");
            this.FirstName = Console.ReadLine();
            Console.WriteLine();

            // Input last name
            Console.Write("Input your Marine's last name: ");
            this.LastName = Console.ReadLine();
            Console.WriteLine();

            // Select rank
            string[] rankArray = new string[10];
            for (int i = 1; i < 10; i++)
            {
                rankArray[i] = Enum.GetName(typeof(USMCOfficerRank), i);
            }

            Console.WriteLine();

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("#" + i + " - " + rankArray[i]);
            }

            Console.Write("\nInput your Marine's rank #: ");

            int x = Program.GetInt();
            while (x < (int)USMCOfficerRank.SecondLieutenant || x > (int)USMCOfficerRank.General)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Input a rank # between 1 and 10!");
                Console.ResetColor();
                x = Program.GetInt();
            }
            this.Rank = ((USMCOfficerRank)x).ToString();

            Console.WriteLine();

            // Input date of birth
            Console.Write("Input your Marine's date of birth. Follow this format, including commas: 'yyyy,mm,dd': ");

            this.DOB = DateTime.Parse(Console.ReadLine());
        }

    }
}