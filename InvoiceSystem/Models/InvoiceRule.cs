namespace InvoiceSystem.Models
{
    class InvoiceRule
    {
        public int InvoiceRuleNmbr { get; private set; }
        public Product Product;
        public int Amount { get; set; }
    }
}
