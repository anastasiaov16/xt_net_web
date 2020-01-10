using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6_User.DAL.Interface;
using Task6_User.Entities;

namespace Task6_User.DAL
{
    public class UserDao : IUserDao
    {
        private static readonly Dictionary<int, User> userList = new Dictionary<int, User>();

        public User Add(User user)
        {
            var lastId = userList.Count() == 0 ? 0 : userList.Keys.Max();
            user.Id = ++lastId;

            userList.Add(user.Id, user);

            return user;
        }

        public void Delete(int id)
        {
            if (userList.ContainsKey(id))
                userList.Remove(id);
            else throw new ArgumentException("User with this ID doesn't exist");
        }

        public User GetById(int id)
        {
            //return userList.ContainsKey(id) ? userList[id] : throw new ArgumentNullException();

           if(userList.TryGetValue(id, out var user))
            return user;
           else throw new ArgumentNullException("User with this ID doesn't exist");
        }

        public IEnumerable<User> GetAll()
        {
            return userList.Values;
        }

        public bool AddAward(int id, int awardId)
        {
            if (userList[id].Awards.Contains(awardId))
            {
                throw new ArgumentException("User already has a award with such Id");
            }

            userList[id].Awards.Add(awardId);
            return true;
        }

        public bool DeleteAward(int id, int awardId)
        {
            if (!userList[id].Awards.Remove(awardId))
            {
                return false;
            }
            return true;
        }
    }
}
