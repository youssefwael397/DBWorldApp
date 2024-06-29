using CsvHelper.Configuration;
using DBWorldApp.Models;

namespace DBWorldApp.Services
{
    public class ReceiptMap : ClassMap<Receipt>
    {
        public ReceiptMap()
        {
            Map(r => r.BusinessUnit).Name("Business Unit");
            Map(r => r.ReceiptMethodID).Name("Receipt Method ID");
            Map(r => r.RemittanceBank).Name("Remittance Bank");
            Map(r => r.RemittanceBankAccount).Name("Remittance Bank Account");
            Map(r => r.ReceiptNumber).Name("Receipt Number");
            Map(r => r.ReceiptAmount).Name("Receipt Amount");
            Map(r => r.ReceiptDate).Name("Receipt Date").TypeConverterOption.Format("dd/MM/yyyy");
            Map(r => r.AccountingDate).Name("Accounting Date").TypeConverterOption.Format("dd/MM/yyyy");
            Map(r => r.ConversionDate).Name("Conversion Date").TypeConverterOption.Format("dd/MM/yyyy");
            Map(r => r.Currency).Name("Currency");
            Map(r => r.ConversionRateType).Name("Conversion Rate Type");
            Map(r => r.ConversionRate).Name("Conversion Rate").Default(0);
            Map(r => r.CustomerName).Name("Customer Name");
            Map(r => r.CustomerAccountNumber).Name("Customer Account Number");
            Map(r => r.CustomerSiteNumber).Name("Customer Site Number");
            Map(r => r.InvoiceNumberReference).Name("Invoice number reference");
            Map(r => r.InvoiceAmount).Name("Invoice Amount");
            Map(r => r.Comments).Name("Comments");
        }
    }
}
