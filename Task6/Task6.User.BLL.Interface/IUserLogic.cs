using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6_User.Entities;

namespace Task6_User.BLL.Interface
{
    public interface IUserLogic
    {
        User Add(User user);
        void Delete(int id);
        User GetById(int id);
        IEnumerable<User> GetAll();
        bool AddAward(int id, int awardId);
        bool DeleteAward(int id, int awardId);
    }
}
