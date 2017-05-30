using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManager;

namespace Zoo
{

    public sealed class Kengoo : Mammals, INonPedators
    {
        public Kengoo(ZooManagerSingleton manager, int age, int maxWorkAge) : base( manager, age, maxWorkAge)
        {
            Console.WriteLine("New KENGOO in ZOO, age {0}", age);
        }
        public void EatVegetables()
        {

        }
        public override void AgeChangeNotification(ZooManagerSingleton manager, EventArgs data)
        {
            Age++;
            Console.WriteLine("Kengoo,  HAPPY BIRTHDAY, Age {0} ", Age);
            if (Age >= WorkAge)
            {
                manager.TickEvent -= AgeChangeNotification;
                Console.WriteLine("Kengoo Stopping working in ZOO...");
            }
        }
    }
}
