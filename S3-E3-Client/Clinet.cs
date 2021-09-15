
using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Channels;

namespace S3_E3_Client
{
    public class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Staring client....");

            TcpClient client = new TcpClient("127.0.0.1", 5000);
            NetworkStream stream = client.GetStream();

            while (true)
            {
                string msg = Console.ReadLine();
                Byte[] dataToServer = Encoding.ASCII.GetBytes(msg);
                stream.Write(dataToServer, 0, dataToServer.Length);

                byte[] dataFromServer = new byte[1024];
                int bytesRead = stream.Read(dataFromServer, 0, dataFromServer.Length);
                string response = Encoding.ASCII.GetString(dataFromServer, 0, bytesRead);
                Console.WriteLine(response);

                if (msg.Equals("Exit"))
                {
                    stream.Close();
                    client.Close();    
                }
                
            }
        }
    }
}