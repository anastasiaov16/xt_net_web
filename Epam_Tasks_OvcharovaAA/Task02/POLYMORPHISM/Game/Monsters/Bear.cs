﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class Bear : Monsters
    {
        public Bear()
        {
            Name = "Bear";
        }
        public override void Attack()
        {
            Console.WriteLine("Bear attack");
        }

        public override void Move()
        {
            Console.WriteLine("Bear moving");
        }
    }
}
