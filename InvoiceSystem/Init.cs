using InvoiceSystem.Repo;

namespace InvoiceSystem
{
    class Init
    {
        public static InvoiceRepo InvRepo { get; set; } = new InvoiceRepo();
        public static ProductRepo ProdRepo { get; set; } = new ProductRepo();
        
        public void Run()
        {
            InvRepo.LoadInvoiceList();
            ProdRepo.LoadProductList();
        }
    }
}
