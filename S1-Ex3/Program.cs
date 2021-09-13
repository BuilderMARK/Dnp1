using System;

namespace S1_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculatir calculatir = new Calculatir();
            calculatir.n1 = 1;
            calculatir.n2 = 2;
            calculatir.NumberAdder();
            calculatir.NumberAdder(2,3,0);
        }
    }
}