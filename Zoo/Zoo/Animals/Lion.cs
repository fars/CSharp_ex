using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManager;

namespace Zoo
{
    
    public sealed class Lione : Mammals, ICats, IPredators
    {
        public Lione(ZooManagerSingleton manager, int age, int maxWorkAge) : base( manager, age, maxWorkAge)
        {
            Console.WriteLine("New LION in ZOO, age {0}", age);
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
            Console.WriteLine("LION,  HAPPY BIRTHDAY, Age {0} ", Age);
            if (Age >= WorkAge)
            {
                manager.TickEvent -= AgeChangeNotification;
                Console.WriteLine("LION Stopping working in ZOO...");
            }
        }
    }

}
