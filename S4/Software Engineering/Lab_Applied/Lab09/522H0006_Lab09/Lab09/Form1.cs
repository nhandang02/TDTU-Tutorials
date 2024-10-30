using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace Lab09
{
    public partial class Form1 : Form
    {

        BUS_StudentProject l;
        int dk = 0;

        public void enable(GroupBox grp, bool b)
        {
            grp.Enabled = b;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            l = new BUS_StudentProject("", "", "", "", 0, 0);

            DataTable dataTable = l.SelectAllStudentProject();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    cbSID.Items.Add(row["StudentID"].ToString());
                    cbName.Items.Add(row["FullName"].ToString());
                }  
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbSID.Text = grd.CurrentRow.Cells[0].Value.ToString();
            txtProjectID.Text = grd.CurrentRow.Cells[1].Value.ToString();
            txtIP.Text = grd.CurrentRow.Cells[2].Value.ToString();
            txtDistance.Text = grd.CurrentRow.Cells[3].Value.ToString();
            txtResult.Text = grd.CurrentRow.Cells[4].Value.ToString();
            cbName.Text = grd.CurrentRow.Cells[5].Value.ToString();
        }

        private void bALL_Click(object sender, EventArgs e)
        {
            l = new BUS_StudentProject("SV001","", "Full Name", "Hometown", 1, 0);
            grd.DataSource = l.SelectAllStudentProject();

        }

        private void bPRINT_Click(object sender, EventArgs e)
        {
            if (grd.Rows.Count  > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            Paragraph title = new Paragraph("Student Projects", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD));
                            title.Alignment = Element.ALIGN_CENTER;
                            title.SpacingAfter = 10;

                            iTextSharp.text.pdf.PdfPTable pdfTable = new iTextSharp.text.pdf.PdfPTable(grd.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                            pdfTable.WidthPercentage = 90;

                            // Add columns
                            foreach (DataGridViewColumn column in grd.Columns)
                            {
                                PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD)));
                                headerCell.BackgroundColor = new BaseColor(240, 240, 240); 
                                headerCell.HorizontalAlignment = Element.ALIGN_CENTER; 
                                pdfTable.AddCell(headerCell); ;
                            }

                            // Add values
                            foreach (DataGridViewCell cell in grd.CurrentRow.Cells)
                            {
                                PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10)));

                                pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;

                                pdfTable.AddCell(pdfCell);
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 10f, 20f, 20f, 10f);
                                iTextSharp.text.pdf.PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();

                                pdfDoc.Add(title);

                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }


                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void cbSID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStudentID = cbSID.SelectedItem.ToString();
            l = new BUS_StudentProject("SV001", "", "Full Name", "Hometown", 1, 0);

            grd.DataSource = l.SelectStudentProjectByID(selectedStudentID);

            DataTable dataTable = l.SelectStudentProjectByID(selectedStudentID);
            cbName.Items.Clear(); 
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    cbName.Items.Add(row["FullName"].ToString());
                }
                cbName.SelectedIndex = 0;
            }

        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}