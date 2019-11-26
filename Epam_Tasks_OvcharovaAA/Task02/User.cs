using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02_User
{
    public class User
    {
        private string lastName;
        private string firstName;
        private string secondName;

        public User()
        {
        }

        public User(string lastName, string firstName, string secondName, DateTime dateOfBirth)
        {
            LastName = lastName;
            FirstName = firstName;
            SecondName = secondName;
            DateOfBirth = dateOfBirth;
        }


        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value.Length < 2 || value.Length > 40)
                {
                    throw new ArgumentException("Write correct LastName");
                }
                else
                {
                    lastName = value;
                }

            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value.Length < 2 || value.Length > 20)
                {
                    throw new ArgumentException("Write correct FirstName");
                }
                else
                {
                    firstName = value;
                }

            }
        }

        public string SecondName
        {
            get
            {
                return secondName;
            }
            set
            {
                if (value.Length < 2 || value.Length > 20)
                {
                    throw new ArgumentException("Write correct SecondName");
                }
                else
                {
                    secondName = value;
                }

            }
        }

        public DateTime DateOfBirth { get; set; }

        public int Age => (DateTime.Now.Year - DateOfBirth.Year - (((DateOfBirth.Month > DateTime.Now.Month) || (DateOfBirth.Month == DateTime.Now.Month && DateOfBirth.Day > DateTime.Now.Day))? 1 : 0));

        public static bool IsWord(string str)
        {
            char[] word = str.ToCharArray();

            for (var i = 0; i < word.Length; i++)
            {
                if (!Char.IsLetter(word[i]))
                {
                    return false;
                }

            }
            return true;
        }

        public void Show() => Console.WriteLine($"LastName = {LastName}, FirstName = {FirstName}, SecondNAme = {SecondName}, DateOfBirth = {DateOfBirth}, Age = {Age}.");



        public static User ReadUser()
        {
            User user;
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
                                user = new User(lastName, firstName, secondName, birth);
                                break;
                            }
                        }
                    }
                }
            } while (true);

            return user;
        }
    }
}
