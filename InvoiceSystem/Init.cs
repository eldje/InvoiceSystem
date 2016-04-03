using System.Security.Cryptography.X509Certificates;
using InvoiceSystem.Repo;

namespace InvoiceSystem
{
    class Init
    {
        //public ProductRepo prodRepo { get; set; }
        //public InvoiceRepo invoiceRepo { get; set; }

        public static void Run()
        {
            InvoiceRepo invoiceRepo = new InvoiceRepo();
            invoiceRepo.LoadInvoiceList();
            ProductRepo prodRepo = new ProductRepo();
            prodRepo.LoadProductList();
        }
    }
}
