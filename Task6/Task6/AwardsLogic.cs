using System;
using System.Collections.Generic;
using System.Text;
using Task6_User.BLL.Interface;
using Task6_User.DAL.Interface;
using Task6_User.Entities;

namespace Task6_User.BLL
{
    public class AwardsLogic : IAwardsLogic
    {
        private IAwardsDao awardsDao;

        public AwardsLogic(IAwardsDao awDao)
        {
            awardsDao = awDao;
        }

        public Awards Add(Awards award)
        {
            return awardsDao.Add(award);
        }

        public void Delete(int id)
        {
            awardsDao.Delete(id);
        }

        public Awards GetById(int id)
        {
            return awardsDao.GetById(id);
        }

        public IEnumerable<Awards> GetAll()
        {
            return awardsDao.GetAll();
        }

        public void AddUser(int awardId, int userId)
        {
            awardsDao.AddUser(awardId, userId);
        }

        public void DeleteUser(int awardId, int userId)
        {
            awardsDao.DeleteUser(awardId, userId);
        }
    }
}
