using System.Collections.Generic;
using InvoiceSystem.Models;
using Newtonsoft.Json;
using System.IO;

namespace InvoiceSystem.Repo
{
    class InvoiceRepo
    {
        public static string FilePath { get; } = "InvoiceRepo.json";
        public List<Invoice> Invoices { get; set; } = new List<Invoice>();

        /// <summary>
        /// Json part
        /// methods to read and write _productlist to json
        /// </summary>
        public void LoadInvoiceList()
        {
            Invoices = JsonConvert.DeserializeObject<List<Invoice>>(File.ReadAllText(FilePath)) ?? new List<Invoice>();
        }
        public static void SaveInvoiceList(List<Invoice> Invoices)
        {
            File.WriteAllText(FilePath, JsonConvert.SerializeObject(Invoices));
        }
    }
}
