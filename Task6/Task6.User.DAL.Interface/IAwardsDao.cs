using System;
using System.Collections.Generic;
using System.Text;
using Task6_User.Entities;

namespace Task6_User.DAL.Interface
{
   public interface IAwardsDao
    {
        Awards Add(Awards user);
        void Delete(int id);
        Awards GetById(int id);
        IEnumerable<Awards> GetAll();
        void AddUser(int awardId, int userId);
        void DeleteUser(int awardId, int userId);
    }
}
