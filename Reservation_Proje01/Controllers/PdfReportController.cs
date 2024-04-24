using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;

namespace Reservation_Proje01.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfReport() 
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "dosya1.pdf");

            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            Paragraph paragraph = new Paragraph("Meeting Room PDF Raporu");  

            document.Add(paragraph);
            document.Close();

            return File("/PdfReports/dosya1.pdf", "application/pdf", "dosya1.pdf");
        }

        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "dosya.pdf");
            string Arial_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.ttf");

            BaseFont bf = BaseFont.CreateFont(Arial_TFF, BaseFont.IDENTITY_H, true);
            Font f = new Font(bf, 12, Font.NORMAL);

            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            Paragraph paragraph = new Paragraph("\t\t\t\tTraversal - Statik Müşteri Raporu\n\n", f);
            PdfPTable table = new PdfPTable(3);

            table.AddCell(new Phrase("Misafir Adı",f));
            table.AddCell(new Phrase("Misafir SoyAdı",f));
            table.AddCell(new Phrase("Misafir TC", f));

            table.AddCell(new Phrase("Çekdar", f));
            table.AddCell(new Phrase("Çapar", f));
            table.AddCell(new Phrase("11111111110", f));

            table.AddCell(new Phrase("Aslı", f));
            table.AddCell(new Phrase("Yılmaz", f));
            table.AddCell(new Phrase("11123411110", f));

            table.AddCell(new Phrase("Eylül", f));
            table.AddCell(new Phrase("Yüce", f));
            table.AddCell(new Phrase("44551111110", f));

            document.Add(paragraph);
            document.Add(table);
            document.Close();

            return File("/PdfReports/dosya.pdf", "application/pdf", "dosya.pdf");
        }
    }
}
