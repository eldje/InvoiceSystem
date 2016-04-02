using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceSystem;

namespace InvoiceSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //load productlist
            ProductRepo prodRepo = new ProductRepo();
            prodRepo.LoadProductList();
            ////
            Product p1 = new Product("2210EC01", "Volle betonsteen", 12.00m);
            prodRepo.Products.Add(p1);
            prodRepo.Products.Add(new Product("2210EC02", "Holle betonsteen", 12.5m));
            
            Product p3 = new Product("22.20EC03", "gevelsteen", 10.5m);
            //
            ProductRepo.SaveProductList(prodRepo.Products);
            Console.WriteLine((prodRepo.Products).ToString());
            Console.ReadLine();
        }
    }
}
