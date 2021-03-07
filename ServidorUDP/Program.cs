using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServidorUDP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Servidor que espera receber um valor inteiro, positivo e soma com mais 10 e retorna esse valor para o cliente.
            UdpClient udpServer = new UdpClient(11000);

            while (true)
            {
                const int valorInteiro = 10;

                var remoteEP = new IPEndPoint(IPAddress.Any, 11000);
                var data = udpServer.Receive(ref remoteEP); 

                Console.WriteLine("Recebeu dados de:  " + remoteEP.ToString());
                Console.WriteLine("Dados recebidos: " + Encoding.UTF8.GetString(data));

                int.TryParse(Encoding.UTF8.GetString(data), out int soma);
                soma += valorInteiro;
                var bytesParaEnviar = Encoding.ASCII.GetBytes(soma.ToString());

                udpServer.Send(bytesParaEnviar, bytesParaEnviar.Length, remoteEP); 
            }

        }

    }
}
