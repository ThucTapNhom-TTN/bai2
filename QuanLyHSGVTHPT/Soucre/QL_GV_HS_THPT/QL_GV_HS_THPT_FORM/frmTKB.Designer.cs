namespace QL_GV_HS_THPT_FORM
{
    partial class frmTKB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grbTKB = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.dgvTKB = new System.Windows.Forms.DataGridView();
            this.Tiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grbTKB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grbTKB);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvTKB);
            this.splitContainer1.Size = new System.Drawing.Size(1103, 225);
            this.splitContainer1.SplitterDistance = 63;
            this.splitContainer1.TabIndex = 0;
            // 
            // grbTKB
            // 
            this.grbTKB.Controls.Add(this.btnAdd);
            this.grbTKB.Controls.Add(this.lblClass);
            this.grbTKB.Controls.Add(this.cmbClass);
            this.grbTKB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTKB.Location = new System.Drawing.Point(0, 0);
            this.grbTKB.Name = "grbTKB";
            this.grbTKB.Size = new System.Drawing.Size(1103, 63);
            this.grbTKB.TabIndex = 0;
            this.grbTKB.TabStop = false;
            this.grbTKB.Text = "Thông tin giảng dạy";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(326, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(52, 26);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(25, 13);
            this.lblClass.TabIndex = 1;
            this.lblClass.Text = "Lớp";
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(102, 23);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(121, 21);
            this.cmbClass.TabIndex = 0;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // dgvTKB
            // 
            this.dgvTKB.AllowUserToAddRows = false;
            this.dgvTKB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tiet,
            this.Thu2,
            this.MaGV2,
            this.TenGV2,
            this.Thu3,
            this.MaGV3,
            this.TenGV3,
            this.Thu4,
            this.TenGV4,
            this.MaGV4,
            this.Thu5,
            this.MaGV5,
            this.TenGV5,
            this.Thu6,
            this.MaGV6,
            this.TenGV6,
            this.Thu7,
            this.TenGV7,
            this.MaGV7});
            this.dgvTKB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTKB.Enabled = false;
            this.dgvTKB.Location = new System.Drawing.Point(0, 0);
            this.dgvTKB.Name = "dgvTKB";
            this.dgvTKB.Size = new System.Drawing.Size(1103, 158);
            this.dgvTKB.TabIndex = 0;
            // 
            // Tiet
            // 
            this.Tiet.HeaderText = "Tiết";
            this.Tiet.Name = "Tiet";
            this.Tiet.Width = 30;
            // 
            // Thu2
            // 
            this.Thu2.HeaderText = "Thứ 2";
            this.Thu2.Name = "Thu2";
            this.Thu2.Width = 70;
            // 
            // MaGV2
            // 
            this.MaGV2.HeaderText = "MaGV2";
            this.MaGV2.Name = "MaGV2";
            this.MaGV2.Visible = false;
            // 
            // TenGV2
            // 
            this.TenGV2.HeaderText = "Tên GV";
            this.TenGV2.Name = "TenGV2";
            // 
            // Thu3
            // 
            this.Thu3.HeaderText = "Thứ 3";
            this.Thu3.Name = "Thu3";
            this.Thu3.Width = 70;
            // 
            // MaGV3
            // 
            this.MaGV3.HeaderText = "MaGV3";
            this.MaGV3.Name = "MaGV3";
            this.MaGV3.Visible = false;
            // 
            // TenGV3
            // 
            this.TenGV3.HeaderText = "Tên GV";
            this.TenGV3.Name = "TenGV3";
            // 
            // Thu4
            // 
            this.Thu4.HeaderText = "Thứ 4";
            this.Thu4.Name = "Thu4";
            this.Thu4.Width = 70;
            // 
            // TenGV4
            // 
            this.TenGV4.HeaderText = "Tên GV";
            this.TenGV4.Name = "TenGV4";
            // 
            // MaGV4
            // 
            this.MaGV4.HeaderText = "MaGV4";
            this.MaGV4.Name = "MaGV4";
            this.MaGV4.Visible = false;
            // 
            // Thu5
            // 
            this.Thu5.HeaderText = "Thứ 5";
            this.Thu5.Name = "Thu5";
            this.Thu5.Width = 70;
            // 
            // MaGV5
            // 
            this.MaGV5.HeaderText = "MaGV5";
            this.MaGV5.Name = "MaGV5";
            this.MaGV5.Visible = false;
            // 
            // TenGV5
            // 
            this.TenGV5.HeaderText = "Tên GV";
            this.TenGV5.Name = "TenGV5";
            // 
            // Thu6
            // 
            this.Thu6.HeaderText = "Thứ 6";
            this.Thu6.Name = "Thu6";
            this.Thu6.Width = 70;
            // 
            // MaGV6
            // 
            this.MaGV6.HeaderText = "MaGV6";
            this.MaGV6.Name = "MaGV6";
            this.MaGV6.Visible = false;
            // 
            // TenGV6
            // 
            this.TenGV6.HeaderText = "Tên GV";
            this.TenGV6.Name = "TenGV6";
            // 
            // Thu7
            // 
            this.Thu7.HeaderText = "Thứ 7";
            this.Thu7.Name = "Thu7";
            this.Thu7.Width = 70;
            // 
            // TenGV7
            // 
            this.TenGV7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenGV7.HeaderText = "Tên GV";
            this.TenGV7.Name = "TenGV7";
            // 
            // MaGV7
            // 
            this.MaGV7.HeaderText = "MaGV7";
            this.MaGV7.Name = "MaGV7";
            this.MaGV7.Visible = false;
            // 
            // frmTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 225);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmTKB";
            this.Text = "Thời khóa biểu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTKB_FormClosing);
            this.Load += new System.EventHandler(this.frmTKB_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grbTKB.ResumeLayout(false);
            this.grbTKB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grbTKB;
        private System.Windows.Forms.DataGridView dgvTKB;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV6;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu7;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV7;
        private System.Windows.Forms.Button btnAdd;
    }
}