﻿namespace QL_GV_HS_THPT_FORM
{
    partial class frmQLGD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtTimGV = new System.Windows.Forms.ToolStripTextBox();
            this.txtTimLop = new System.Windows.Forms.ToolStripTextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbThu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.cboGiaoVien = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTiet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 193);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtTimGV,
            this.txtTimLop});
            this.toolStrip1.Location = new System.Drawing.Point(0, 168);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(573, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel1.Text = "Tìm ";
            // 
            // txtTimGV
            // 
            this.txtTimGV.Name = "txtTimGV";
            this.txtTimGV.Size = new System.Drawing.Size(250, 25);
            this.txtTimGV.TextChanged += new System.EventHandler(this.txtTimGV_TextChanged);
            // 
            // txtTimLop
            // 
            this.txtTimLop.Name = "txtTimLop";
            this.txtTimLop.Size = new System.Drawing.Size(80, 25);
            this.txtTimLop.TextChanged += new System.EventHandler(this.txtTimLop_TextChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(466, 102);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(87, 27);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Location = new System.Drawing.Point(362, 102);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 27);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Location = new System.Drawing.Point(466, 67);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 27);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.cmbThu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboLop);
            this.groupBox1.Controls.Add(this.cboGiaoVien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTiet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 119);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lich giảng";
            // 
            // cmbThu
            // 
            this.cmbThu.FormattingEnabled = true;
            this.cmbThu.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbThu.Location = new System.Drawing.Point(83, 80);
            this.cmbThu.Name = "cmbThu";
            this.cmbThu.Size = new System.Drawing.Size(97, 23);
            this.cmbThu.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Thứ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lớp";
            // 
            // cboLop
            // 
            this.cboLop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboLop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboLop.Enabled = false;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(83, 52);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(97, 23);
            this.cboLop.TabIndex = 1;
            this.cboLop.Validated += new System.EventHandler(this.cboLop_Validated);
            // 
            // cboGiaoVien
            // 
            this.cboGiaoVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboGiaoVien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboGiaoVien.Enabled = false;
            this.cboGiaoVien.FormattingEnabled = true;
            this.cboGiaoVien.Location = new System.Drawing.Point(83, 23);
            this.cboGiaoVien.Name = "cboGiaoVien";
            this.cboGiaoVien.Size = new System.Drawing.Size(220, 23);
            this.cboGiaoVien.TabIndex = 0;
            this.cboGiaoVien.Validated += new System.EventHandler(this.cboGiaoVien_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tiết";
            // 
            // txtTiet
            // 
            this.txtTiet.AccessibleDescription = "";
            this.txtTiet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTiet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTiet.Enabled = false;
            this.txtTiet.Location = new System.Drawing.Point(270, 81);
            this.txtTiet.Name = "txtTiet";
            this.txtTiet.Size = new System.Drawing.Size(33, 21);
            this.txtTiet.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giáo viên";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ GIẢNG DẠY";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Location = new System.Drawing.Point(362, 66);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 27);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDanhSach);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 167);
            this.panel2.TabIndex = 1;
            // 
            // dgvDanhSach
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenGV,
            this.Lop,
            this.Thu,
            this.Tiet});
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.Size = new System.Drawing.Size(573, 167);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellEnter);
            // 
            // TenGV
            // 
            this.TenGV.DataPropertyName = "HoTen";
            this.TenGV.HeaderText = "Giáo viên";
            this.TenGV.Name = "TenGV";
            this.TenGV.Width = 250;
            // 
            // Lop
            // 
            this.Lop.DataPropertyName = "TenLop";
            this.Lop.HeaderText = "Lớp";
            this.Lop.Name = "Lop";
            this.Lop.Width = 80;
            // 
            // Thu
            // 
            this.Thu.DataPropertyName = "Thu";
            this.Thu.HeaderText = "Thứ";
            this.Thu.Name = "Thu";
            this.Thu.Width = 150;
            // 
            // Tiet
            // 
            this.Tiet.DataPropertyName = "Tietday";
            this.Tiet.HeaderText = "Tiết";
            this.Tiet.Name = "Tiet";
            this.Tiet.Width = 50;
            // 
            // frmQLGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 360);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "frmQLGD";
            this.Text = "Quản lý giảng dạy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQLGD_FormClosed);
            this.Load += new System.EventHandler(this.frmQLGD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.ComboBox cboGiaoVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTiet;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtTimGV;
        private System.Windows.Forms.ToolStripTextBox txtTimLop;
        private System.Windows.Forms.ComboBox cmbThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiet;
    }
}