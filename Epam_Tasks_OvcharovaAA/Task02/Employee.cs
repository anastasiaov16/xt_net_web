using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Employee : User
    {
        private int work_experience;
        public string Position { get; set; }

        public Employee()
        {
        }

        public Employee(string LastName, string FirstName, string SecondName, DateTime DateOfBirth, int workExp, string pos) : base(LastName, FirstName, SecondName, DateOfBirth)
        {
            Work = workExp;
            Position = pos;
        }

        public int Work
        {
            get
            {
                return work_experience;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The work_experience can't be less that zero");
                }
                work_experience = value;
            }
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Work Experience = {Work}, Position = {Position}");
        }

        public static Employee ReadEmployee()
        {
            Employee employee;
            do
            {
                Console.WriteLine("Enter lastName.");
                string lastName = Console.ReadLine();
                if (IsWord(lastName))
                {
                    Console.WriteLine("Enter firstName name.");
                    string firstName = Console.ReadLine();
                    if (IsWord(firstName))
                    {
                        Console.WriteLine("Enter secondName.");
                        string secondName = Console.ReadLine();
                        if (IsWord(secondName))
                        {
                            Console.WriteLine("Enter date of birth: yyyy mm dd.");
                            if (DateTime.TryParse(Console.ReadLine(), out DateTime birth))
                            { 
                                Console.WriteLine("Enter work experience.");
                                if (int.TryParse(Console.ReadLine(), out int work))
                                {
                                    Console.WriteLine("Enter position.");
                                    string position = Console.ReadLine();
                                    if (IsWord(position))
                                    {
                                        employee = new Employee(lastName, firstName, secondName, birth, work, position);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            } while (true);

            return employee;
        }

    }
}
