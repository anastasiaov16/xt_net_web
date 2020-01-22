using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Task6_User.DAL.Interface;
using Task6_User.Entities;

namespace Task6_User.DAL
{
    public class AwardsFileDao : IAwardsDao
    {
        private static Dictionary<int, Awards> awardsList;

        private static readonly string fileStream = @"C:\Users\Александр\Documents\xt_net_web\Task6\awards.txt";

        public AwardsFileDao()
        {
            if (File.Exists(fileStream))
            {
                using (var streamR = new StreamReader(File.Open(fileStream, FileMode.Open)))
                {
                    string fileInside = streamR.ReadLine();
                    awardsList = JsonConvert.DeserializeObject<Dictionary<int, Awards>>(fileInside);
                }
            }
            else
                awardsList = new Dictionary<int, Awards>();
        }

        private void Save()
        {
            if (File.Exists(fileStream))
            {
                File.Delete(fileStream);
            }
            using (StreamWriter stream = new StreamWriter(File.Open(fileStream, FileMode.Create)))
            {
                stream.Write(JsonConvert.SerializeObject(awardsList));
            }
            File.SetAttributes(fileStream, FileAttributes.Hidden);
        }

        public Awards Add(Awards awards)
        {
            var lastId = awardsList.Count() == 0 ? 0 : awardsList.Keys.Max();
            awards.Id = ++lastId;

            awardsList.Add(awards.Id, awards);
            Save();
            return awards;
        }

        public void Delete(int id)
        {
            if (awardsList.ContainsKey(id))
            {
                awardsList.Remove(id);
                Save();
            }
            else throw new ArgumentException("Awards with this ID doesn't exist");
        }

        public Awards GetById(int id)
        {
            //return awardsList.ContainsKey(id) ? awardsList[id] : throw new ArgumentNullException();

            if (awardsList.TryGetValue(id, out var award))
            {
                return award;
            }
            else throw new ArgumentException("Awards with this ID doesn't exist");
        }

        public IEnumerable<Awards> GetAll()
        {
            return awardsList.Values;
        }

        public void AddUser(int awardId, int userId)
        {
            awardsList[awardId].Users.Add(userId);
            Save();
        }

        public void DeleteUser(int awardId, int userId)
        {
            awardsList[awardId].Users.Remove(userId);
            Save();
        }

        ~AwardsFileDao()
        {
            Save();
        }
    }
}
