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
using System.IO;
using System.Drawing.Printing;
using System.Xml.Linq;

namespace Lab7
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
            string s = "initial catalog = CourseRegis; data source = NHANDANG76E7; integrated security = true";
            //s = "server = <ten sverver>; database = <ten db>; uid = ; pwd = ";

            cn = new SqlConnection(s);
            cn.Open();
            formload();
        }


        private void grd_Click(object sender, EventArgs e)
        {
            txtMK.Text = grd.CurrentRow.Cells[0].Value.ToString();
            txtTK.Text = grd.CurrentRow.Cells[1].Value.ToString();
            txtDD.Text = grd.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = grd.CurrentRow.Cells[3].Value.ToString();

            bDEL.Enabled = true;
            bEDIT.Enabled = true;
        }

        void formload()
        {
            enable(grp1, false);
            bDEL.Enabled = false;
            bEDIT.Enabled = false;
            bSAVE.Enabled = false;
            dk = 0;
            htKhoa();
            htGRD();
        }

        public void enable(GroupBox grp, bool b)
        {
            grp.Enabled = b;
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bADD_Click(object sender, EventArgs e)
        {
            enable(grp1, true);
            txtMK.Clear();
            txtTK.Clear();
            txtDD.Clear();
            txtSDT.Clear();

            txtMK.Enabled = false;
            txtTK.Focus();
            bSAVE.Enabled = true;
            dk = 1;
            txtMK.Text = genMS(cbKhoa.SelectedValue.ToString());
        }

        private void bDEL_Click(object sender, EventArgs e)
        {

        }

        private void bCANCEL_Click(object sender, EventArgs e)
        {
            formload();
        }


        private void cbHT_SelectedIndexChanged(object sender, EventArgs e)
        {
            htGRD();
        }

        void htGRD()
        {
            string s = "select * from sinhvien where makhoa = '" + cbKhoa.SelectedValue.ToString() + "'";//cbkhoa.text
            data = new SqlDataAdapter(s, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        void htKhoa()
        {
            string s = "select * from khoa";
            data = new SqlDataAdapter(s, cn);
            tb = new DataTable();
            data.Fill(tb);
            cbKhoa.DataSource = tb;
            cbKhoa.DisplayMember = "tenkhoa";
            cbKhoa.ValueMember = "makhoa";
        }

        public string genMS(string khoa)
        {
            string s = "select top 1 masv from sinhvien where makhoa = '" + cbKhoa.SelectedValue.ToString() + "' order by masv desc";
            data = new SqlDataAdapter(s, cn);
            tb = new DataTable();
            data.Fill(tb);
            if (tb.Rows.Count > 0)
            {
                s = tb.Rows[0][0].ToString();
                s = s.Substring(s.Length - 2, 2);//0005
                int stt = int.Parse(s) + 1;
                if (stt < 10)
                    s = khoa + "000" + stt.ToString();
                else if (stt < 100)
                    s = khoa + "00" + stt.ToString();
                else if (stt < 1000)
                    s = khoa + "0" + stt.ToString();
                else
                    s = khoa + stt.ToString();

            }
            else
                s = khoa + "0001";

            return s;
        }






        private void grp3_Enter(object sender, EventArgs e)
        {

        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bSAVE_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}