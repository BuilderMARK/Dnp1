using System;

namespace S2_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program starting.....");

            WaitingRoom wr = new WaitingRoom();
            Patient p1 = new Patient(wr);
            Patient p2 = new Patient(wr);
            Patient p3 = new Patient(wr);
            Patient p4 = new Patient(wr);
            Patient p5 = new Patient(wr);
            wr.RunWaitingRoom();
        }
        
    }
}