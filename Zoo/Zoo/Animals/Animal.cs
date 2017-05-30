using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManager;

namespace Zoo
{
    public class Animal
    {
        protected int Age = 0;
        protected int WorkAge = 0;

        public Animal(ZooManagerSingleton manager, int age, int maxWorkAge)
        {
            Age = age;
            WorkAge = maxWorkAge;
            if (Age < WorkAge)
            {
                manager.TickEvent += AgeChangeNotification;
            }
        }

        public virtual void AgeChangeNotification(ZooManagerSingleton manager, EventArgs data)
        {
            Age++;
            Console.WriteLine("Age {0} ", Age);
            if (Age >= WorkAge)
            {
                manager.TickEvent -= AgeChangeNotification;
                Console.WriteLine("Stopping working in ZOO...");
            }
        }

    }

}
