using System;
using System.Collections.Generic;

namespace InvoiceSystem.Models
{
    public class Invoice
    {
        public int InvoiceNumber { get; private set; }
        public DateTime Date;
        public decimal TotalAmount { get; set; }
    }
}
