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


    public enum Occupation
    {
        Developer,
        Manager,
        QA
    }

    public class ItPerson
    {
        public string Occupation { get; private set; }
        public double Salary { get; private set; }
        public string Name { get; private set; }
        public string FamilyName { get; private set; }
        public Gender Gender { get; private set; }
        public int Age { get; private set; }

        public ItPerson(string name, string familyName, Gender gender, int age, string occupation, double salary)
        {
            this.Name = name;
            this.FamilyName = familyName;
            this.Gender = gender;
            this.Age = age;
            this.Salary = salary;
            this.Occupation = occupation;

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

        static void writeToConsole(IEnumerable<string> people)
        {
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }


        static IEnumerable<string> GetItGirlsName(List<Person> people, List<ItPerson> itpeople )
        {
            var query = (from person in people
                        
                        where person.Age > 18 && person.Gender == Gender.Female
                        select person.Name).Concat
                        (from per in itpeople                    
                        where  per.Gender == Gender.Female
                        select per.Name);

            return query;
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


            //-------------------------------------------

            List<ItPerson> itPersonList = new List<ItPerson>();

            itPersonList.Add(new ItPerson("Elvis", "Prestly", Gender.Male, 33, "Manager", 3000.0));
            itPersonList.Add(new ItPerson("Frank", "Sinatra", Gender.Male, 44, "Developer", 3000.0));
            itPersonList.Add(new ItPerson("Vera", "Brejneva", Gender.Female, 35, "Developer", 3000.0));
            itPersonList.Add(new ItPerson("Justin", "Beaber", Gender.Male, 44, "Developer", 3000.0));
            itPersonList.Add(new ItPerson("Anna", "Frank", Gender.Female, 12, "QA", 3000.0));
            itPersonList.Add(new ItPerson("Ganna", "Grach", Gender.Female, 10, "Manager", 3000.0));
            itPersonList.Add(new ItPerson("John", "Snow", Gender.Male, 10, "QA", 3000.0));

            writeToConsole(GetItGirlsName(personList, itPersonList));

        }
    }
}
