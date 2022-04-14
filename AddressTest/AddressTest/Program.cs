using System;
using System.Net;

namespace AddressTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IPHostEntry host1 = Dns.GetHostEntry("www.youtube.com");
            Console.WriteLine(host1.HostName);
            foreach (IPAddress ip in host1.AddressList)
                Console.WriteLine(ip.ToString());

            Console.WriteLine();

            IPHostEntry host2 = Dns.GetHostEntry("yandex.ru");
            Console.WriteLine(host2.HostName);
            foreach (IPAddress ip in host2.AddressList)
                Console.WriteLine(ip.ToString());
        }
    }
}
