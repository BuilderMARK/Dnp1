using System;
using System.Collections.Generic;

namespace S3_E1
{
    public class Person
    {
        public string FirstName { get ; set; }
        public string LastName { get ; set; }
        public int Age { get ; set; }
        public double Hight { get ; set; }
        public bool IsMarried { get ; set; }
        public char Sex { get ; set; }
        public string[] Hobbies{ get ; set; }

        public Person(string firstName, string lastName, int age, double hight, bool isMarried, char sex, string[] hobbies)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Hight = hight;
            IsMarried = isMarried;
            Sex = sex;
            Hobbies = hobbies;
        }

        public Person()
        {
            
        }
        
    }
    
    
}