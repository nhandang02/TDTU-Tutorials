namespace Bai01
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
            dgv1 = new DataGridView();
            grb1 = new GroupBox();
            grp2 = new GroupBox();
            bPRINT = new Button();
            bCANCEL = new Button();
            bSAVE = new Button();
            bEDIT = new Button();
            bDEL = new Button();
            bAll = new Button();
            cbx1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            grb1.SuspendLayout();
            grp2.SuspendLayout();
            SuspendLayout();
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(24, 38);
            dgv1.Name = "dgv1";
            dgv1.RowHeadersWidth = 82;
            dgv1.Size = new Size(1365, 408);
            dgv1.TabIndex = 0;
            // 
            // grb1
            // 
            grb1.Controls.Add(dgv1);
            grb1.Location = new Point(37, 424);
            grb1.Name = "grb1";
            grb1.Size = new Size(1422, 466);
            grb1.TabIndex = 1;
            grb1.TabStop = false;
            grb1.Text = "Result";
            grb1.Enter += groupBox1_Enter;
            // 
            // grp2
            // 
            grp2.Controls.Add(bPRINT);
            grp2.Controls.Add(bCANCEL);
            grp2.Controls.Add(bSAVE);
            grp2.Controls.Add(bEDIT);
            grp2.Controls.Add(bDEL);
            grp2.Controls.Add(bAll);
            grp2.Location = new Point(212, 307);
            grp2.Margin = new Padding(5, 6, 5, 6);
            grp2.Name = "grp2";
            grp2.Padding = new Padding(5, 6, 5, 6);
            grp2.Size = new Size(983, 122);
            grp2.TabIndex = 8;
            grp2.TabStop = false;
            grp2.Text = "Functions";
            // 
            // bPRINT
            // 
            bPRINT.Location = new Point(772, 35);
            bPRINT.Margin = new Padding(5, 6, 5, 6);
            bPRINT.Name = "bPRINT";
            bPRINT.Size = new Size(126, 64);
            bPRINT.TabIndex = 5;
            bPRINT.Text = "Print";
            bPRINT.UseVisualStyleBackColor = true;
            bPRINT.Click += bPRINT_Click;
            // 
            // bCANCEL
            // 
            bCANCEL.Location = new Point(636, 35);
            bCANCEL.Margin = new Padding(5, 6, 5, 6);
            bCANCEL.Name = "bCANCEL";
            bCANCEL.Size = new Size(126, 64);
            bCANCEL.TabIndex = 4;
            bCANCEL.Text = "Cancel";
            bCANCEL.UseVisualStyleBackColor = true;
            // 
            // bSAVE
            // 
            bSAVE.Location = new Point(498, 35);
            bSAVE.Margin = new Padding(5, 6, 5, 6);
            bSAVE.Name = "bSAVE";
            bSAVE.Size = new Size(126, 64);
            bSAVE.TabIndex = 1;
            bSAVE.Text = "Save";
            bSAVE.UseVisualStyleBackColor = true;
            // 
            // bEDIT
            // 
            bEDIT.Location = new Point(360, 35);
            bEDIT.Margin = new Padding(5, 6, 5, 6);
            bEDIT.Name = "bEDIT";
            bEDIT.Size = new Size(126, 64);
            bEDIT.TabIndex = 3;
            bEDIT.Text = "Edit";
            bEDIT.UseVisualStyleBackColor = true;
            // 
            // bDEL
            // 
            bDEL.Location = new Point(222, 35);
            bDEL.Margin = new Padding(5, 6, 5, 6);
            bDEL.Name = "bDEL";
            bDEL.Size = new Size(126, 64);
            bDEL.TabIndex = 2;
            bDEL.Text = "Delete";
            bDEL.UseVisualStyleBackColor = true;
            // 
            // bAll
            // 
            bAll.Location = new Point(86, 35);
            bAll.Margin = new Padding(5, 6, 5, 6);
            bAll.Name = "bAll";
            bAll.Size = new Size(126, 64);
            bAll.TabIndex = 0;
            bAll.Text = "All";
            bAll.UseVisualStyleBackColor = true;
            bAll.Click += bAll_Click;
            // 
            // cbx1
            // 
            cbx1.FormattingEnabled = true;
            cbx1.Location = new Point(202, 12);
            cbx1.Name = "cbx1";
            cbx1.Size = new Size(242, 40);
            cbx1.TabIndex = 9;
            cbx1.SelectedIndexChanged += cbx1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 10;
            label1.Text = "List Of Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(864, 20);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1471, 893);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbx1);
            Controls.Add(grp2);
            Controls.Add(grb1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            grb1.ResumeLayout(false);
            grp2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv1;
        private GroupBox grb1;
        private GroupBox grp2;
        private Button bPRINT;
        private Button bCANCEL;
        private Button bSAVE;
        private Button bEDIT;
        private Button bDEL;
        private Button bAll;
        private ComboBox cbx1;
        private Label label1;
        private Label label2;
    }
}
