using DBWorldApp.Models;
using DBWorldApp.Repositories;
using DBWorldApp.Services;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace DBWorldApp.Controllers
{
    public class ReceiptsController : Controller
    {
        private readonly IReceiptRepository _receiptRepository;
        private readonly ExcelService _excelService;
        public ReceiptsController(IReceiptRepository receiptRepository, ExcelService excelService)
        {
            _receiptRepository = receiptRepository;
            _excelService = excelService;
        }
        public IActionResult Index(int? page)
        {
            int pageSize = 10;
            int pageNumber = page ?? 1;

            var receipts = _receiptRepository.GetAllReceipts().ToPagedList(pageNumber, pageSize);

            return View(receipts);
        }

        public IActionResult ExportToExcel()
        {
            List<Receipt> receipts = _receiptRepository.GetAllReceipts();
            Byte[] receiptBytes = _excelService.DownloadXlsx(receipts);
            return File(receiptBytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Receipts.xlsx");

        }
    }
}
