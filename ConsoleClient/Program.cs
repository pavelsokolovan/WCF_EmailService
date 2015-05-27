using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleClient.Proxies;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter email adress: ");
            string emailAdress = Console.ReadLine();
            EmailValidatorClient emailValidatorClient = new EmailValidatorClient();
            Console.WriteLine(emailValidatorClient.ValiddateAdress(emailAdress));
            Console.ReadKey();
        }
    }
}
