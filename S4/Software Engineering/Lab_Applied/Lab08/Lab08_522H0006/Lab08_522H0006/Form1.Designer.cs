namespace Lab08_522H0006
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bEdit = new Button();
            bAdd = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtSup = new TextBox();
            txtFun = new TextBox();
            bPrint = new Button();
            bCancel = new Button();
            bSave = new Button();
            txtName = new TextBox();
            txtPID = new TextBox();
            bDel = new Button();
            grd = new DataGridView();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // bEdit
            // 
            bEdit.Location = new Point(505, 42);
            bEdit.Margin = new Padding(5);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(153, 46);
            bEdit.TabIndex = 4;
            bEdit.Text = "Edit";
            bEdit.UseVisualStyleBackColor = true;
            bEdit.Click += bEdit_Click;
            // 
            // bAdd
            // 
            bAdd.Location = new Point(141, 42);
            bAdd.Margin = new Padding(5);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(153, 46);
            bAdd.TabIndex = 2;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(642, 135);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 32);
            label4.TabIndex = 7;
            label4.Text = "Funding";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 135);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 32);
            label3.TabIndex = 6;
            label3.Text = "Supervisor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(642, 55);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 55);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 32);
            label1.TabIndex = 4;
            label1.Text = "ProjectID";
            // 
            // txtSup
            // 
            txtSup.Location = new Point(184, 122);
            txtSup.Margin = new Padding(5);
            txtSup.Name = "txtSup";
            txtSup.Size = new Size(313, 39);
            txtSup.TabIndex = 3;
            // 
            // txtFun
            // 
            txtFun.Location = new Point(754, 122);
            txtFun.Margin = new Padding(5);
            txtFun.Name = "txtFun";
            txtFun.Size = new Size(480, 39);
            txtFun.TabIndex = 2;
            // 
            // bPrint
            // 
            bPrint.Location = new Point(1050, 42);
            bPrint.Margin = new Padding(5);
            bPrint.Name = "bPrint";
            bPrint.Size = new Size(187, 46);
            bPrint.TabIndex = 3;
            bPrint.Text = "PrintPreview";
            bPrint.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            bCancel.Location = new Point(871, 42);
            bCancel.Margin = new Padding(5);
            bCancel.Name = "bCancel";
            bCancel.Size = new Size(153, 46);
            bCancel.TabIndex = 3;
            bCancel.Text = "Cancel";
            bCancel.UseVisualStyleBackColor = true;
            // 
            // bSave
            // 
            bSave.Location = new Point(686, 42);
            bSave.Margin = new Padding(5);
            bSave.Name = "bSave";
            bSave.Size = new Size(153, 46);
            bSave.TabIndex = 3;
            bSave.Text = "Save";
            bSave.UseVisualStyleBackColor = true;
            bSave.Click += bSave_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(754, 42);
            txtName.Margin = new Padding(5);
            txtName.Name = "txtName";
            txtName.Size = new Size(480, 39);
            txtName.TabIndex = 1;
            // 
            // txtPID
            // 
            txtPID.Location = new Point(184, 42);
            txtPID.Margin = new Padding(5);
            txtPID.Name = "txtPID";
            txtPID.Size = new Size(313, 39);
            txtPID.TabIndex = 0;
            // 
            // bDel
            // 
            bDel.Location = new Point(322, 42);
            bDel.Margin = new Padding(5);
            bDel.Name = "bDel";
            bDel.Size = new Size(153, 46);
            bDel.TabIndex = 3;
            bDel.Text = "Delete";
            bDel.UseVisualStyleBackColor = true;
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(103, 365);
            grd.Margin = new Padding(5);
            grd.Name = "grd";
            grd.RowHeadersWidth = 51;
            grd.RowTemplate.Height = 29;
            grd.Size = new Size(1261, 346);
            grd.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bPrint);
            groupBox2.Controls.Add(bCancel);
            groupBox2.Controls.Add(bSave);
            groupBox2.Controls.Add(bEdit);
            groupBox2.Controls.Add(bDel);
            groupBox2.Controls.Add(bAdd);
            groupBox2.Location = new Point(103, 239);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(1261, 98);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Functions";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSup);
            groupBox1.Controls.Add(txtFun);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtPID);
            groupBox1.Location = new Point(103, 29);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(1261, 200);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Project Information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1439, 741);
            Controls.Add(grd);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button bEdit;
        private Button bAdd;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtSup;
        private TextBox txtFun;
        private Button bPrint;
        private Button bCancel;
        private Button bSave;
        private TextBox txtName;
        private TextBox txtPID;
        private Button bDel;
        private DataGridView grd;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
    }
}
