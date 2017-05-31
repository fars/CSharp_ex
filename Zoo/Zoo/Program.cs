using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
           

            ZooPark zoo = new ZooPark();
            Lione lion = new Lione(zoo.GetManager(), 1, 10);
            Tiger tiger = new Tiger(zoo.GetManager(), 3, 12);
            Cage cage = new Cage();
            cage.AddAnimal("Diego", tiger);
            cage.AddAnimal("Sam", lion);




            zoo.StartWork();
        }

    }
}
