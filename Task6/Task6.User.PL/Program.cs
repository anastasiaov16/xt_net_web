using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6_User.Entities;
using Task6_User.Ioc;

namespace Task6_User.PL
{
    class Program
    {
        static void Main()
        {
            int selection;
            do {
                Console.WriteLine("1. Add user");
                Console.WriteLine("2. Delete user");
                Console.WriteLine("3. Get all users");
                Console.WriteLine("4. Get user by Id");
                Console.WriteLine("5. Add award.");
                Console.WriteLine("6. Show award by ID.");
                Console.WriteLine("7. Show all awards.");
                Console.WriteLine("8. Add Award to User.");
                Console.WriteLine("9. Delete Award from User.");
                Console.WriteLine("0. Exit");
                if (int.TryParse(Console.ReadLine(), out selection))
                {
                    switch (selection)
                    {
                        case 1:
                            CreateUser();
                            break;
                        case 2:
                            DeleteUser();
                            break;
                        case 3:
                            GetAll();
                            break;
                        case 4:
                            GetUserById();
                            break;
                        case 5:
                            CreateAward();
                            break;
                        case 6:
                            GetAwardById();
                            break;
                        case 7:
                            GetAllAwards();
                            break;
                        case 8:
                            AddAwardToUser();
                            ShowUserAward();
                            break;
                        case 9:
                            DeleteAwardFromUser();
                            ShowUserAward();
                            break;
                    }
                }
            } while (selection != 0);
        }



        public static void ShowUser()
        {
            var userLogic = DependencyResolver.UserLogic;
            var lst = userLogic.GetAll();
            foreach (var item in lst)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void ShowAwards()
        {
            var awardLogic = DependencyResolver.AwLogic;
            var lst = awardLogic.GetAll();
            foreach (var item in lst)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void ShowUserAward()
        {
            var userLogic = DependencyResolver.UserLogic;
            var awardLogic = DependencyResolver.AwLogic;
            var lst = userLogic.GetAll();
            foreach (var item in lst)
            {
                Console.WriteLine(item.ToString());
                foreach (var item1 in item.Awards)
                {
                    Console.WriteLine(awardLogic.GetById(item1));
                }
                Console.WriteLine();
            }
        }

        public static void CreateUser()
        {
            var userLogic = DependencyResolver.UserLogic;
            User user;
            Console.WriteLine("Enter name");
            var name = Console.ReadLine();

            Console.Write("Enter a date (e.g. 1987,10,22): ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime birth))
                throw new ArgumentException("Enter correct value");
            user = new User(name, birth);
            userLogic.Add(user);
            ShowUser();
        }

        public static void DeleteUser()
        {
            ShowUser();
            var userLogic = DependencyResolver.UserLogic;
            int id = -1;
            Console.WriteLine("Enter Id of the user you want to delete");
            if (!int.TryParse(Console.ReadLine(), out id))
                throw new ArgumentException("Enter correct value");
            userLogic.Delete(id);
            Console.WriteLine("Deleted");
            ShowUser();
        }

        public static void GetAll()
        {
            var userLogic = DependencyResolver.UserLogic;
            var g = userLogic.GetAll();
            foreach (var i in g)
            {
                Console.WriteLine(i.ToString());
                Console.WriteLine();
            }
        }

        public static void GetUserById()
        {
            var userLogic = DependencyResolver.UserLogic;
            int id = -1;
            Console.WriteLine("Enter Id of the user you want to search");
            if (!int.TryParse(Console.ReadLine(), out id))
                throw new ArgumentException("Enter correct value");
            var uL = userLogic.GetById(id);
            Console.WriteLine(uL.ToString());
        }

        public static void CreateAward()
        {
            var awardLogic = DependencyResolver.AwLogic;
            Console.WriteLine("Enter the Title");
            var Title = Console.ReadLine();

            var awards = new Awards(Title);

            awardLogic.Add(awards);
            ShowAwards();
        }

        public static void GetAwardById()
        {
            var awardLogic = DependencyResolver.AwLogic;
            Console.WriteLine("Enter Id of the award you want to search");
            var idAw = -1;
            if (!int.TryParse(Console.ReadLine(), out idAw))
                throw new ArgumentException("Enter correct value");

            var m = awardLogic.GetById(idAw);
            Console.WriteLine(m.ToString());
        }

        public static void GetAllAwards()
        {
            var awardLogic = DependencyResolver.AwLogic;
            var n = awardLogic.GetAll();
            foreach (var i in n)
            {
                Console.Write(i.ToString());
                Console.WriteLine();
            }
        }

        public static void AddAwardToUser()
        {
            var userLogic = DependencyResolver.UserLogic;
            int id = -1;
            int idAwr = -1;
            Console.WriteLine("Which user do you want to add the award to? Select Id.");
            ShowUser();
            if (!int.TryParse(Console.ReadLine(), out id))
                throw new ArgumentException("Enter correct value");
            Console.WriteLine("What award do you want to add to  him/her? Select Id.");
            ShowAwards();
            if (!int.TryParse(Console.ReadLine(), out idAwr))
                throw new ArgumentException("Enter correct value");
            if (userLogic.AddAward(id, idAwr))
                Console.WriteLine("Completed");
        }

        public static void DeleteAwardFromUser()
        {
            var userLogic = DependencyResolver.UserLogic;
            int id = -1;
            int idAwr = -1;
            Console.WriteLine("Which user do you want to remove the award from? Select Id.");
            ShowUser();
            if (!int.TryParse(Console.ReadLine(), out id))
                throw new ArgumentException("Enter correct value");
            Console.WriteLine("What award do you want to add to  him/her? Select Id.");
            ShowUserAward();
            if (!int.TryParse(Console.ReadLine(), out idAwr))
                throw new ArgumentException("Enter correct value");
            if (userLogic.DeleteAward(id, idAwr))
                Console.WriteLine("Completed");
        }
    }
}
