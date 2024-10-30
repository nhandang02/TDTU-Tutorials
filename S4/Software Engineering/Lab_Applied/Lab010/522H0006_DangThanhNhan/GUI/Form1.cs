using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class Form1 : Form
    {
        private BUS_Sach busSach;
        private int dk;

        public Form1()
        {
            InitializeComponent();
            busSach = new BUS_Sach();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formload();
        }

        void formload()
        {
            ShowSach();
            EnableControls(false);
            BXOA.Enabled = false;
            BSUA.Enabled = false;
            BLUU.Enabled = false;
            dk = 0;
        }

        public void EnableControls(bool enable)
        {
            grp1.Enabled = enable;
        }

        public void ShowSach()
        {
            grd1.DataSource = busSach.GetAllSach();
        }

        private void BTHEM_Click(object sender, EventArgs e)
        {
            EnableControls(true);
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtMaSach.Focus();
            BLUU.Enabled = true;
            dk = 1;
        }

        private void BXOA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string maSach = txtMaSach.Text;
                busSach.DeleteSach(maSach);
                MessageBox.Show("Deleted successfully!");
                ShowSach();
            }
        }

        private void BSUA_Click(object sender, EventArgs e)
        {
            EnableControls(true);
            txtMaSach.Enabled = false;
            txtTenSach.Enabled = true;
            txtTacGia.Enabled = true;
            txtSoLuong.Enabled = true;
            BLUU.Enabled = true;
            dk = 2;
        }

        private void BLUU_Click(object sender, EventArgs e)
        {
            if (dk == 1) // Add
            {
                DTO_Sach newSach = new DTO_Sach(
                    txtMaSach.Text,
                    txtTenSach.Text,
                    txtTacGia.Text,
                    int.Parse(txtSoLuong.Text)
                );

                busSach.AddSach(newSach);
                MessageBox.Show("Added successfully!");
                ShowSach();
            }
            else if (dk == 2) // Edit
            {
                DTO_Sach updatedSach = new DTO_Sach(
                    txtMaSach.Text,
                    txtTenSach.Text,
                    txtTacGia.Text,
                    int.Parse(txtSoLuong.Text)
                );

                busSach.UpdateSach(updatedSach);
                MessageBox.Show("Updated successfully!");
                ShowSach();
            }

            EnableControls(false);
        }

        private void grd1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaSach.Text = grd1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenSach.Text = grd1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTacGia.Text = grd1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSoLuong.Text = grd1.Rows[e.RowIndex].Cells[3].Value.ToString();

                BSUA.Enabled = true;
                BXOA.Enabled = true;
            }
        }

        private void BIN_Click(object sender, EventArgs e)
        {
            if (grd1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DataTable data = (DataTable)grd1.DataSource;
                        busSach.ExportSachToPDF(data, sfd.FileName);
                        MessageBox.Show("Data exported successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while exporting to PDF: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No record to export.");
            }
        }

        private void BTIM_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTIM.Text))
            {
                DataTable searchResults = busSach.SearchSach(txtTIM.Text.Trim());

                if (searchResults.Rows.Count == 0)
                {
                    MessageBox.Show("Ma sach khong ton tai");
                }
                else
                {
                    grd1.DataSource = searchResults;
                    MessageBox.Show("Tim thanh cong");
                }
            }
            else
            {
                MessageBox.Show("Vui long nhap ma sach");
            }
        }

        private void SHOW_Click(object sender, EventArgs e)
        {
            grd2.DataSource = BUS_MuonSach.GetMuonSach();
        }

        private void CHITIET_Click(object sender, EventArgs e)
        {
            grd2.DataSource = BUS_ChiTietPhieuMuon.GetChiTietPhieuMuon();
        }

        private void BMUON_Click(object sender, EventArgs e)
        {
            // Ki?m tra xem ng??i d�ng ?� nh?p ?? th�ng tin ch?a
            if (string.IsNullOrWhiteSpace(maDGMuon.Text) ||
                string.IsNullOrWhiteSpace(maSachMuon.Text))
            {
                MessageBox.Show("Vui l�ng nh?p m� ??c gi? v� m� s�ch!");
                return;
            }

            if (ngayTRA.Value < ngayMuon.Value)
            {
                MessageBox.Show("Ng�y tr? ph?i l?n h?n ho?c b?ng ng�y m??n!");
                return;
            }

            // T?o m� phi?u m??n m?i
            string maPhieuMuon = BUS_MuonSach.GenerateMaPhieuMuon(ngayMuon.Value.ToString("yyyyMMdd"));

            // T?o DTO cho MuonSach v� ChiTietPhieuMuon
            DTO_MuonSach muonSach = new DTO_MuonSach
            {
                MaPhieuMuon = maPhieuMuon,
                MaDocGia = txtMaDocGia.Text,
                NgayMuon = dtpNgayMuon.Value
            };

            DTO_ChiTietPhieuMuon chiTietPhieuMuon = new DTO_ChiTietPhieuMuon
            {
                MaPhieuMuon = maPhieuMuon,
                MaSach = txtMaSachMuon.Text,
                NgayTra = dtpNgayTra.Value
            };

            try
            {
                // Th�m th�ng tin phi?u m??n v� chi ti?t phi?u m??n th�ng qua BUS
                BUS_MuonSach.AddMuonSach(muonSach);
                BUS_ChiTietPhieuMuon.AddChiTietPhieuMuon(chiTietPhieuMuon);

                MessageBox.Show("Th�m phi?u m??n th�nh c�ng!");

                // C?p nh?t l?i d? li?u hi?n th? sau khi th�m th�nh c�ng
                grd2.DataSource = BUS_MuonSach.GetMuonSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"L?i khi th�m phi?u m??n: {ex.Message}");
            }
        }
    }
}
