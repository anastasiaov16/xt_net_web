using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Task02.POLYMORPHISM;

namespace Task02
{
    class Program
    {
        static void Main()
        {
            double selection;
            do
            {
                Console.WriteLine("2,1 Round.");
                Console.WriteLine("2,2 Triangle.");
                Console.WriteLine("2,3 User.");
                Console.WriteLine("2,4 MyString.");
                Console.WriteLine("2,5 Employee.");
                Console.WriteLine("2,6 Ring.");
                Console.WriteLine("2,7 Vector graphics editor.");
                Console.WriteLine("2,8 Game.");
                Console.WriteLine();
                if (double.TryParse(Console.ReadLine(), out selection))
                {
                    switch (selection)
                    {
                        case 2.1:
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
                        case 2.2:
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
                        case 2.3:
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
                        case 2.4:
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
                        case 2.5:
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
                        case 2.6:
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
                        case 2.7:
                            Console.WriteLine("Task 7");
                            Console.WriteLine("This app is vector graphics creator.");
                            double cs;
                            do
                            {
                                Console.WriteLine("1 Line.");
                                Console.WriteLine("2 Rectangle.");
                                Console.WriteLine("3 Circle.");
                                Console.WriteLine("4 Round.");
                                Console.WriteLine("5 Ring.");
                                Console.WriteLine("0 Exit.");
                                Console.WriteLine();
                                if (double.TryParse(Console.ReadLine(), out cs))
                                {
                                    switch (cs)
                                    {
                                        case 1:
                                            Line line = null;
                                            try
                                            {
                                                line = Line.ReadLines();
                                            }
                                            catch (Exception e)
                                            {
                                                Console.WriteLine(e.Message);
                                            }
                                            line?.Show();
                                            Console.WriteLine();
                                            break;
                                        case 2:
                                            Rectangle rec = null;
                                            try
                                            {
                                                rec = Rectangle.ReadRectangle();
                                            }
                                            catch (Exception e)
                                            {
                                                Console.WriteLine(e.Message);
                                            }
                                            rec?.Show();
                                            Console.WriteLine();
                                            break;
                                        case 3:
                                            Circle cr = null;
                                            try
                                            {
                                                cr = Circle.ReadCircle();
                                            }
                                            catch (Exception e)
                                            {
                                                Console.WriteLine(e.Message);
                                            }
                                            cr?.Show();
                                            Console.WriteLine();
                                            break;
                                        case 4:
                                            PRound rnd = null;
                                            try
                                            {
                                                rnd = PRound.ReadRound();
                                            }
                                            catch (Exception e)
                                            {
                                                Console.WriteLine(e.Message);
                                            }
                                            rnd?.Show();
                                            Console.WriteLine();
                                            break;
                                        case 5:
                                            PRing rng = null;
                                            try
                                            {
                                                rng = PRing.ReadRing();
                                            }
                                            catch (Exception e)
                                            {
                                                Console.WriteLine(e.Message);
                                            }
                                            rng?.Show();
                                            Console.WriteLine();
                                            break;
                                        case 0:
                                            break;
                                    }
                                }
                            } while (cs != 0);
                            Console.WriteLine();
                            break;
                        case 2.8:
                            Console.WriteLine("Task 8.");
                            Console.WriteLine("This app create game.");
                            Game game = new Game();
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
