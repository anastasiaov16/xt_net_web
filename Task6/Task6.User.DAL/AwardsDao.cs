using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6_User.DAL.Interface;
using Task6_User.Entities;

namespace Task6_User.DAL
{
    public class AwardsDao : IAwardsDao
    {
        private static readonly Dictionary<int, Awards> awardsList = new Dictionary<int, Awards>();

        public Awards Add(Awards awards)
        {
            var lastId = awardsList.Count() == 0 ? 0 : awardsList.Keys.Max();
            awards.Id = ++lastId;

            awardsList.Add(awards.Id, awards);

            return awards;
        }

        public void Delete(int id)
        {
            if(awardsList.ContainsKey(id))
                awardsList.Remove(id);
            else throw new ArgumentException("Awards with this ID doesn't exist");
        }

        public Awards GetById(int id)
        {
            //return awardsList.ContainsKey(id) ? awardsList[id] : throw new ArgumentNullException();

            if(awardsList.TryGetValue(id, out var award))
                return award;
            else throw new ArgumentException("Awards with this ID doesn't exist");
        }

        public IEnumerable<Awards> GetAll()
        {
            return awardsList.Values;
        }

        public void AddUser(int awardId, int userId)
        {
            awardsList[awardId].Users.Add(userId);
        }

        public void DeleteUser(int awardId, int userId)
        {
            awardsList[awardId].Users.Remove(userId);
        }
    }
}
