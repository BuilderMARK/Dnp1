using System;

namespace S2_Ex2
{

        public class Patient
        { 
            private int PatientNo { get; set; }
            private WaitingRoom waitingRoom;

            public Patient(WaitingRoom wr)
            {
                PatientNo = wr.DrawNumber();
                wr.NumberChange += OnNumberChanged;
                waitingRoom = wr;
            }
            public void OnNumberChanged(int patientNo)
            {
                Console.WriteLine($"Patient {PatientNo} looks up");
                if(PatientNo == patientNo)
                {
                    Console.WriteLine($"Patient {PatientNo} walks into the doctors office.");
                    waitingRoom.NumberChange -= OnNumberChanged;
                }
                else Console.WriteLine($"Patient {PatientNo} goes back to look at his phone");

            }
        }
    
    
}