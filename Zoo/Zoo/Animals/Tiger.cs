using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManager;

namespace Zoo
{
    public sealed class Tiger : Mammals, ICats, IPredators
    {
        public Tiger(ZooManagerSingleton manager, int age, int maxWorkAge) : base( manager, age, maxWorkAge)
        {
            Console.WriteLine("New Tiger in ZOO, age {0}", age);
        }

        public void EatMeat()
        {

        }

        public void TreeClimbers()
        {
        }

        public override void AgeChangeNotification(ZooManagerSingleton manager, EventArgs data)
        {
            Age++;
            Console.WriteLine("Tiger,  HAPPY BIRTHDAY, Age {0} ", Age);
            if (Age >= WorkAge)
            {
                manager.TickEvent -= AgeChangeNotification;
                Console.WriteLine("Tiger Stopping working in ZOO...");
            }
        }
    }

}
