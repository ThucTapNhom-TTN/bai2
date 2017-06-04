namespace QL_GV_HS_THPT_FORM
{
    partial class frmThemtaikhoan
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRepassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbMaGV = new System.Windows.Forms.ComboBox();
            this.cmbQuyen = new System.Windows.Forms.ComboBox();
            this.grbAcc = new System.Windows.Forms.GroupBox();
            this.grbAcc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(268, 304);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Nhập lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(25, 304);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên tài khoản";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(129, 44);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(121, 20);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(129, 93);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(121, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // txtRepassword
            // 
            this.txtRepassword.Location = new System.Drawing.Point(129, 143);
            this.txtRepassword.Name = "txtRepassword";
            this.txtRepassword.Size = new System.Drawing.Size(121, 20);
            this.txtRepassword.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã GV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quyền";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(147, 304);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "OK";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbMaGV
            // 
            this.cmbMaGV.FormattingEnabled = true;
            this.cmbMaGV.Location = new System.Drawing.Point(129, 188);
            this.cmbMaGV.Name = "cmbMaGV";
            this.cmbMaGV.Size = new System.Drawing.Size(121, 21);
            this.cmbMaGV.TabIndex = 13;
            this.cmbMaGV.TextChanged += new System.EventHandler(this.cmbMaGV_TextChanged);
            this.cmbMaGV.Click += new System.EventHandler(this.cmbMaGV_Click);
            // 
            // cmbQuyen
            // 
            this.cmbQuyen.Items.AddRange(new object[] {
            "Học Sinh",
            "Trợ Giảng",
            "Giáo Viên",
            "Hiểu Trưởng",
            "Administrator"});
            this.cmbQuyen.Location = new System.Drawing.Point(129, 233);
            this.cmbQuyen.Name = "cmbQuyen";
            this.cmbQuyen.Size = new System.Drawing.Size(121, 21);
            this.cmbQuyen.TabIndex = 14;
            this.cmbQuyen.SelectedIndexChanged += new System.EventHandler(this.cmbQuyen_SelectedIndexChanged);
            // 
            // grbAcc
            // 
            this.grbAcc.Controls.Add(this.label5);
            this.grbAcc.Controls.Add(this.cmbQuyen);
            this.grbAcc.Controls.Add(this.label1);
            this.grbAcc.Controls.Add(this.cmbMaGV);
            this.grbAcc.Controls.Add(this.txtUsername);
            this.grbAcc.Controls.Add(this.label2);
            this.grbAcc.Controls.Add(this.txtPassword);
            this.grbAcc.Controls.Add(this.label4);
            this.grbAcc.Controls.Add(this.label3);
            this.grbAcc.Controls.Add(this.txtRepassword);
            this.grbAcc.Location = new System.Drawing.Point(53, 12);
            this.grbAcc.Name = "grbAcc";
            this.grbAcc.Size = new System.Drawing.Size(276, 275);
            this.grbAcc.TabIndex = 15;
            this.grbAcc.TabStop = false;
            this.grbAcc.Text = "Thông tin tài khoản";
            // 
            // frmThemtaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 388);
            this.Controls.Add(this.grbAcc);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Name = "frmThemtaikhoan";
            this.Text = "Thêm tài khoản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThemtaikhoan_FormClosing);
            this.Load += new System.EventHandler(this.frmThemtaikhoan_Load);
            this.grbAcc.ResumeLayout(false);
            this.grbAcc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRepassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbMaGV;
        private System.Windows.Forms.ComboBox cmbQuyen;
        private System.Windows.Forms.GroupBox grbAcc;
    }
}