using System;
using System.Collections.Generic;
using System.Globalization;

namespace S1_Ex3
{
    public class Calculatir
    {
        public int n1 { set; get; }
        public int n2 { get; set; }
        public int n3;
        private int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9};
        private int allNumbers = 0;
        private int i = 0;
    public void NumberAdder( int n1, int n2, int n3)
    {
        n3 = n1 + n2;
        Console.WriteLine("Første tal er " + n1 +  " anden tal er " + n2 +  " Det til sammen giver " +  n3);
        }

        public void NumberAdder()
        {
            for(int i = 0; i < 9; i++)
            {
                allNumbers= allNumbers + numbers[i];
            }

            Console.WriteLine("tallene i liste giver = " + allNumbers);
            
        }
    }
}