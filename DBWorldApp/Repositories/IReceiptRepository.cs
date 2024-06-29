using DBWorldApp.Models;

namespace DBWorldApp.Repositories
{
    public interface IReceiptRepository
    {
        List<Receipt> GetAllReceipts();
    }
}
