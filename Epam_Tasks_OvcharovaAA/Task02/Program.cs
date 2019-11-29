using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main()
        {
            double selection;
            do
            {
                Console.WriteLine("2.1 Round.");
                Console.WriteLine("2.2 Triangle.");
                Console.WriteLine("2.3 User.");
                Console.WriteLine("2.4 MyString.");
                Console.WriteLine("2.5 Employee.");
                Console.WriteLine("2.6 Ring.");
                if (double.TryParse(Console.ReadLine(), out selection))
                {
                    switch (selection)
                    {
                        case 1:
                            Console.WriteLine("Task 1");
                            Console.WriteLine("This app create round.");
                            Round round = new Round();

                            try
                            {
                                round = Round.ReadRound();
                            }

                            catch (ArgumentException e)
                            {
                                Console.WriteLine(e.Message);
                            }

                            round.Show();
                            Console.WriteLine();
                            break;
                        case 2:
                            Console.WriteLine("Task 2");
                            Console.WriteLine("This app create triangle.");
                            Triangle triangle = new Triangle();

                            try
                            {
                                triangle = Triangle.ReadTriangle();
                            }

                            catch (ArgumentException e)
                            {
                                Console.WriteLine(e.Message);
                            }

                            triangle.Show();
                            Console.WriteLine();
                            break;
                        case 3:
                            Console.WriteLine("Task 3");
                            Console.WriteLine("This app create user.");
                            User user = new User();

                            try
                            {
                                user = User.ReadUser();
                            }

                            catch (ArgumentException e)
                            {
                                Console.WriteLine(e.Message);
                            }

                            user.Show();
                            Console.WriteLine();
                            break;
                        case 4:
                            Console.WriteLine("Task 4");
                            Console.WriteLine("This app create MyString.");

                            Console.WriteLine("Enter two strings:");
                            var test1 = Console.ReadLine();
                            var test2 = Console.ReadLine();

                            MyString str1 = new MyString(test1);
                            MyString str2 = new MyString(test2.ToCharArray());

                            Console.WriteLine("{0} + {1} = {2}", str1.ToString(), str2.ToString(), MyString.Concat(str1, str2).ToString());

                            Console.WriteLine((str1 == str2)? "Equal": "Not equal");

                            Console.WriteLine("Enter the letter you want to find in the str1:");
                            char let = Char.Parse(Console.ReadLine());
                            Console.WriteLine("Index s : {0}", str1?.IndexOf(let));

                            Console.WriteLine("Enter the the word to be converted to MyString:");
                            string word = Console.ReadLine();
                            Console.WriteLine((MyString)word);
                            Console.WriteLine("ToUpper: {0}", ((MyString)word).Upper());
                            Console.WriteLine("ToLower: {0}", ((MyString)word).Lower());

                            Console.WriteLine();
                            break;
                        case 5:
                            Console.WriteLine("Task 5");
                            Console.WriteLine("This app create employee.");
                            Employee employee = new Employee();

                            try
                            {
                                employee = Employee.ReadEmployee();
                            }

                            catch (ArgumentException e)
                            {
                                Console.WriteLine(e.Message);
                            }

                            employee.Show();
                            Console.WriteLine();
                            break;
                        case 6:
                            Console.WriteLine("Task 6");
                            Console.WriteLine("This app create ring.");
                            Ring ring = new Ring();

                            try
                            {
                                ring = Ring.ReadRing();
                            }

                            catch (ArgumentException e)
                            {
                                Console.WriteLine(e.Message);
                            }

                            ring.Show();
                            Console.WriteLine();
                            break;
                        case 0:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid value entered!");
                }
            } while (selection != 0);
        }


    }
}
