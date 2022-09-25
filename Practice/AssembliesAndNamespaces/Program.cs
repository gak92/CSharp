using System;
using System.IO;
using System.Net;

namespace AssembliesAndNamespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Write this text into the file";
            File.WriteAllText(@"./file.txt", text);

            WebClient client = new WebClient();
            string address = "https://msdn.microsoft.com";
            string reply = client.DownloadString(address);

            Console.WriteLine(reply);
            File.WriteAllText(@"./msdn.txt", reply);

        }
    }
}