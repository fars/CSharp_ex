using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Mammals : Animal
    {

    }

    public sealed class Lione : Mammals, ICats, IPredators
    {
        public void EatMeat()
        {

        }
    }

    public sealed class Tiger : Mammals, ICats, IPredators
    {
        public void EatMeat()
        {

        }
    }

    public sealed class Horse : Mammals, INonPedators
    {
        public void EatVegetables()
        {

        }
    }

    public sealed class Kengoo : Mammals, INonPedators
    {
        public void EatVegetables()
        {

        }
    }
}
