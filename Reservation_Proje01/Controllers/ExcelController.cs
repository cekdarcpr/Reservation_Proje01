using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Reservation_Proje01.Models;

namespace Reservation_Proje01.Controllers
{
    public class ExcelController : Controller
    {
        public IActionResult Index()
        {
           return View();
        }

        public List<DestinationModel> DestinationList()
        {
            List<DestinationModel> destinationModels = new List<DestinationModel>();
            using (var c = new Context())
            {
                destinationModels = c.Destinations.Select(x => new DestinationModel
                {
                    city = x.City,
                    dayNight = x.DayNight,
                    price = x.Price,
                    capacity = x.Capacity
                }).ToList();
            }
            return destinationModels;
        }

        public IActionResult StaticExcelReport()
        {
            ExcelPackage excel = new ExcelPackage();
            var workSheet = excel.Workbook.Worksheets.Add("Sayfa1");

            workSheet.Cells[1, 1].Value = "Oda";
            workSheet.Cells[1, 2].Value = "Rehber";
            workSheet.Cells[1, 3].Value = "Konteyjan";

            workSheet.Cells[2, 1].Value = "Bursa";
            workSheet.Cells[2, 2].Value = "Zeynep Öztürk";
            workSheet.Cells[2, 3].Value = "23";

            workSheet.Cells[3, 1].Value = "Antalya";
            workSheet.Cells[3, 2].Value = "Mehmet Ceylan";
            workSheet.Cells[3, 3].Value = "43";

            var bytes = excel.GetAsByteArray();
            return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Static.xlsx");
        }

        public IActionResult DestinationExcelReport()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Oda Listesi");
                workSheet.Cell(1, 1).Value = "Şehir";
                workSheet.Cell(1, 2).Value = "Konaklama Süresi";
                workSheet.Cell(1, 3).Value = "Fiyat";
                workSheet.Cell(1, 4).Value = "Kapasite";

                int rowCount = 2;
                foreach (var item in DestinationList())
                {
                    workSheet.Cell(rowCount, 1).Value = item.city;
                    workSheet.Cell(rowCount, 2).Value = item.dayNight;
                    workSheet.Cell(rowCount, 3).Value = item.price;
                    workSheet.Cell(rowCount, 4).Value = item.capacity;
                    rowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "YeniListe.xlsx");
                }
            }
        }
    }
}
