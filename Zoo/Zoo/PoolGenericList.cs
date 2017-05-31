using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class PoolGenericList<T>
    {
        private int _capacity = 20;

        private List<T> _fish = new List<T>();
        


        public PoolGenericList(List<T> animalList)
        {
            
        }


        static bool ImplementsIPredatorsDirectly(Type t)
        {
            if (t.BaseType != null && ImplementsIPredatorsDirectly(t.BaseType))
            {
                return false;
            }
            foreach (var intf in t.GetInterfaces())
            {
                if (ImplementsIPredatorsDirectly(intf))
                {
                    return false;
                }
            }
            return t.GetInterfaces().Any(i => i == typeof(IPredators));
        }

        void AddAnimal(T animal)
        {
            if (ImplementsIPredatorsDirectly(typeof(T)))
            {
                _fish.Add(animal);
                Console.WriteLine("Animal able to swim. Adding to pool");
            }
            else
            {
                Console.WriteLine("Can't add. Animal don't swim");
            }
        }

        void RemoveAnimal(T animal)
        {
            _fish.Remove(animal);
        }

    }
}
