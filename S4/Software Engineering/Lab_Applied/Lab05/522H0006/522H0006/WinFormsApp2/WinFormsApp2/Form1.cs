    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Data.SqlClient;
    using iTextSharp.text.pdf;
    using iTextSharp.text;
    using System.IO;
    using System.Drawing.Printing;
    using System.Xml.Linq;

    namespace WinFormsApp2
    {
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        int dk = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string s = "initial catalog = Library; data source = NhanDang76E7; integrated security = true";
            //s = "server = <ten sverver>; database = <ten db>; uid = ; pwd = ";

            cn = new SqlConnection(s);
            cn.Open();
            formload();
        }

        void formload()
        {
            showGRD();
            enable(grp1, false);
            bDEL.Enabled = false;
            bEDIT.Enabled = false;
            bSAVE.Enabled = false;
            dk = 0;
        }

        public void enable(GroupBox grp, bool b)
        {
            grp.Enabled = b;
        }

        public void showGRD()
        {
            string sql = "select * from Sach";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        private void bADD_Click(object sender, EventArgs e)
        {
            enable(grp1, true);
            txtBID.Clear();
            txtBN.Clear();
            txtQuan.Clear();
            txtAu.Clear();

            txtBID.Focus();
            bSAVE.Enabled = true;
            dk = 1;
        }

        private void bDEL_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Delete?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string checkSql = "SELECT COUNT(*) FROM CTPM WHERE Masach = '" + txtBID.Text + "'";
                SqlCommand checkCmd = new SqlCommand(checkSql, cn);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Cannot delete. There are related records in CTPM.");
                }
                else
                {
                    string deleteSql = "DELETE FROM Sach WHERE Masach = '" + txtBID.Text + "'";
                    SqlCommand deleteCmd = new SqlCommand(deleteSql, cn);
                    deleteCmd.ExecuteNonQuery();
                }
            }
        }

        private void bEDIT_Click(object sender, EventArgs e)
        {
            enable(grp1, true);
            txtBID.Enabled = false;
            txtBN.Focus();
            bSAVE.Enabled = true;

            dk = 2;
        }

        private void bSAVE_Click(object sender, EventArgs e)
        {
            string sql = "";

            if (dk == 1)
            {
                if (txtBID.Text == "")
                {
                    MessageBox.Show("Please enter book ID");
                    return;
                }


                sql = "SELECT * FROM Sach WHERE Masach = '" + txtBID.Text + "'";
                data = new SqlDataAdapter(sql, cn);
                tb = new DataTable();
                data.Fill(tb);

                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("Book ID already exists");
                    txtBID.Focus();
                    return;
                }


                sql = "INSERT INTO Sach VALUES ('" + txtBID.Text + "', N'" + txtBN.Text + "', N'" + txtAu.Text + "', " + txtQuan.Text + ")";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
            }
            else if (dk == 2)
            {
                if (txtBID.Text == "")
                {
                    MessageBox.Show("Please select a book to edit");
                    return;
                }

                sql = "UPDATE Sach SET Tensach = N'" + txtBN.Text + "', Tacgia = N'" + txtAu.Text + "', Soluong = " + txtQuan.Text + " WHERE Masach = '" + txtBID.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
            }


            formload();
        }


        private void grd_Click(object sender, EventArgs e)
        {
            txtBID.Text = grd.CurrentRow.Cells[0].Value.ToString();
            txtBN.Text = grd.CurrentRow.Cells[1].Value.ToString();
            txtAu.Text = grd.CurrentRow.Cells[2].Value.ToString();
            txtQuan.Text = grd.CurrentRow.Cells[3].Value.ToString();

            bDEL.Enabled = true;
            bEDIT.Enabled = true;
        }

        private void bCANCEL_Click(object sender, EventArgs e)
        {
            formload();
        }

        private void bPDF_Click(object sender, EventArgs e)
        {
            if (grd.Rows.Count - 1 > 0)
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
                            PdfPTable pdfTable = new PdfPTable(grd.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            //add column
                            foreach (DataGridViewColumn column in grd.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            //add value
                            for (int i = 0; i < grd.Rows.Count - 1; ++i)
                            {
                                for (int j = 0; j < grd.Columns.Count; ++j)
                                {
                                    // string s = grd.Rows[i].Cells[j].Value.ToString();
                                    pdfTable.AddCell(grd.Rows[i].Cells[j].Value.ToString());

                                }
                            }

                            /*
                            foreach (DataGridViewRow row in grd.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }
                            */
                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                            // Application.Run(sfd.FileName);
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

        private void bFind_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFind.Text))
            {
                string searchValue = txtFind.Text.Trim();
                string sql = "SELECT * FROM Sach WHERE Masach LIKE '%" + searchValue + "%'";

                data = new SqlDataAdapter(sql, cn);
                tb = new DataTable();
                data.Fill(tb);

                if (tb.Rows.Count > 0)
                {
                    grd.DataSource = tb;
                    MessageBox.Show("Data found successfully!", "Info");
                }
                else
                {
                    MessageBox.Show("No matching records found!", "Info");
                }
            }
            else
            {
                MessageBox.Show("Please enter a search value!", "Info");
            }
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BMUON_Click(object sender, EventArgs e)
        {
      
            if (string.IsNullOrWhiteSpace(maSachMuon.Text) || string.IsNullOrWhiteSpace(maDGMuon.Text) ||
                string.IsNullOrWhiteSpace(ngayMuon.Text) || string.IsNullOrWhiteSpace(ngayTRA.Text))
            {
                MessageBox.Show("Please enter complete information!");
                return;
            }

            if (ngayTRA.Value < ngayMuon.Value)
            {
                MessageBox.Show("The return date must be greater than or equal to the borrow date!");
                return;
            }

         
            DateTime a = ngayMuon.Value;
            string aAsString = a.ToString("yyyyMMdd");
            string maPhieuMuon = TaoMaPhieuMoi(aAsString);

          
            string insertMuonSachSql = "INSERT INTO MuonSach (Maphieumuon, Madocgia, Ngaymuon) " +
                                       "VALUES (@Maphieumuon, @Madocgia, @Ngaymuon)";
            cm = new SqlCommand(insertMuonSachSql, cn);
            cm.Parameters.AddWithValue("@MaPhieuMuon", maPhieuMuon);
            cm.Parameters.AddWithValue("@MaDocGia", maDGMuon.Text);
            cm.Parameters.AddWithValue("@NgayMuon", ngayMuon.Value);

           
            cm.ExecuteNonQuery();

            string insertChiTietPhieuMuonSql = "INSERT INTO ChiTietPhieuMuon (Maphieumuon, Masach, Ngaytra) " +
                                       "VALUES (@Maphieumuon, @Masach, @Ngaytra)";
            cm = new SqlCommand(insertChiTietPhieuMuonSql, cn);
            cm.Parameters.AddWithValue("@Maphieumuon", maPhieuMuon);
            cm.Parameters.AddWithValue("@Masach", maSachMuon.Text);
            cm.Parameters.AddWithValue("@Ngaytra", ngayTRA.Value);

         
            cm.ExecuteNonQuery();

            MessageBox.Show("Thêm thông tin mượn sách thành công!");
            
            formload();
        }

        private string TaoMaPhieuMoi(string dayy)
        {
            string maPhieuMoi = "";

            // Lấy số cao nhất từ cơ sở dữ liệu
            string query = "SELECT MAX(CAST(SUBSTRING(Maphieumuon, LEN(Maphieumuon) - 2, 3) AS INT)) FROM MuonSach";

            using (SqlCommand command = new SqlCommand(query, cn))
            {
                object result = command.ExecuteScalar();

                int maxId = result == DBNull.Value ? 0 : Convert.ToInt32(result);

                maPhieuMoi = dayy + "-" + (maxId + 1).ToString("D3");
            }

            return maPhieuMoi;
        }

        private void SHOW_Click(object sender, EventArgs e)
        {
            string sql = "select * from Sach";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd2.DataSource = tb;
        }

        private void CHITIET_Click(object sender, EventArgs e)
        {
            string sql = "select * from ChiTietPhieuMuon";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd2.DataSource = tb;
        }
    }
}
