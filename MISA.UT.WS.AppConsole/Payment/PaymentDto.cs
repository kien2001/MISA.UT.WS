using System;

namespace MISA.UT.WS.AppConsole.Payment
{
    public class PaymentDto
    {
        public string AccNumber { set; get; }
        public string CurrencyCode { set; get; } = "VND";
        public decimal Money { set; get; }
        public string CardNumber { set; get; }
        public DateTime CreatedDate { get; set; }
    }
}