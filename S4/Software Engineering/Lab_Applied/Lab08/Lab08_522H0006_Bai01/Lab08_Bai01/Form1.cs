using BUS;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab08_Bai01
{
    public partial class Form1 : Form
    {
        BUS_Student st;
        int dk = 0;

        public Form1()
        {
            InitializeComponent();
            st = new BUS_Student("", "", "", DateTime.UtcNow, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grd.DataSource = st.SelectQuery();
        }


        private void bADD_Click(object sender, EventArgs e)
        {
            dk = 1;
            txtSID.Text = st.GetStudentID();
        }

        private void bSAVE_Click(object sender, EventArgs e)
        {
            string s = "";
            if (dk == 1)
            {
                // Sử dụng giá trị ngày tháng từ DateTimePicker
                st = new BUS_Student(txtSID.Text, txtFN.Text, txtHT.Text, txtDOB.Value, decimal.Parse(txtGPA.Text));
                st.AddQuery();
            }
            else if (dk == 2)
            {
                // Implement chức năng chỉnh sửa ở đây nếu cần
            }

            grd.DataSource = st.SelectQuery();
        }

        private void bEDIT_Click(object sender, EventArgs e)
        {
            dk = 2;
        }
    }
}
