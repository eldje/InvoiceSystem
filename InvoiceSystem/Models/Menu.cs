using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceSystem.Repo;

namespace InvoiceSystem.Models
{
    class Menu
    {
        public static void OpenMenu()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("1. Enter a new product.");
            Console.WriteLine("2. Enter a new invoice.");
            Console.WriteLine("3. See the list of products.");
            Console.WriteLine("4. See the list of invoices.");
            Console.WriteLine("----------------------------------");
            Console.Write("Make your choice : ");
            int caseSwitch = Convert.ToInt32(Console.ReadLine()); 
            switch (caseSwitch)
            {
                case 1:
                    
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    Console.WriteLine("Case 1");
                    break;
                case 4:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("That was not an option, try again");
                    OpenMenu();
                    break;
            }
        }
    }
}
