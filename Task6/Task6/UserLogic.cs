using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6_User.BLL.Interface;
using Task6_User.DAL.Interface;
using Task6_User.Entities;

namespace Task6_User.BLL
{
    public class UserLogic : IUserLogic
    {
        private IUserDao userDao;

        public UserLogic(IUserDao usDao)
        {
            userDao = usDao;
        }

        public User Add(User user)
        {
            return userDao.Add(user);
        }

        public void Delete(int id)
        {
            userDao.Delete(id);
        }

        public User GetById(int id)
        {
            return userDao.GetById(id);
        }

        public IEnumerable<User> GetAll()
        {
            return userDao.GetAll();
        }
        public bool AddAward(int id, int awardId)
        {
            return userDao.AddAward(id, awardId);
        }
        public bool DeleteAward(int id, int awardId)
        {
            return userDao.DeleteAward(id, awardId);
        }
    }
}
