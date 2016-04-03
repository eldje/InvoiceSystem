using System;
using InvoiceSystem.Models;

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
