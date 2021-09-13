using System;

namespace S1_Ex1
{
    public class Person
    {
        public string name { get; set; }
        private Person p = new Person();

        public void Introduce()
        {
            
            Console.WriteLine("Hi my name is " + name);
        }
        
    }
}