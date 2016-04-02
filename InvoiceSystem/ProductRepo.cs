using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.Remoting.Messaging;
using InvoiceSystem;

namespace InvoiceSystem
{
    /// <summary>
    /// this manages the list of products,
    /// it loads and saves it from and to a jsonfile 
    /// has the methods to load, add, remove, save
    /// </summary>
    public class ProductRepo
    {
        public ProductRepo()
        {
            this.Products = new List<Product>();
        }
        public List<Product> Products { get; set; }
        /// <summary>
        /// Json part
        /// </summary>
        public static string FilePath { get; } = "ProductRepo.json";
        //methods to read and write _productlist to json
        public void LoadProductList()
        {
            Products = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText(FilePath));
        }
        public static void SaveProductList(List<Product> Products)
        {
            File.WriteAllText(FilePath, JsonConvert.SerializeObject(Products));
        }
    }
}
