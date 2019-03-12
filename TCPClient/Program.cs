using System;
using System.Data;
using System.Net;
using TCPClient.Processor;
using UHFDemo;

namespace TCPClient
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Ip Address");
            var ip = Console.ReadLine();
            Console.WriteLine("Enter TCP Port");
            var port = Convert.ToInt32(Console.ReadLine());

            InventoryProcessor inventoryProcessor = new InventoryProcessor(); 
            if (inventoryProcessor.Connect(ip, port))
            {
                Console.WriteLine("Connected Successfully"); 
            }
            else
            {
                Console.WriteLine("Error in Connection");
            }

            Console.ReadLine();
        }
         
    }
}
