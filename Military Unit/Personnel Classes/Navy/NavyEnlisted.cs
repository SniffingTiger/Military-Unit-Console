using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit.Personnel_Classes.Navy
{
    class NavyEnlisted : PersonnelBase
    {
        public NavyEnlisted()
            : base() { }

        public override void CreatePersonnel()
        {
            // Input first name
            Console.Write("Input your Sailors's first name: ");
            this.FirstName = Console.ReadLine();
            Console.WriteLine();

            // Input last name
            Console.Write("Input your Sailors's last name: ");
            this.LastName = Console.ReadLine();
            Console.WriteLine();

            // Select rank
            string[] rankArray = new string[10];
            for (int i = 1; i < 10; i++)
            {
                rankArray[i] = Enum.GetName(typeof(NavyEnlistedRank), i);
            }

            Console.WriteLine();

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("#" + i + " - " + rankArray[i]);
            }

            Console.Write("\nInput your Marine's rank #: ");

            int x = Program.GetInt();
            this.Rank = ((NavyEnlistedRank)x).ToString();

            Console.WriteLine();

            // Input date of birth
            Console.Write("Input your Marine's date of birth (yyyy,mm,dd): ");

            this.DOB = DateTime.Parse(Console.ReadLine());
        }
    }
}