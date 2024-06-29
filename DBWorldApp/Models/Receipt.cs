namespace DBWorldApp.Models
{
    public class Receipt
    {
        public string BusinessUnit { get; set; }
        public string ReceiptMethodID { get; set; }
        public string RemittanceBank { get; set; }
        public string RemittanceBankAccount { get; set; }
        public int ReceiptNumber { get; set; }
        public decimal ReceiptAmount { get; set; }
        public DateTime ReceiptDate { get; set; }
        public DateTime AccountingDate { get; set; }
        public DateTime ConversionDate { get; set; }
        public string Currency { get; set; }
        public string ConversionRateType { get; set; }
        public decimal? ConversionRate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAccountNumber { get; set; }
        public string CustomerSiteNumber { get; set; }
        public int InvoiceNumberReference { get; set; }
        public decimal InvoiceAmount { get; set; }
        public string Comments { get; set; }
    }
}
