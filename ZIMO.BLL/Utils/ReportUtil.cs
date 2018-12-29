using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZIMO.Entities.Concretes;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ZIMO.BLL.Utils
{
    internal class ReportUtil
    {
        /// <summary>
        /// Creates Reports for only one person
        /// </summary>
        /// <param name="user">User Object</param>
        public static void CreateReport(User user)
        {
            FileStream fs =
                new FileStream(
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "\\Assets\\Reports",
                        "Borrow_Report_" + Guid.NewGuid() + ".pdf"), FileMode.Create);
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 25, 25, 15, 15);
            GetReportHeader(fs, document, "Employee");

            GetReportBody(document, user, -1);

            GetReportFooter(document);
        }

        /// <summary>
        /// Creates Report for People who are part of a department
        /// </summary>
        /// <param name="users"></param>
        public static void CreateReport(IList<User> users)
        {
            FileStream fs =
                new FileStream(
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "\\Assets\\Reports",
                        "Department_Borrow_Report_" + Guid.NewGuid() + ".pdf"), FileMode.Create);
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 50, 50, 15, 15);
            GetReportHeader(fs, document, users.ElementAt(0).Department.Name + " Department ");

            int counter = 0;
            foreach (var user in users.OrderByDescending(x => x.Borrows.Count))
            {

                counter++;
                GetReportBody(document, user, counter);
            }

            GetReportFooter(document);
        }

        private static void GetReportHeader(FileStream fs, Document document, string documentName)
        {
            // Setup Header Visual Insturments
            PdfWriter pw = PdfWriter.GetInstance(document, fs);
            document.Open();
            // Add Document Title
            document.AddTitle(documentName + " Borrow Report");
            BaseColor logoBaseColor = new BaseColor(11, 82, 148);
            Font logoFont = FontFactory.GetFont("Arial", 28, 1, logoBaseColor);
            Paragraph title = new Paragraph(documentName + " Borrows Report",
                FontFactory.GetFont("Calibri", 26, logoBaseColor));
            title.Alignment = Element.ALIGN_CENTER;
            title.SpacingAfter = 20;
            // Date Info
            Paragraph dateParagraph = new Paragraph("Date: " + DateTime.Now.ToShortDateString());
            dateParagraph.Alignment = Element.ALIGN_RIGHT;
            dateParagraph.IndentationRight = 10;
            // ZIMO Logo Info
            Paragraph logoParagraph = new Paragraph("ZIMO", logoFont);
            logoParagraph.Alignment = Element.ALIGN_RIGHT;
            logoParagraph.IndentationRight = 10;
            dateParagraph.SpacingAfter = 5;

            document.Add(title);
            document.Add(logoParagraph);
            document.Add(dateParagraph);
        }

        private static void GetReportBody(Document document, User user, int counter)
        {
            // Setup Body Visual Insturments
            // User Info
            Font subtitleFont = FontFactory.GetFont("Arial", 12, 1);
            BaseColor lineBaseColor = new BaseColor(11, 82, 148);
            Paragraph p =
                new Paragraph(new Chunk(
                    new iTextSharp.text.pdf.draw.LineSeparator(2F, 100.0F, lineBaseColor, Element.ALIGN_LEFT, 1)));
            document.Add(p);
            if (counter == -1)
                document.Add(new Paragraph("Employee Information", subtitleFont) {IndentationLeft = 15});
            else
                document.Add(new Paragraph(counter + " - Employee Information", subtitleFont) {IndentationLeft = 15});

            document.Add(new Paragraph("First Name: " + user.Employee.FirstName) {IndentationLeft = 20});
            document.Add(new Paragraph("Last Name: " + user.Employee.LastName) {IndentationLeft = 20});
            document.Add(new Paragraph("Department: " + user.Department.Name) {IndentationLeft = 20});
            document.Add(new Paragraph("Role: " + user.Role.Name) {IndentationLeft = 20});

            // Borrows Table 
            BaseColor headerBaseColor = new BaseColor(137, 222, 255);
            PdfPTable borrowTable = new PdfPTable(6);
            borrowTable.SpacingBefore = 20;
            borrowTable.WidthPercentage = 100f;

            // Table Headers
            borrowTable.AddCell(new PdfPCell(new Phrase("Item Name")) {BackgroundColor = headerBaseColor});
            borrowTable.AddCell(new PdfPCell(new Phrase("Quantity")) {BackgroundColor = headerBaseColor});
            borrowTable.AddCell(new PdfPCell(new Phrase("Company Name")) {BackgroundColor = headerBaseColor});
            borrowTable.AddCell(new PdfPCell(new Phrase("Borrow Time")) {BackgroundColor = headerBaseColor});
            borrowTable.AddCell(new PdfPCell(new Phrase("Return Time")) {BackgroundColor = headerBaseColor});
            borrowTable.AddCell(new PdfPCell(new Phrase("Is Return")) {BackgroundColor = headerBaseColor});

            // Table Values
            List<Borrow> borrowList = user.Borrows.ToList();
            foreach (var borrow in borrowList)
            {
                borrowTable.AddCell(new PdfPCell(new Phrase(borrow.Item.Name))
                    {HorizontalAlignment = 1, VerticalAlignment = 1});
                borrowTable.AddCell(new PdfPCell(new Phrase(borrow.Quantity.ToString()))
                    {HorizontalAlignment = 1, VerticalAlignment = 1});
                borrowTable.AddCell(new PdfPCell(new Phrase(borrow.Stock.CompanyName))
                    {HorizontalAlignment = 1, VerticalAlignment = 1});
                borrowTable.AddCell(new PdfPCell(new Phrase(borrow.BorrowTime.ToShortDateString()))
                    {HorizontalAlignment = 1, VerticalAlignment = 1});
                if (borrow.ReturnTime == null)
                    borrowTable.AddCell(new PdfPCell(new Phrase("-")) {HorizontalAlignment = 1, VerticalAlignment = 1});
                else
                    borrowTable.AddCell(
                        new PdfPCell(new Phrase(Convert.ToDateTime(borrow.ReturnTime).ToShortDateString()))
                            {HorizontalAlignment = 1, VerticalAlignment = 1});

                borrowTable.AddCell(new PdfPCell(new Phrase(borrow.IsReturn.ToString()))
                    {HorizontalAlignment = 1, VerticalAlignment = 1});
            }

            document.Add(borrowTable);
        }

        private static void GetReportFooter(Document document)
        {
            // Setup Footer Visual Instruments
            BaseColor lineBaseColor = new BaseColor(11, 82, 148);
            Paragraph p =
                new Paragraph(new Chunk(
                    new iTextSharp.text.pdf.draw.LineSeparator(2F, 100.0F, lineBaseColor, Element.ALIGN_LEFT, 1)));
            document.Add(p);

            document.Close();
        }
    }
}
