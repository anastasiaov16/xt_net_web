using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_User.Entities
{
    public class Awards
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public List<int> Users { get; } = new List<int>();

        public Awards() { }

        public Awards(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"ID: {Id} Награда: {Title}";
        }

    }
}
