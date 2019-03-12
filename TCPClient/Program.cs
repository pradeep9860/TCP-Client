using System;
using System.Net;

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
            if(Connect(ip, port))
            {
                Console.WriteLine("Connected Successfully");
            }
            else
            {
                Console.WriteLine("Error in Connection");
            }

            Console.ReadLine();
        } 

        private static bool Connect(string ip, int tcpport)
        {
            Reader.ReaderMethod reader = new Reader.ReaderMethod();
            try
            { 
                string strException = string.Empty;
                IPAddress ipAddress = IPAddress.Parse(ip);
                int nPort = Convert.ToInt32(tcpport);

                int nRet = reader.ConnectServer(ipAddress, nPort, out strException);
                if (nRet != 0)
                {
                    string strLog = "Connect reader failed, due to: " + strException;
                    Console.Write( strLog, 1); 
                }
                else
                {
                    string strLog = "Reader connected  " + ipAddress.ToString() + "@" + nPort.ToString();
                    Console.Write(strLog, 0);
                    return true;
                }
                return false;
            }
            catch (System.Exception ex)
            {
                Console.Write(ex.Message, 0);
                return false;
            } 
        }
    }
}
