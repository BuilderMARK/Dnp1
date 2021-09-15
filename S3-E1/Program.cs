using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace S3_E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programstaring.....");

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
            string jsonFormatted = JsonSerializer.Serialize(persons, new JsonSerializerOptions {    WriteIndented = true});
            Console.WriteLine(jsonFormatted);



        }
    }
}