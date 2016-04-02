using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
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
