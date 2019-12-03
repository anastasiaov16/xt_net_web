﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public abstract class Monsters : IMove, IAttack
    {
        public string Name { get; set; }
        public abstract void Move();
        public abstract void Attack();
    }

}
