using System;
using InvoiceSystem.Repo;

namespace InvoiceSystem.Models
{
    class Menu
    {
        public void StartMenu()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("1. Enter a new product.");
            Console.WriteLine("2. Enter a new invoice.");
            Console.WriteLine("3. See the list of products.");
            Console.WriteLine("4. See the list of invoices.");
            Console.WriteLine("5. Quit");
            Console.WriteLine("----------------------------------");
            Console.Write("Make your choice : ");
            int caseSwitch = Convert.ToInt32(Console.ReadLine()); 
            switch (caseSwitch)
            {
                case 1:

                    break;
                case 2:
                    Invoice inv = new Invoice();
                    InvoiceMenu(inv);
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    break;
                case 4:
                    Console.WriteLine("Case 4");
                    break;
                case 5:
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("That was not an option, try again");
                    StartMenu();
                    break;
            }
        }
        public static void InvoiceMenu(Invoice inv)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("1. Enter a new InvoiceRule.");
            Console.WriteLine("2. Enter a client.");
            Console.WriteLine("3. See the list of products.");
            Console.WriteLine("4. Submit invoice.");
            Console.WriteLine("5. Return to startmenu.");
            Console.WriteLine("----------------------------------");
            Console.Write("Make your choice : ");
            int caseSwitch = Convert.ToInt32(Console.ReadLine());
            switch (caseSwitch)
            {
                case 1:
                    Invoices
                    inv.NewInvoiceRule();
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    break;
                case 4:
                    Console.WriteLine("Case 4");
                    break;
                default:
                    Console.WriteLine("That was not an option, try again");
                    InvoiceMenu();
                    break;
            }
        }

        public void NewProductInput()
        {
            Console.WriteLine("Enter the productId: ");
            string prodId = Console.ReadLine();
            Console.WriteLine("Enter the product description: ");
            string prodDesc = Console.ReadLine();
            Console.WriteLine("Enter the buy-in price of the product: ");
            decimal prodBuyPrice = Convert.ToDecimal(Console.ReadLine());
            Models.
             product(prodId, prodDesc, prodBuyPrice);
        }
    }
}
