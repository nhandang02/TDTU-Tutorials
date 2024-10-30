using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using DAL;
using BUS;

namespace Bai01
{
    public partial class Form1 : Form
    {
        int operationType = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudentIDsAndNames();
            
        }

        private void LoadStudentIDsAndNames()
        {
            // Clear ComboBox before loading new data
            cbx1.Items.Clear();

            // Load student IDs and names into ComboBox or ListBox
            DataTable dt = new DAL_Student("", "", "", DateTime.Now, 0).SelectQuery(); 
            foreach (DataRow row in dt.Rows)
            {
                cbx1.Items.Add(row["StudentID"].ToString() + " - " + row["FullName"].ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bAll_Click(object sender, EventArgs e)
        {
            BUS_StudentProject busStudentProject = new BUS_StudentProject("", "", "", 0, 0);
            DataTable dt = busStudentProject.SelectQuery();
            dgv1.DataSource = dt;
        }

        private void PrintToPDF()
        {
            // Create a PDF document
            PdfWriter writer = new PdfWriter("InternshipResults.pdf");
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            // Add a table to the document
            Table table = new Table(4).UseAllAvailableWidth();
            table.AddHeaderCell("Student ID");
            table.AddHeaderCell("Project ID");
            table.AddHeaderCell("Internship Place");
            table.AddHeaderCell("Results");

            // Add data from DataGridView to the table
            foreach (DataGridViewRow row in dgv1.Rows)
            {
                table.AddCell(row.Cells[0].Value.ToString());
                table.AddCell(row.Cells[1].Value.ToString());
                table.AddCell(row.Cells[2].Value.ToString());
                table.AddCell(row.Cells[3].Value.ToString());
            }

            // Add table to the document
            document.Add(table);

            // Close the document
            document.Close();

            MessageBox.Show("Internship results have been printed to InternshipResults.pdf", "Print Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bPRINT_Click(object sender, EventArgs e)
        {
            PrintToPDF();
        }

        private void cbx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStudentID = cbx1.SelectedValue.ToString(); // Lấy ID sinh viên từ ComboBox
            LoadInternshipResults(selectedStudentID);
        }

        private void LoadInternshipResults(string studentID)
        {
            if (!string.IsNullOrEmpty(studentID))
            {
                // Load internship results for the selected student
                BUS_StudentProject busStudentProject = new BUS_StudentProject("", "", "", 0, 0);
                DataTable dt = busStudentProject.GetStudentProjects(studentID);
                dgv1.DataSource = dt;
            }
            else
            {
                // Handle the case where studentID is null or empty
                MessageBox.Show("Please select a student from the list.");
            }
        }
    }
}
