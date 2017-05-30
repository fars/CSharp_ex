﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManager;

namespace Zoo
{
    public sealed class Snake : Reptiles, ISwimmable, IPredators
    {
        public Snake(ZooManagerSingleton manager, int age, int maxWorkAge) : base( manager, age, maxWorkAge)
        {

        }
        public void EatMeat()
        {

        }

        public void Swim()
        {

        }
    }

}
