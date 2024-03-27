using System.Net.Sockets;
using System.Net;
using System.Text;

Console.Write("Введите ваше IP: ");
string ip = Console.ReadLine();
const int port = 8080;

var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

tcpSocket.Bind(tcpEndPoint);
tcpSocket.Listen(5);

while (true)
{
    var listener = tcpSocket.Accept();
    var buffer = new byte[256];
    var size = 0;
    var data = new StringBuilder();

    do
    {
        size = listener.Receive(buffer);
        data.Append(Encoding.UTF8.GetString(buffer, 0, size));
    }
    while (listener.Available > 0);

    Console.WriteLine(data);

    listener.Send(Encoding.UTF8.GetBytes("--[Сообщение доставлено]--"));

    listener.Shutdown(SocketShutdown.Both);
    listener.Close();
}
