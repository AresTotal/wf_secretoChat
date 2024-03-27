using System.Net.Sockets;
using System.Net;
using System.Text;

namespace wf_secretoChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await AsyncServer();
        }

        private async Task AsyncServer()
        {
            await Task.Run(() => Server());
        }
        private void Server()
        {
            Logs.Items.Add("--[Сервер запускается]--");

            string ip = textBox2.Text;
            const int port = 8080;

            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            tcpSocket.Bind(tcpEndPoint);
            tcpSocket.Listen(5);

            Logs.Items.Add("--[Сервер запущен]--");

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

                Logs.Items.Add(data.ToString());

                listener.Send(Encoding.UTF8.GetBytes($"--[Сообщение доставлено {DateTime.Now.TimeOfDay}]--"));

                listener.Shutdown(SocketShutdown.Both);
                listener.Close();
            }
        }
    }
}
