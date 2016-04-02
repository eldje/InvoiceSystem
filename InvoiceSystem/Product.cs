using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceSystem
{
    /// <summary>
    /// describes a product with buying and sellingprice exclusive taxes, and a taxcategorie
    /// </summary>
    public class Product
    {
        //ctor
        public Product(string prodId, string prodDesc, decimal prodBuyPrice)
        {
            this.ProdId = prodId;
            this.ProdDesc = prodDesc;
            this.ProdBuyPrice = prodBuyPrice;
        }
        public string ProdId { get; set; }
        public string ProdDesc { get; set; }
        public decimal ProdBuyPrice { get; set; }
        //prop
        public decimal ProfitPerc { get; set; } = 1.15m;
        private decimal _sellingPriceExTax;
        public decimal SellingPriceExTax
        {
            get { return _sellingPriceExTax; }
            set { _sellingPriceExTax = (ProdBuyPrice * ProfitPerc); }
        }
    }
}
