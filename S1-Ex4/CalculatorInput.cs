using System;

namespace S1_Ex4
{
    public class CalculatorInput
    {
        private int sum = 0; 
        public void Input()
        {
            Console.WriteLine("Skriv 2 tal og de bliver lagt sammen");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            if (x < y)
            {
                 sum = y;
            }
            else
            {
                 sum= x;
            }

            Console.WriteLine("Højeste nummer er " + sum);
        }
    }
}