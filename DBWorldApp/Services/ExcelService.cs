using ClosedXML.Excel;
using DBWorldApp.Models;

namespace DBWorldApp.Services
{
    public class ExcelService
    {
        public byte[] DownloadXlsx(List<Receipt> receipts)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Receipts");

                // Add headers
                worksheet.Cell(1, 1).Value = "Business Unit";
                worksheet.Cell(1, 2).Value = "Receipt Method ID";
                worksheet.Cell(1, 3).Value = "Remittance Bank";
                worksheet.Cell(1, 4).Value = "Remittance Bank Account";
                worksheet.Cell(1, 5).Value = "Receipt Number";
                worksheet.Cell(1, 6).Value = "Receipt Amount";
                worksheet.Cell(1, 7).Value = "Receipt Date";
                worksheet.Cell(1, 8).Value = "Accounting Date";
                worksheet.Cell(1, 9).Value = "Conversion Date";
                worksheet.Cell(1, 10).Value = "Currency";
                worksheet.Cell(1, 11).Value = "Conversion Rate Type";
                worksheet.Cell(1, 12).Value = "Conversion Rate";
                worksheet.Cell(1, 13).Value = "Customer Name";
                worksheet.Cell(1, 14).Value = "Customer Account Number";
                worksheet.Cell(1, 15).Value = "Customer Site Number";
                worksheet.Cell(1, 16).Value = "Invoice Number Reference";
                worksheet.Cell(1, 17).Value = "Invoice Amount";
                worksheet.Cell(1, 18).Value = "Comments";

                // Add data
                for (int i = 0; i < receipts.Count; i++)
                {
                    var receipt = receipts[i];
                    worksheet.Cell(i + 2, 1).Value = receipt.BusinessUnit;
                    worksheet.Cell(i + 2, 2).Value = receipt.ReceiptMethodID;
                    worksheet.Cell(i + 2, 3).Value = receipt.RemittanceBank;
                    worksheet.Cell(i + 2, 4).Value = receipt.RemittanceBankAccount;
                    worksheet.Cell(i + 2, 5).Value = receipt.ReceiptNumber;
                    worksheet.Cell(i + 2, 6).Value = receipt.ReceiptAmount;
                    worksheet.Cell(i + 2, 7).Value = receipt.ReceiptDate.ToString("MM/dd/yyyy"); // Example date formatting
                    worksheet.Cell(i + 2, 8).Value = receipt.AccountingDate.ToString("MM/dd/yyyy");
                    worksheet.Cell(i + 2, 9).Value = receipt.ConversionDate.ToString("MM/dd/yyyy");
                    worksheet.Cell(i + 2, 10).Value = receipt.Currency;
                    worksheet.Cell(i + 2, 11).Value = receipt.ConversionRateType;
                    worksheet.Cell(i + 2, 12).Value = receipt.ConversionRate;
                    worksheet.Cell(i + 2, 13).Value = receipt.CustomerName;
                    worksheet.Cell(i + 2, 14).Value = receipt.CustomerAccountNumber;
                    worksheet.Cell(i + 2, 15).Value = receipt.CustomerSiteNumber;
                    worksheet.Cell(i + 2, 16).Value = receipt.InvoiceNumberReference;
                    worksheet.Cell(i + 2, 17).Value = receipt.InvoiceAmount;
                    worksheet.Cell(i + 2, 18).Value = receipt.Comments;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    return stream.ToArray();
                }
            }
        }
    }
}
