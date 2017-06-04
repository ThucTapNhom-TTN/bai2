using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QL_GV_HS_THPT_DAL;
using QL_QV_HS_THPT_Entity;
namespace QL_GV_HS_THPT_FORM
{
    public partial class frmThemGV : Form
    {
        SQL_tblGiaovien giaovien = new SQL_tblGiaovien();
        EC_tblGiaovien gv = new EC_tblGiaovien();
        DataTable dt = new DataTable();
        public void SetNull()
        {
            txtHo.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtMaGV.Text = "";
            txtSDT.Text = "";
            txtLuong.Text = "";
        }
        public frmThemGV()
        {
            InitializeComponent();
        }

        private void frmThemGV_Load(object sender, EventArgs e)
        {            
            SQL_tblMonhoc monhoc = new SQL_tblMonhoc();
            dt = monhoc.getAllMonhoc();
            cbMaMon.DataSource = dt;
            cbMaMon.DisplayMember = "MaMon";
            cbTenMon.DataSource = dt;
            cbTenMon.DisplayMember = "TenMon";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaGV.Text == "GV")
            {
                lbMessage.Text = "Bạn chưa điền đủ thông tin!!!";
                return;
            }
            else
            {
                gv.MaGV = txtMaGV.Text;
                gv.MaMon = cbMaMon.Text;
                gv.Ho = txtHo.Text;
                gv.Ten = txtTen.Text;
                gv.NgaySinh = dtpNS.Value.ToShortDateString();
                gv.SDT = txtSDT.Text;
                gv.Luong = txtLuong.Text;
                gv.DiaChi = txtDiaChi.Text;
                if (chkNam.Checked == true)
                {
                    gv.GT = "Nam";
                }
                else
                {
                    gv.GT = "Nữ";
                }
                giaovien.addGiaovien(gv);
                MessageBox.Show("Bạn đã lưu thành công!!!", "Thông Báo", MessageBoxButtons.OK);
                SetNull();
            }
        }

        private void chkNam_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNam.Checked == true)
            {
                chkNu.Checked = false;
            }
        }

        private void chkNu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNu.Checked == true)
            {
                chkNam.Checked = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn thoát???", "Questions", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void lbMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
