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
    public class UserFileDao : IUserDao
    {
        private static Dictionary<int, User> userList;
        private static readonly string fileStream = @"C:\Users\Александр\Documents\xt_net_web\Task6\users.txt";

        public UserFileDao()
        {
            if (File.Exists(fileStream))
            {
                using (var streamR = new StreamReader(File.Open(fileStream, FileMode.Open)))
                {
                    string fileInside = streamR.ReadLine();
                    userList = JsonConvert.DeserializeObject<Dictionary<int, User>>(fileInside);
                }
            }
            else
                userList = new Dictionary<int, User>();
        }

        private void Save()
        {
            if (File.Exists(fileStream))
            {
                File.Delete(fileStream);
            }
            using (StreamWriter stream = new StreamWriter(File.Open(fileStream, FileMode.Create)))
            {
                stream.Write(JsonConvert.SerializeObject(userList));
            }      
            File.SetAttributes(fileStream, FileAttributes.Hidden);
        } 

        public User Add(User user)
        {
            var lastId = userList.Count() == 0 ? 0 : userList.Keys.Max();
            user.Id = ++lastId;
            userList.Add(user.Id, user);

            Save();
            return user;
        }

        public void Delete(int id)
        {
            if (userList.ContainsKey(id))
            {
                userList.Remove(id);
                Save();
            }
            else throw new ArgumentException("User with this ID doesn't exist");
        }

        public User GetById(int id)
        {
            //return userList.ContainsKey(id) ? userList[id] : throw new ArgumentNullException();

            if (userList.TryGetValue(id, out var user))
            {
                return user;
            }
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
            Save();
            return true;
        }

        public bool DeleteAward(int id, int awardId)
        {
            if (!userList[id].Awards.Remove(awardId))
            {
                return false;
            }
            Save();
            return true;
        }

        ~UserFileDao()
        {
            Save();
        }
    }
}
