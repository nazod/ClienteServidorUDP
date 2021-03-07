using System;

namespace ServidorClienteUDP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de servidor upd que retorna se uma soma é impar ou par, o primeiro a eviar sempre é par.
            UDPSocket s = new UDPSocket();
            s.Server("127.0.0.1", 27000);

            UDPSocket c = new UDPSocket();
            c.Client("127.0.0.1", 27000);
            Console.WriteLine("Escreva um numero: ");
            c.Send(Console.ReadLine());
            Console.WriteLine("Escreva outro numero: ");
            c.Send(Console.ReadLine());
            c.VencedorParOuImpar();

            Console.ReadKey();
        }
    }
}
