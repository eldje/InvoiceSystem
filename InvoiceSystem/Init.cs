using InvoiceSystem.Repo;

namespace InvoiceSystem
{
    class Init
    {
        public static void Run()
        {
            InvoiceRepo invoiceRepo = new InvoiceRepo();
            invoiceRepo.LoadInvoiceList();
            ProductRepo prodRepo = new ProductRepo();
            prodRepo.LoadProductList();
        }
    }
}
