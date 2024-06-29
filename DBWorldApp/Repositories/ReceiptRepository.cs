using DBWorldApp.Models;
using DBWorldApp.Services;

namespace DBWorldApp.Repositories
{
    public class ReceiptRepository : IReceiptRepository
    {
        private readonly CsvService _csvService;
        public ReceiptRepository(CsvService csvService)
        {
            _csvService = csvService;
        }
        public List<Receipt> GetAllReceipts()
        {
            return _csvService.ReadCsvFile();
        }
    }
}
