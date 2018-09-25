using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit.Personnel_Classes.Navy
{
    class NavyOfficer : PersonnelBase
    {
        public NavyOfficer()
            : base() { }

        public override void CreatePersonnel()
        {
            Console.Write("Input your Sailors's first name: ");
            this.FirstName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Input your Sailors's last name: ");
            this.LastName = Console.ReadLine();
            Console.WriteLine();

            string[] rankArray = new string[11];
            for (int i = 1; i < 11; i++)
            {
                rankArray[i] = Enum.GetName(typeof(NavyOfficerRank), i);
            }

            Console.WriteLine();

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("#" + i + " - " + rankArray[i]);
            }

            Console.Write("\nInput your Sailor's rank #: ");

            int x = Program.GetInt();
            this.Rank = ((NavyOfficerRank)x).ToString();

            Console.WriteLine();

            Console.Write("Input your Sailor's date of birth (yyyy,mm,dd): ");

            this.DOB = DateTime.Parse(Console.ReadLine());
        }
    }
}
