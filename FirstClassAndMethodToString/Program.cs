using System;

namespace FirstClassAndMethodToString
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person [] people = new Person[3]; //this initialized Person type array


            for (int i = 0; i < 3; i++)
            {
                Console.Write("Please enter first name: ");
                string input = Console.ReadLine();
                people[i] = new Person()    // We instantiate the the variable that stores inside of array to be of a Person type, so we can access Name property
                {
                    Name = input
                };   
            }

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }

        }
    }
    public class Person
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Hello, My name is {Name}";
        }

    }


}
