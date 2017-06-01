using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17
{
    public enum Gender
    {
        Female,
        Male
    }

    public class Person
    {
        public string Name { get; private set; }
        public string FamilyName { get; private set; }
        public Gender Gender { get; private set; }
        public int Age { get; private set; }

        public Person(string name, string familyName, Gender gender, int age)
        {
            this.Name = name;
            this.FamilyName = familyName;
            this.Gender = gender;
            this.Age = age;

        }

    }


    class Program
    {

        static IEnumerable<Person> GetChildren(List<Person> people)
        {
            var query = from person in people
                orderby person.Name ascending 
                        //where person.Age <= 18 && person.Gender == Gender.Female
                select person;

            return query;
        }

        static void vriteToConsole(IEnumerable<Person> people)
        {
            foreach (var person in people)
            {
                Console.WriteLine(person.Name);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] {1, 2, 3, 4, 5};
            var queryRes = from num in arr
                            where num > 3
                            select num;

            List<int> myList = queryRes.ToList();

            foreach (var element in myList)
            {
                Console.WriteLine(element);
            }


            //---------------------------

            List<Person> personList = new List<Person>();

            personList.Add(new Person("Elvis","Prestly", Gender.Male, 33));
            personList.Add(new Person("Frank", "Sinatra", Gender.Male, 44));
            personList.Add(new Person("Vera", "Brejneva", Gender.Female, 35));
            personList.Add(new Person("Justin", "Beaber", Gender.Male, 44));
            personList.Add(new Person("Anna", "Frank", Gender.Female, 12));
            personList.Add(new Person("Ganna", "Grach", Gender.Female, 10));
            personList.Add(new Person("John", "Snow", Gender.Male, 10));

            vriteToConsole(GetChildren(personList));
        }
    }
}
