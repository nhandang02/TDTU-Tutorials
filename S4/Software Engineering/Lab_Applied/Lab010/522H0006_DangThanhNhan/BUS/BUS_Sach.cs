using System;
using System.Data;
using System.Reflection.Metadata;
using System.Xml.Linq;
using DAL;
using DTO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace BUS
{
    public class BUS_Sach
    {
        private DAL_Sach dalSach;

        public BUS_Sach()
        {
            dalSach = new DAL_Sach();
        }

        public DataTable GetAllSach()
        {
            return dalSach.GetAllSach();
        }

        public void AddSach(DTO_Sach sach)
        {
            dalSach.AddSach(sach);
        }

        public void UpdateSach(DTO_Sach sach)
        {
            dalSach.UpdateSach(sach);
        }

        public void DeleteSach(string maSach)
        {
            dalSach.DeleteSach(maSach);
        }

        public void ExportSachToPDF(DataTable dataTable, string filePath)
        {
            if (dataTable.Rows.Count > 0)
            {
                PdfPTable pdfTable = new PdfPTable(dataTable.Columns.Count);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                // Thêm tiêu đề cột vào PDF
                foreach (DataColumn column in dataTable.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                    pdfTable.AddCell(cell);
                }

                // Thêm dữ liệu vào PDF
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        pdfTable.AddCell(item.ToString());
                    }
                }

                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    // Sử dụng tên đầy đủ cho `Document`
                    iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10f, 20f, 20f, 10f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                }
            }
            else
            {
                throw new Exception("No record to export.");
            }
        }

        public DataTable SearchSach(string keyword)
        {
            return dalSach.SearchSach(keyword);
        }
         
    }
}
