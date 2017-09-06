using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebClient webClient = new WebClient())
            {
                string url = "https://www.youtabe.com";
                try
                {
                    Console.WriteLine(webClient.OpenRead(url));
                }
                catch (System.Net.WebException exception)
                {
                    Console.WriteLine(exception.Message);
                }
                Console.ReadLine();
            }
        }
    }
}
