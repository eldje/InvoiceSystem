using System.Collections.Generic;
using InvoiceSystem.Models;

namespace InvoiceSystem.Repo
{
    class SystemRepo
    {
        public static List<Invoice> Invoices { get; set; } = new List<Invoice>(); // Table of Invoices
        public static List<Product> Products { get; set; } = new List<Product>(); // Table of Invoices
    }
}
