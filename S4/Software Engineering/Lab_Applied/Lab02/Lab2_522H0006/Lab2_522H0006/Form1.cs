using System.Data.SqlClient;
using System.Data;

namespace Lab2_522H0006
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

        public void showGRD()
        {
            string sql = "select * from student";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        public void enable(GroupBox grp, bool b)
        {
            grp.Enabled = b;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            string s = "initial catalog = InternManage; data source = NHANDANG; integrated security = true";
            //s = "server = <ten sverver>; database = <ten db>; uid = ; pwd = ";

            cn = new SqlConnection(s);
            cn.Open();
            formload();
        }

        private void bADD_Click(object sender, EventArgs e)
        {
            enable(grp1, true);
            txtSID.Clear();
            txtFN.Clear();
            txtGPA.Clear();
            cbHT.Text = "";
            dpDOB.Text = "";

            txtSID.Focus();
            bSAVE.Enabled = true;
            dk = 1;
        }

        private void bCANCEL_Click(object sender, EventArgs e)
        {
            formload();
        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grd_Click(object sender, EventArgs e)
        {
            txtSID.Text = grd.CurrentRow.Cells[0].Value.ToString();
            txtFN.Text = grd.CurrentRow.Cells[1].Value.ToString();
            cbHT.Text = grd.CurrentRow.Cells[2].Value.ToString();
            dpDOB.Text = grd.CurrentRow.Cells[3].Value.ToString();
            txtGPA.Text = grd.CurrentRow.Cells[4].Value.ToString();

            bDEL.Enabled = true;
            bEDIT.Enabled = true;
        }

        private void bDEL_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from student where sid = '" + txtSID.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                formload();
            }
        }

        private void bEDIT_Click(object sender, EventArgs e)
        {
            enable(grp1, true);
            txtSID.Enabled = false;
            txtFN.Focus();
            bSAVE.Enabled = true;

            dk = 2;
        }

        private void bSAVE_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (dk == 1)//Add
            {
                //check primary key
                sql = "select * from student where sid = '" + txtSID.Text + "'";
                data = new SqlDataAdapter(sql, cn);
                tb = new DataTable();
                data.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("Student exists");
                    txtSID.Focus();
                    return;
                }
                //Insert into
                sql = "insert into student values ('" + txtSID.Text + "', N'" + txtFN.Text + "', N'" + cbHT.Text + "', '" + dpDOB.Value.ToShortDateString() + "', '" + txtGPA.Text + "')";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
            }
            else //dk =2
            {
                //Update
                sql = "update student set name = N'" + txtFN.Text + "', Hometown = N'" + cbHT.Text + "', DOB = '" + dpDOB.Value.ToShortDateString() + "', GPA = " + txtGPA.Text + " where SID = '" + txtSID.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
            }
            formload();
        }
    }
}
