namespace InvoiceSystem.Models
{
    class Person
    {
        public string Name { get; set; }
        public Address Address { get; set; } = new Address();
    }
}
