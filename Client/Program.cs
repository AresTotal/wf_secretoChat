using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите IP получателя: ");
            string ip = Console.ReadLine();
            const int port = 8080;

            Console.WriteLine("Введите сообщение: ");

            while (true)
            {
                var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

                var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                var message = Console.ReadLine();

                var data = Encoding.UTF8.GetBytes(message);

                tcpSocket.Connect(tcpEndPoint);
                tcpSocket.Send(data);

                var buffer = new byte[256];
                var size = 0;
                var answer = new StringBuilder();

                do
                {
                    size = tcpSocket.Receive(buffer);
                    answer.Append(Encoding.UTF8.GetString(buffer, 0, size));
                }
                while (tcpSocket.Available > 0);

                Console.WriteLine(answer.ToString());
            }
        }
    }
}