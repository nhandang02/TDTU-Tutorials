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
            string sql = "select * from Khoa";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
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
        }

        private void bDEL_Click(object sender, EventArgs e)
        {

        }

        private void bCANCEL_Click(object sender, EventArgs e)
        {
            formload();
        }

        private void txtTK_Leave(object sender, EventArgs e)
        {
            {
                string[] t = txtTK.Text.Split(' ');
                string res = "";
                for (int i = 0; i < t.Length; ++i)
                    res = res + t[i].Substring(0, 1);

                txtMK.Text = res;
            }
        }

        private void grp1_Enter(object sender, EventArgs e)
        {

        }
    }
}