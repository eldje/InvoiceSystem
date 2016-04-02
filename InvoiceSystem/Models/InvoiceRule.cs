namespace InvoiceSystem.Models
{
    class InvoiceRule
    {
        public InvoiceRule()
        {
        }

        public InvoiceRule(Product product, int amount)
        {
            this.Product = product;
            this.Amount = amount;
        }
        public Product Product;
        public int Amount { get; set; }
        public int InvoiceRuleNmbr { get; set; }
    }
}
