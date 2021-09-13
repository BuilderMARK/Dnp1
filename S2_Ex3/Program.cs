using System;

namespace S2_Ex3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Program Starting......"); 
            Car car = new Car();
            var Getcars = car.GetCars();

           var redCars =  Getcars.FindAll(car => car.Color.Equals("Red"));
           for (int i = 0; i < redCars.Count; i++)
           {

               Console.WriteLine(redCars[i]);

            
           }

           Console.WriteLine("Next sheach");

           var blueCarsWithManuel =
               Getcars.FindAll(car1 => car1.IsManualShift.Equals(true) && car1.Color.Equals("Blue"));
           for (int i = 0; i < blueCarsWithManuel.Count; i++)
           {
               
               Console.WriteLine(blueCarsWithManuel[i]);
           }


        }

        
    }
}