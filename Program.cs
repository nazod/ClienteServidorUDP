using System;

namespace ServidorClienteUDP
{
    class Program
    {
        static void Main(string[] args)
        {
            UDPSocket s = new UDPSocket();
            s.Server("127.0.0.1", 27000);

            UDPSocket c = new UDPSocket();
            c.Client("127.0.0.1", 27000);
            c.Send(Console.ReadLine());
            c.Send(Console.ReadLine());
            c.VencedorParOuImpar();

            Console.ReadKey();
        }
    }
}
