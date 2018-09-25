using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit.Personnel_Classes.USMC
{
    class USMCEnlisted : PersonnelBase
    {
        public USMCEnlisted()
                    : base() { }

        public override void CreatePersonnel()
        {
            Console.Write("Input your Marine's first name: ");
            this.FirstName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Input your Marine's last name: ");
            this.LastName = Console.ReadLine();
            Console.WriteLine();

            string[] rankArray = new string[12];
            for (int i = 1; i < 12; i++)
            {
                rankArray[i] = Enum.GetName(typeof(USMCEnlistedRank), i);
            }

            Console.WriteLine();

            for (int i = 1; i < 12; i++)
            {
                Console.WriteLine("#" + i + " - " + rankArray[i]);
            }

            Console.Write("\nInput your Marine's rank #: ");

            int x = Convert.ToInt32(Console.ReadLine());
            this.Rank = ((USMCEnlistedRank)x).ToString();

            Console.WriteLine();

            Console.Write("Input your Marine's date of birth (yyyy,mm,dd): ");

            this.DOB = DateTime.Parse(Console.ReadLine());
        }
    }
}