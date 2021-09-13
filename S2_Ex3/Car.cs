using System.Collections.Generic;
using System.Threading.Channels;

namespace S2_Ex3
{
    public class Car
    {
        public string Color       { get; set; }
        public double EngineSize  { get; set; }
        public double FuelEconomy { get; set; }
        public bool IsManualShift { get; set; }

        public Car(string color, double engineSize, double fuelEconomy, bool isManualShift)
        {
            Color = color;
            EngineSize = engineSize;
            FuelEconomy = fuelEconomy;
            IsManualShift = isManualShift;
        }

        public Car()
        {
            //Den her metode bliver brugt, fordi ellers skulle vi have en masse 
            //argumenter i vores main klasse og det magter jeg ikke lige
        }

        public override string ToString()
        {
            return
                $"Color of the car is : {Color} and the EngineSize is: {EngineSize}  the fuel economy is {FuelEconomy}  and the geatbox is {IsManualShift} ";

        }


        public List<Car> GetCars()
        {
            return new List<Car>
            {
                new Car("Blue", 3.0, 30, true),
                new Car("Red", 3.1, 30, true),
                new Car("Green", 3.2, 30, true),
                new Car("Yellow", 3.3, 31, false),
                new Car("Blue", 3.3, 34, true),
                new Car("LightBlue", 3.4, 33, true),
                new Car("Green", 3.5, 31, false),
                new Car("Blue", 3.4, 31, true),
                new Car("Red", 3.2, 33, false),
                new Car("Yellow", 3.3, 34, true),
                new Car("Blue", 3.1, 31, false),
                new Car("Blue", 3.0, 32, true),
            };
        }
    }
}