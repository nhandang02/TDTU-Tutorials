using BUS;
using System;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        BUS_Student studentBUS;
        int operationType = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentBUS = new BUS_Student("", "", "", DateTime.Now, 0);
            grd.DataSource = studentBUS.SelectQuery();
        }

        private void bADD_Click(object sender, EventArgs e)
        {
            operationType = 1;
            txtSID.Text = studentBUS.GetStudentID();
        }

        private void bEDIT_Click(object sender, EventArgs e)
        {
            operationType = 2;
        }

        private void bSAVE_Click(object sender, EventArgs e)
        {
            if (operationType == 1)
            {
                // S? d?ng giá tr? ngày tháng t? DateTimePicker
                studentBUS = new BUS_Student(txtSID.Text, txtFN.Text, txtHT.Text, txtDOB.Value, decimal.Parse(txtGPA.Text));
                studentBUS.AddQuery();
            }
            else if (operationType == 2)
            {
                // Implement ch?c n?ng ch?nh s?a ? ?ây n?u c?n
            }

            grd.DataSource = studentBUS.SelectQuery();
            
        }
    }
}
