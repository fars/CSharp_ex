using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Cage
    {
        private Dictionary<string, Animal> _animalName = new Dictionary<string, Animal>();

        public void AddAnimal(string name, Animal animal)
        {
            try
            {
                _animalName.Add(name, animal);
                Console.WriteLine("Added " + name);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Can't add " + e.Message);
            }
           
        }
    }
}
