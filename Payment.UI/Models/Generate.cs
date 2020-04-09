using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.UI.Models
{
    public class Generate
    {
        public string Channel { get; set; }
        public string Product { get; set; }
        public string InvoiceNo { get; set; }
        public decimal Amount { get; set; }
        public string PaymentOption { get; set; }
    }
}
