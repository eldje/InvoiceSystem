namespace InvoiceSystem.Models
{
    /// <summary>
    /// describes a product with buying and sellingprice exclusive taxes, and a taxcategorie
    /// </summary>
    public class Product
    {
        //prop
        public decimal ProfitPerc { get; set; } = 1.15m;
        private decimal _sellingPriceExTax;
        public decimal SellingPriceExTax
        {
            get { return _sellingPriceExTax; }
            set { _sellingPriceExTax = (ProdBuyPrice * ProfitPerc); }
        }

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
    }
}
