using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ClienteUDP
{
    class Program
    {
        static void Main(string[] args)
        {

            //Aplicação que envia qualquer valor inserido pelo usuario e retorna esse valor somado com mais 10;
            //Essa aplicação é para entender os conceitos basicos da comunicação UDP.
            var client = new UdpClient();
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11000); 
            client.Connect(ep);

            var data = Encoding.ASCII.GetBytes(Console.ReadLine());

            client.Send(data, data.Length);

            var receivedData = client.Receive(ref ep);
            int.TryParse(Encoding.UTF8.GetString(receivedData), out int inteiroRecbido);

            Console.WriteLine("Dados recebidos de: " + ep.ToString());
            Console.WriteLine("Valor recido: " + inteiroRecbido.ToString());

            Console.Read();
        }
     }
 }
