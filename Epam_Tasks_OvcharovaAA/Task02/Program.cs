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

                            catch (Exception e)
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

                            catch (Exception e)
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

                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }

                            user.Show();
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
