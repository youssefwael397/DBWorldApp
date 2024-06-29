using CsvHelper;
using DBWorldApp.Models;
using System.Globalization;

namespace DBWorldApp.Services
{
    public class CsvService
    {
        private readonly string _csvFilePath = "Files/Receipts.csv";

        public List<Receipt> ReadCsvFile()
        {
            using (var reader = new StreamReader(_csvFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<ReceiptMap>();
                var records = csv.GetRecords<Receipt>().ToList();
                return records;
            }
        }
    }
}
