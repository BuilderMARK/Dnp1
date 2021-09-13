using System;
using System.Threading;

namespace S2_Ex2
{
    public class WaitingRoom
    {
        public Action<int> NumberChange;
        private int currentNumber { get; set; }
        private int ticketCount { get; set; }

        public WaitingRoom()
        {
            currentNumber = 0;
            ticketCount = 0;
        }

        public void RunWaitingRoom()
        {
            while (currentNumber < ticketCount)
            {
                currentNumber++;
                Console.WriteLine("Ding!");
                NumberChange?.Invoke(currentNumber);
                Thread.Sleep(1000);
            }
        }

        public int DrawNumber()
        {
            Console.WriteLine($"Patient {ticketCount} enters the room");
            ticketCount++;
            return ticketCount;
        }
    }
}