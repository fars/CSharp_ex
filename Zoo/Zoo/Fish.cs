using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Fish : Animal
    {

    }

    public sealed class Shark : Fish, ISwimmable
    {

    }

    public sealed class GoldFish : Fish, ISwimmable
    {

    }
}
