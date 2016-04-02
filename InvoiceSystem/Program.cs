using System;
using InvoiceSystem.Models;
using InvoiceSystem.Repo;

namespace InvoiceSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Init.Run();
            
            Menu.OpenMenu();

            Console.ReadLine();
        }
    }
}
