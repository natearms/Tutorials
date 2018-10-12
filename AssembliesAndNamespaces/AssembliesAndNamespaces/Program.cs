using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            WebClient client = new WebClient();
            string reply = client.DownloadString("https://www.google.com");
            
            File.WriteAllText(@"C:\test.txt", reply);

            Console.WriteLine(reply);
            Console.ReadLine();
        }
    }
}
