using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6_User.BLL;
using Task6_User.BLL.Interface;
using Task6_User.DAL;
using Task6_User.DAL.Interface;

namespace Task6_User.Ioc
{
    public static class DependencyResolver
    {
        private static IUserDao userDao;

        public static IUserDao UserDao => userDao ?? (userDao = new UserDao());

        private static IUserLogic userLogic;

        public static IUserLogic UserLogic => userLogic ?? (userLogic = new UserLogic(UserDao));

        private static IAwardsDao awardsDao;

        public static IAwardsDao AwDao => awardsDao ?? (awardsDao = new AwardsDao());

        private static IAwardsLogic awLogic;

        public static IAwardsLogic AwLogic => awLogic ?? (awLogic = new AwardsLogic(AwDao));
    }
}

