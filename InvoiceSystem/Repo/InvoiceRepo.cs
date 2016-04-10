using System;
using InvoiceSystem.Models;

namespace InvoiceSystem.Repo
{
    class InvoiceRepo
    {
        public void ShowInvoices()
        {
            foreach (Invoice invoice in DataProvider.Invoices)
                Console.WriteLine("{0} \t {1} \t {2} \t \t {3}", invoice.Date,invoice.InvoiceNumber, invoice.TotalAmount, invoice.Client);
        }

        public void ShowInvoice(int invoiceNumber)
        {
            var invoice = DataProvider.Invoices.Where(x => x.InvoiceNumber == invoiceNumber);
            var castedInvoice = (Invoice) invoice;
            Console.WriteLine("{0} \t {1} \t {2} \t \t {3}", castedInvoice.Date, castedInvoice.InvoiceNumber, castedInvoice.TotalAmount, castedInvoice.Client);
        }

        // move input to menu.cs
        public void NewInvoiceRule()
        {
            InvoiceRule invRule = new InvoiceRule();
            Console.WriteLine("Enter the productId :");
            invRule.Product.ProdId = Console.ReadLine();
            Console.WriteLine("Enter the amount: ");
            invRule.Amount = Convert.ToInt32(Console.ReadLine());

            InvRules.Add(invRule);
        }
}
