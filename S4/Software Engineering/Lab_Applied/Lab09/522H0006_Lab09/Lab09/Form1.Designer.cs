namespace Lab09
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
            this.grp3 = new System.Windows.Forms.GroupBox();
            this.grd = new System.Windows.Forms.DataGridView();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.cbSID = new System.Windows.Forms.ComboBox();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProjectID = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bALL = new System.Windows.Forms.Button();
            this.bPRINT = new System.Windows.Forms.Button();
            this.grp2 = new System.Windows.Forms.GroupBox();
            this.grp3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.grp1.SuspendLayout();
            this.grp2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp3
            // 
            this.grp3.Controls.Add(this.grd);
            this.grp3.Location = new System.Drawing.Point(138, 263);
            this.grp3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp3.Name = "grp3";
            this.grp3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp3.Size = new System.Drawing.Size(716, 330);
            this.grp3.TabIndex = 14;
            this.grp3.TabStop = false;
            this.grp3.Text = "Student\'s Project list";
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(9, 26);
            this.grd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grd.Name = "grd";
            this.grd.RowHeadersWidth = 62;
            this.grd.RowTemplate.Height = 25;
            this.grd.Size = new System.Drawing.Size(701, 290);
            this.grd.TabIndex = 0;
            this.grd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_CellClick);
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.cbSID);
            this.grp1.Controls.Add(this.cbName);
            this.grp1.Controls.Add(this.label5);
            this.grp1.Controls.Add(this.label4);
            this.grp1.Controls.Add(this.txtResult);
            this.grp1.Controls.Add(this.Result);
            this.grp1.Controls.Add(this.txtDistance);
            this.grp1.Controls.Add(this.label3);
            this.grp1.Controls.Add(this.txtProjectID);
            this.grp1.Controls.Add(this.txtIP);
            this.grp1.Controls.Add(this.label2);
            this.grp1.Controls.Add(this.label1);
            this.grp1.Location = new System.Drawing.Point(141, 27);
            this.grp1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp1.Name = "grp1";
            this.grp1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp1.Size = new System.Drawing.Size(713, 149);
            this.grp1.TabIndex = 12;
            this.grp1.TabStop = false;
            this.grp1.Text = "Student Project information";
            // 
            // cbSID
            // 
            this.cbSID.FormattingEnabled = true;
            this.cbSID.Location = new System.Drawing.Point(102, 27);
            this.cbSID.Name = "cbSID";
            this.cbSID.Size = new System.Drawing.Size(207, 28);
            this.cbSID.TabIndex = 13;
            this.cbSID.SelectedIndexChanged += new System.EventHandler(this.cbSID_SelectedIndexChanged);
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(475, 30);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(178, 28);
            this.cbName.TabIndex = 12;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Student Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Internship Place ";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(102, 109);
            this.txtResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(207, 27);
            this.txtResult.TabIndex = 8;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(8, 109);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(49, 20);
            this.Result.TabIndex = 7;
            this.Result.Text = "Result";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(475, 112);
            this.txtDistance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(178, 27);
            this.txtDistance.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Distance";
            // 
            // txtProjectID
            // 
            this.txtProjectID.Location = new System.Drawing.Point(475, 65);
            this.txtProjectID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.Size = new System.Drawing.Size(178, 27);
            this.txtProjectID.TabIndex = 1;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(131, 65);
            this.txtIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(178, 27);
            this.txtIP.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ProjectID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // bALL
            // 
            this.bALL.Location = new System.Drawing.Point(182, 28);
            this.bALL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bALL.Name = "bALL";
            this.bALL.Size = new System.Drawing.Size(78, 40);
            this.bALL.TabIndex = 0;
            this.bALL.Text = "All";
            this.bALL.UseVisualStyleBackColor = true;
            this.bALL.Click += new System.EventHandler(this.bALL_Click);
            // 
            // bPRINT
            // 
            this.bPRINT.Location = new System.Drawing.Point(390, 28);
            this.bPRINT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bPRINT.Name = "bPRINT";
            this.bPRINT.Size = new System.Drawing.Size(78, 40);
            this.bPRINT.TabIndex = 5;
            this.bPRINT.Text = "Print";
            this.bPRINT.UseVisualStyleBackColor = true;
            this.bPRINT.Click += new System.EventHandler(this.bPRINT_Click);
            // 
            // grp2
            // 
            this.grp2.Controls.Add(this.bPRINT);
            this.grp2.Controls.Add(this.bALL);
            this.grp2.Location = new System.Drawing.Point(141, 176);
            this.grp2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp2.Name = "grp2";
            this.grp2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp2.Size = new System.Drawing.Size(713, 76);
            this.grp2.TabIndex = 13;
            this.grp2.TabStop = false;
            this.grp2.Text = "Functions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 668);
            this.Controls.Add(this.grp3);
            this.Controls.Add(this.grp1);
            this.Controls.Add(this.grp2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
            this.grp2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grp3;
        private DataGridView grd;
        private GroupBox grp1;
        private TextBox txtProjectID;
        private TextBox txtIP;
        private Label label2;
        private Label label1;
        private Button bALL;
        private Button bPRINT;
        private GroupBox grp2;
        private TextBox txtResult;
        private Label Result;
        private TextBox txtDistance;
        private Label label3;
        private Label label4;
        private ComboBox cbSID;
        private ComboBox cbName;
        private Label label5;
    }
}