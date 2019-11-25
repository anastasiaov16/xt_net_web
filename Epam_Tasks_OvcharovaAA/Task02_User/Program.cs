
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02_User
{
    public class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
