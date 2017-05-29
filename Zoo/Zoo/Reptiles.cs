using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Reptiles : Animal
    {

    }

    public sealed class Snake : Reptiles, ISwimmable, IPredators
    {
        public void EatMeat()
        {

        }
    }

    public sealed class Lizard : Reptiles, IPredators
    {
        public void EatMeat()
        {

        }
    }
    public sealed class Frog : Reptiles, ISwimmable, INonPedators
    {
        public void EatVegetables()
        {

        }
    }

    public class Crockodile : Reptiles, ISwimmable, IPredators
    {
        public void EatMeat()
        {

        }
    }

}
