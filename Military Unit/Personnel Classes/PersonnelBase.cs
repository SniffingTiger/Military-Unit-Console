using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    class PersonnelBase
    {
        public string FirstName { get; set; }
        public char? MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string Rank { get; set; }
        public DateTime DOB { get; set; }

        // The strind dob must be formatted as "1999,04,20"
        public PersonnelBase()
        {
            FirstName = "";
            MiddleInitial = null;
            LastName = "";
            Rank = "";
            DOB = DateTime.Parse("2999,01,01");
        }

        public int AgeOfPersonnel()
        {
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(DOB.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;
            return age;
        }

        public virtual void CreatePersonnel()
        {
            Console.Write("Input first name: ");
            this.FirstName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Input last name: ");
            this.LastName = Console.ReadLine();
            Console.WriteLine();
            
            this.Rank = null;

            Console.WriteLine();

            Console.Write("Input date of birth (yyyy,mm,dd): ");

            this.DOB = DateTime.Parse(Console.ReadLine());
        }

        public string FullName()
        {
            string fullname;
            fullname = FirstName + " " + MiddleInitial + " " + LastName;
            return fullname;
        }

        public string FullInfo()
        {
            if (MiddleInitial is null)
            {
                string fullinfo = "Full name: " + FirstName + " " + LastName +
                "\nRank: " + Rank +
                "\nAge: " + AgeOfPersonnel() +
                "\nDOB: " + DOB.ToShortDateString();
                return fullinfo;
            }
            else
            {
                string fullinfo = "Full name: " + FirstName + " " + MiddleInitial + " " + LastName +
                                "\nRank: " + Rank +
                                "\nAge: " + AgeOfPersonnel() +
                                "\nDOB: " + DOB.ToShortDateString();
                return fullinfo;
            }
        }
    }
}
