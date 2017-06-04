using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_GV_HS_THPT_DAL;
using QL_QV_HS_THPT_Entity;
namespace QL_GV_HS_THPT_FORM
{
    public partial class frmGiaovien : Form
    {
        int dong = -1;
        SQL_tblGiaovien gv = new SQL_tblGiaovien();
        SQL_tblMonhoc MH = new SQL_tblMonhoc();
        EC_tblGiaovien teacher = new EC_tblGiaovien();
        DataTable dt = new DataTable();

        public void SetNull()
        {
            txtMaGV.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtLuong.Text = "";
            dtpNS.Value = new DateTime(1900, 1, 1);
            txtMaMon.Text = "";
        }
        public void MoDieuKhien()
        {
            txtMaGV.ReadOnly = false;
            txtHo.ReadOnly = false;
            txtTen.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtLuong.ReadOnly = false;
            txtMaMon.ReadOnly = false;
        }
        public void KhoaDieuKhien()
        {
            txtMaGV.ReadOnly = true;
            txtHo.ReadOnly = true;
            txtTen.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtLuong.ReadOnly = true;
            txtMaMon.ReadOnly = true;
        }
        public frmGiaovien()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;
                txtMaGV.Text = dgvGiaoVien.Rows[dong].Cells[0].Value.ToString();
                txtHo.Text = dgvGiaoVien.Rows[dong].Cells[1].Value.ToString();
                txtTen.Text = dgvGiaoVien.Rows[dong].Cells[2].Value.ToString();
                cbGT.Text = dgvGiaoVien.Rows[dong].Cells[3].Value.ToString();
                dtpNS.Text = dgvGiaoVien.Rows[dong].Cells[4].Value.ToString();
                txtSDT.Text = dgvGiaoVien.Rows[dong].Cells[5].Value.ToString();
                txtDiaChi.Text = dgvGiaoVien.Rows[dong].Cells[6].Value.ToString();
                txtLuong.Text = dgvGiaoVien.Rows[dong].Cells[7].Value.ToString();
                txtMaMon.Text = dgvGiaoVien.Rows[dong].Cells[8].Value.ToString();
                cbTenMon.DataSource = MH.getMonhoc("where MaMon = '"+txtMaMon.Text+"'");
                cbTenMon.DisplayMember = "TenMon";
            }
            catch { }
        }

        private void frmGiaovien_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            btnRefresh.Enabled = false;
            btnSave.Enabled = false;
            dgvGiaoVien.DataSource = gv.getAllgiaovien();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmThemGV themgv = new frmThemGV();
            themgv.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dong < 0)
            {
                MessageBox.Show("Chưa chọn giáo viên để sửa!");
                return;
            }
            MoDieuKhien();
            cbGT.DataSource= gv.getField("GT");
            cbGT.DisplayMember = "GT";
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Enabled = true;
            btnRefresh.Enabled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            btnSave.Enabled = false;
            btnRefresh.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            dgvGiaoVien.DataSource = gv.getAllgiaovien();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Dispose();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn xóa dữ liệu???", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                teacher.MaGV = txtMaGV.Text;
                gv.delGiaovien(teacher);
                MessageBox.Show("Xóa dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            teacher.MaGV = txtMaGV.Text;
            teacher.Ho = txtHo.Text;
            teacher.Ten = txtTen.Text;
            teacher.GT = cbGT.Text;
            teacher.NgaySinh = dtpNS.Value.ToShortDateString();
            teacher.DiaChi = txtDiaChi.Text;
            teacher.Luong = txtLuong.Text;
            teacher.MaMon = txtMaMon.Text;
            teacher.SDT = txtSDT.Text;
            gv.updateGiaovien(teacher);
            MessageBox.Show("Cập Nhật Thành Công", "Thông Báo", MessageBoxButtons.OK);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cbGT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
