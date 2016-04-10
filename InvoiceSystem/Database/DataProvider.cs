using System.Collections.Generic;
using InvoiceSystem.Models;
using System.IO;
using Newtonsoft.Json;

namespace InvoiceSystem
{
    public static class DataProvider // Database Layer
    {
        public static string FilePathInv { get; } = "InvoiceRepo.json";
        public static string FilePathProd { get; } = "ProductRepo.json";

        /// <summary>
        /// Json part
        /// methods to load and save lists to json
        /// </summary>
        
        //Method for saving invoices
        
        public static void LoadList()
        {
            Products = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText(FilePath)) ?? new List<Product>();
        }
        public static void SaveList(List<Product> Products)
        {
            File.WriteAllText(FilePath, JsonConvert.SerializeObject(Products));
        }        
        
        // Method for loading invoices

        // Load the invoices in constructor
        // save invoices before terminating programm
    }
}
