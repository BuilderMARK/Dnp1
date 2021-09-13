using System;
using System.IO.IsolatedStorage;
using System.Runtime.Serialization;

namespace S1_Ex2
{
    public class Numbers
    {
        public void EvenNumbers()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2==0)
                {
                    Console.WriteLine(i); 
                }
                
            }
        }
    }
}