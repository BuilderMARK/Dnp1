using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace S3_E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("S3-E2");

            var person1 = new Person()
            {
                FirstName = "Mark",
                LastName = "Pedersen",
                Age = 12,
                Hight = 170,
                Hobbies = new string[] {"Football", "hej"},
                IsMarried = true,
                Sex = 'M',
            };
            var person2 = new Person()
            {
                FirstName = "Ole",
                LastName = "Oedersen",
                Age = 14,
                Hight = 112,
                Hobbies = new string[] {"Football", "Nej"},
                IsMarried = true,
                Sex = 'F',
            };
            var person3 = new Person()
            {
                FirstName = "Ulla",
                LastName = "Pedersen",
                Age = 3,
                Hight = 150,
                Hobbies = new string[] {"balls", "MakeUp"},
                IsMarried = false,
                Sex = 'F',
            };

            List<Person> persons = new List<Person>();
            persons.Add(person1);
            persons.Add(person2);
            persons.Add(person3);
            StoreObject(persons);
            var peeps = ReadObject();
        }

        private static void StoreObject(List<Person> people)
        {
            File.WriteAllText("C:\\Users\\Bent\\RiderProjects\\Semester3\\S3-E2\\MyLines.txt",
                JsonSerializer.Serialize(people));
        }

        private static List<Person> ReadObject()
        {
            return JsonSerializer.Deserialize<List<Person>>(File.ReadAllText("C:\\Users\\Bent\\RiderProjects\\Semester3\\S3-E2\\MyLines.txt"));
        }
    }
}