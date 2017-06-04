using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_QV_HS_THPT_Entity;

namespace QL_GV_HS_THPT_FORM
{
    public partial class frmMain : Form
    {
        EC_tblUser curUser = new EC_tblUser();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblHi.Text += ConfigurationManager.AppSettings.Get("Username");
            int rule = int.Parse(ConfigurationManager.AppSettings.Get("Quyen"));
            checkRule(rule);
        }

        private void frmMain_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnTkb_Click(object sender, EventArgs e)
        {
            frmTKB frm = new frmTKB();
            frm.Show();
            this.Dispose();
            
        }

        private void btnHocsinh_Click(object sender, EventArgs e)
        {
            frmHocsinh frm = new frmHocsinh();
            frm.Show();
            this.Dispose();
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            frmQuantri frm = new frmQuantri();
            frm.Show();
            this.Dispose();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmDangnhap frm = new frmDangnhap();
            frm.Show();
            this.Dispose();
            
        }
        
        private void checkRule(int rule)
        {
            foreach(Control ctr in panel1.Controls)
                {
                    ctr.Enabled = false;
                }
            menuStrip1.Enabled = true;
            if(rule>=0)
            {
                btnLogout.Enabled = true;
                btnHocsinh.Enabled = true;
                btnListstudent.Enabled = true;
                btnSearchstudent.Enabled = true;
                btnHuongdan.Enabled = true;
                btnStudent.Enabled = true;
                btnTkb.Enabled = true;

                btnRegisterteach.Enabled = false;
                btnTeacher.Enabled = false;
                btnAddstudent.Enabled = false;
                btnAcc.Enabled = false;
            }
            if(rule>=1)
            {
                btnGiaovien.Enabled = true;
                btnListteacher.Enabled = true;
                btnSearchtecher.Enabled = true;
                btnAddstudent.Enabled = true;
                btnTeacher.Enabled = true;
                btnAcc.Enabled = true;
            }
            if(rule>=2)
            {
                btnTkb.Enabled = true;
                btnRegisterteach.Enabled = true;
                
            }
            if (rule >= 4)
            {
                foreach (Control ctr in this.Controls)
                {
                    ctr.Enabled = true;
                }
            }
        }

        private void btnGiaovien_Click(object sender, EventArgs e)
        {
            frmGiaovien frm = new frmGiaovien();
            frm.Show();
            this.Dispose();
        }

        private void btnAddteacher_Click(object sender, EventArgs e)
        {
            frmThemGV themgv = new frmThemGV();
            themgv.Show();
        }

        private void btnListteacher_Click(object sender, EventArgs e)
        {
            frmGiaovien gv = new frmGiaovien();
            gv.Show();
        }

        private void btnRegisterteach_Click(object sender, EventArgs e)
        {
            frmQLGD frm = new frmQLGD();
            frm.Show();
            this.Hide();
        }

        private void btnSearchtecher_Click(object sender, EventArgs e)
        {
            frmTimGV frmGV = new frmTimGV();
            this.Hide();
            frmGV.Show();
        }

        private void btnSearchstudent_Click(object sender, EventArgs e)
        {
            frmHocsinh frmHS = new frmHocsinh("TimKiem");
            frmHS.Show();
            this.Dispose();
        }

        private void btnListstudent_Click(object sender, EventArgs e)
        {
            frmHocsinh frmHS = new frmHocsinh();
            frmHS.Show();
            this.Dispose();
        }

        private void btnHuongdan_Click(object sender, EventArgs e)
        {
            frmHuongdan frm = new frmHuongdan();
            frm.Show();
            this.Dispose();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.H)
            {
                frmHuongdan frm = new frmHuongdan();
                frm.Show();
                this.Dispose();
            }
        }

        private void btnF1_Click(object sender, EventArgs e)
        {
            frmHuongdan frm = new frmHuongdan();
            frm.Show();
            this.Dispose();
        }

        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
