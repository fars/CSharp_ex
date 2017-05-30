using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManager;

namespace Zoo
{
    public class Reptiles : Animal
    {
        public Reptiles(ZooManagerSingleton manager, int age, int maxWorkAge) : base( manager, age, maxWorkAge)
        {

        }
    }
}
