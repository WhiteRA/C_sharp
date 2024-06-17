using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_1
{
    public class Person
    {
        public string Name { get; set; }
        public Person Spouse { get; set; }
        public List<Person> Children { get; set; }

        public Person(string name)
        {
            Name = name;
            Spouse = null;
            Children = new List<Person>();
        }

        public void AddSpouse(Person spouse)
        {
            Spouse = spouse;
            spouse.Spouse = this;
        }

        public void AddChild(Person child)
        {
            Children.Add(child);
        }

        public void PrintFamily(int indentation = 0)
        {
            PrintIndentation(indentation);
            Console.WriteLine(Name);

            if (Spouse != null)
            {
                PrintIndentation(indentation);
                Console.WriteLine("|");
                PrintIndentation(indentation);
                Console.WriteLine("└─ " + Spouse.Name);
            }

            if (Children.Count > 0)
            {
                PrintIndentation(indentation);
                Console.WriteLine("|");
                foreach (Person child in Children)
                {
                    PrintIndentation(indentation);
                    Console.WriteLine("└─ " + child.Name);
                    child.PrintFamily(indentation + 4);
                }
            }
        }

        private void PrintIndentation(int indentation)
        {
            for (int i = 0; i < indentation; i++)
            {
                Console.Write(" ");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Пример использования
            Person john = new Person("John");
            Person emily = new Person("Emily");
            Person sarah = new Person("Sarah");
            Person mike = new Person("Mike");

            john.AddSpouse(emily);
            john.AddChild(sarah);
            john.AddChild(mike);

            john.PrintFamily();
        }
    }
}
