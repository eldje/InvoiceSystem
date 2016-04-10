using System;
using InvoiceSystem.Models;

namespace InvoiceSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Init i = new Init();
            i.Run();
            
            Menu m = new Menu();
            m.StartMenu();
  
            Console.ReadLine();
        }
    }
}
