using System;
using System.Collections.Generic;
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
        public List<Product> Products { get; set; } = new List<Product>();

        public void ShowAllProducts()
        {
            foreach (Product product in Products)
                Console.WriteLine("{0} \t {1} \t \t {2}", product.ProdId , product.ProdBuyPrice, product.ProdDesc);
        }
    }

    public void NewProduct(string prodId, string prodDesc, decimal prodBuyPrice)
    {
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
        Models.Menu.
        m.StartMenu();
    }
}
