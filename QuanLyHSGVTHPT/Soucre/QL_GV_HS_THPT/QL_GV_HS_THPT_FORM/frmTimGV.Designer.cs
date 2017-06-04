namespace QL_GV_HS_THPT_FORM
{
    partial class frmTimGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimGV));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.colMaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtTimMaGV = new System.Windows.Forms.ToolStripTextBox();
            this.txtTimHoGV = new System.Windows.Forms.ToolStripTextBox();
            this.txtTimTenGV = new System.Windows.Forms.ToolStripTextBox();
            this.cboTimMaMon = new System.Windows.Forms.ToolStripComboBox();
            this.cboTimDiaChi = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 85);
            this.panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(12, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 70);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvGiaoVien);
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 203);
            this.panel2.TabIndex = 1;
            // 
            // dgvGiaoVien
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGiaoVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaGV,
            this.colHo,
            this.colTen,
            this.colMaMon,
            this.colDiaChi,
            this.colGT,
            this.colNgaySinh,
            this.colLuong,
            this.colSDT});
            this.dgvGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiaoVien.Location = new System.Drawing.Point(0, 42);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.Size = new System.Drawing.Size(1083, 161);
            this.dgvGiaoVien.TabIndex = 4;
            // 
            // colMaGV
            // 
            this.colMaGV.DataPropertyName = "MaGV";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colMaGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.colMaGV.HeaderText = "Mã GV";
            this.colMaGV.MinimumWidth = 50;
            this.colMaGV.Name = "colMaGV";
            // 
            // colHo
            // 
            this.colHo.DataPropertyName = "Ho";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colHo.DefaultCellStyle = dataGridViewCellStyle3;
            this.colHo.HeaderText = "Họ";
            this.colHo.Name = "colHo";
            this.colHo.Width = 180;
            // 
            // colTen
            // 
            this.colTen.DataPropertyName = "Ten";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colTen.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTen.HeaderText = "Tên";
            this.colTen.Name = "colTen";
            // 
            // colMaMon
            // 
            this.colMaMon.DataPropertyName = "MaMon";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colMaMon.DefaultCellStyle = dataGridViewCellStyle5;
            this.colMaMon.HeaderText = "Mã môn";
            this.colMaMon.Name = "colMaMon";
            this.colMaMon.Width = 80;
            // 
            // colDiaChi
            // 
            this.colDiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDiaChi.DataPropertyName = "DiaChi";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDiaChi.DefaultCellStyle = dataGridViewCellStyle6;
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.MinimumWidth = 200;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Width = 200;
            // 
            // colGT
            // 
            this.colGT.DataPropertyName = "GT";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colGT.DefaultCellStyle = dataGridViewCellStyle7;
            this.colGT.HeaderText = "GT";
            this.colGT.Name = "colGT";
            this.colGT.Width = 80;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNgaySinh.DefaultCellStyle = dataGridViewCellStyle8;
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.Name = "colNgaySinh";
            // 
            // colLuong
            // 
            this.colLuong.DataPropertyName = "Luong";
            this.colLuong.HeaderText = "Lương";
            this.colLuong.Name = "colLuong";
            // 
            // colSDT
            // 
            this.colSDT.DataPropertyName = "SDT";
            this.colSDT.HeaderText = "SĐT";
            this.colSDT.Name = "colSDT";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtTimMaGV,
            this.txtTimHoGV,
            this.txtTimTenGV,
            this.cboTimMaMon,
            this.cboTimDiaChi});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1083, 42);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(57, 39);
            this.toolStripLabel1.Text = "Tìm kiếm";
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // txtTimMaGV
            // 
            this.txtTimMaGV.Name = "txtTimMaGV";
            this.txtTimMaGV.Size = new System.Drawing.Size(75, 42);
            this.txtTimMaGV.Text = "-- Mã GV";
            this.txtTimMaGV.Enter += new System.EventHandler(this.txtTimMaGV_Enter);
            this.txtTimMaGV.Click += new System.EventHandler(this.txtTimMaGV_Click);
            this.txtTimMaGV.TextChanged += new System.EventHandler(this.txtTimMaGV_TextChanged);
            // 
            // txtTimHoGV
            // 
            this.txtTimHoGV.Name = "txtTimHoGV";
            this.txtTimHoGV.Size = new System.Drawing.Size(176, 42);
            this.txtTimHoGV.Text = "-- Họ GV";
            this.txtTimHoGV.Enter += new System.EventHandler(this.txtTimHoGV_Enter);
            this.txtTimHoGV.Click += new System.EventHandler(this.txtTimHoGV_Click);
            this.txtTimHoGV.TextChanged += new System.EventHandler(this.txtTimHoGV_TextChanged);
            // 
            // txtTimTenGV
            // 
            this.txtTimTenGV.Name = "txtTimTenGV";
            this.txtTimTenGV.Size = new System.Drawing.Size(100, 42);
            this.txtTimTenGV.Text = "-- Tên GV";
            this.txtTimTenGV.Enter += new System.EventHandler(this.txtTimTenGV_Enter);
            this.txtTimTenGV.Click += new System.EventHandler(this.txtTimTenGV_Click);
            this.txtTimTenGV.TextChanged += new System.EventHandler(this.txtTimTenGV_TextChanged);
            // 
            // cboTimMaMon
            // 
            this.cboTimMaMon.Name = "cboTimMaMon";
            this.cboTimMaMon.Size = new System.Drawing.Size(80, 42);
            this.cboTimMaMon.Text = "-- Mã Môn";
            this.cboTimMaMon.Enter += new System.EventHandler(this.cboTimMaMon_Enter);
            this.cboTimMaMon.Click += new System.EventHandler(this.cboTimMaMon_Click);
            this.cboTimMaMon.TextChanged += new System.EventHandler(this.cboTimMaMon_TextChanged);
            // 
            // cboTimDiaChi
            // 
            this.cboTimDiaChi.Name = "cboTimDiaChi";
            this.cboTimDiaChi.Size = new System.Drawing.Size(200, 42);
            this.cboTimDiaChi.Text = "-- Địa chỉ";
            this.cboTimDiaChi.Enter += new System.EventHandler(this.cboTimDiaChi_Enter);
            this.cboTimDiaChi.Click += new System.EventHandler(this.cboTimDiaChi_Click);
            this.cboTimDiaChi.TextChanged += new System.EventHandler(this.cboTimDiaChi_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(100, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // frmTimGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 288);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmTimGV";
            this.Text = "Tìm giáo viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTimGV_FormClosed);
            this.Load += new System.EventHandler(this.frmTimGV_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtTimMaGV;
        private System.Windows.Forms.ToolStripTextBox txtTimHoGV;
        private System.Windows.Forms.ToolStripTextBox txtTimTenGV;
        private System.Windows.Forms.ToolStripComboBox cboTimMaMon;
        private System.Windows.Forms.ToolStripComboBox cboTimDiaChi;
        private System.Windows.Forms.DataGridView dgvGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
    }
}