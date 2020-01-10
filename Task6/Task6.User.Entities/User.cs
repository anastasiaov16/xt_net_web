using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_User.Entities
{
    public class User
    {
        private string name;

        public int Id { get; set; }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length < 2 || value.Length > 20)
                {
                    throw new ArgumentException("Write correct Name");
                }
                else
                {
                    name = value;
                }

            }
        }

        public DateTime DateOfBirth { get; set; }

        public int Age => (DateTime.Now.Year - DateOfBirth.Year - (((DateOfBirth.Month > DateTime.Now.Month) || (DateOfBirth.Month == DateTime.Now.Month && DateOfBirth.Day > DateTime.Now.Day)) ? 1 : 0));

        public List<int> Awards { get; } = new List<int>();

        public User(string name, DateTime date)
        {
            Name = name;
            DateOfBirth = date;
        }
    
        public override string ToString()
        {
            return $"ID: {Id} Имя: {Name} Дата рождения:{DateOfBirth} Возраст: {Age}";
        }
    }
}
