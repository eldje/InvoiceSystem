using System;
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.InteropServices;
using InvoiceSystem.Models;

namespace InvoiceSystem.Repo
{
    /// <summary>
    /// this manages the list of products,
    /// it loads and saves it from and to a jsonfile 
    /// has the methods to load, add, remove, save
    /// </summary>
    public class ProductRepo
    {
        public static string FilePath { get; } = "ProductRepo.json";
        public List<Product> Products { get; set; } = new List<Product>();

        public void NewProduct()
        {
            Console.WriteLine("Enter the productId: ");
            string prodId = Console.ReadLine();
            Console.WriteLine("Enter the product description: ");
            string prodDesc = Console.ReadLine();
            Console.WriteLine("Enter the buy-in price of the product: ");
            decimal prodBuyPrice = Convert.ToDecimal(Console.ReadLine());
            foreach (Product product in Products)
            {
                if (product.ProdId == prodId)
                {
                    Console.WriteLine("this key already exist, pick another one: ");
                    prodId = Console.ReadLine();
                }
            }
            Product prod = new Product(prodId, prodDesc, prodBuyPrice);
            Products.Add(prod);
            SaveProductList(Products);
            Console.WriteLine("The product {0} was added to the productrepo.", prodDesc);
            Menu.OpenMenu();
        }

        /// <summary>
        /// Json part
        /// methods to read and write _productlist to json
        /// </summary>
        public void LoadProductList()
        {
            Products = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText(FilePath)) ?? new List<Product>();
        }
        public static void SaveProductList(List<Product> Products)
        {
            File.WriteAllText(FilePath, JsonConvert.SerializeObject(Products));
        }
    }
}
