using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManager;

namespace Zoo
{
    public sealed class Frog : Reptiles, ISwimmable, INonPedators
    {
        public Frog(ZooManagerSingleton manager, int age, int maxWorkAge) : base( manager, age, maxWorkAge)
        {

        }
        public void EatVegetables()
        {

        }

        public void Swim()
        {

        }
    }

}
