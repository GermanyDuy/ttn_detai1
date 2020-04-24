using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTNhom {
    public partial class MainForm : Form {
        
        public static string quyen;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender , EventArgs e) {
            if(quyen == "admin") {
                menuItemDanhMuc.Enabled = true;
                menuItemChucNang.Enabled = true;
                menuItemQuanLy.Enabled = true;
                menuItemQuanLyTK.Enabled = true;
            }
            else if(quyen == "user") {
                menuItemDanhMuc.Enabled = true;
                menuItemChucNang.Enabled = true;
                menuItemQuanLy.Enabled = false;
                menuItemQuanLyTK.Enabled = false;
            }
        }

        private void menuItemChucNang_Click(object sender , EventArgs e) {
            TimkiemForm form = new TimkiemForm();
            panel_show.Show();
            panel_show.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel_show.Controls.Add(form);
            form.Show();
        }

        private void menuItemNhanSu_Click(object sender , EventArgs e) {
            NhanSuForm form = new NhanSuForm();
            panel_show.Show();
            panel_show.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel_show.Controls.Add(form);
            form.Show();
        }

        private void menuItemTTCN_Click(object sender , EventArgs e) {
            ThongTinCaNhanForm form = new ThongTinCaNhanForm();
            panel_show.Show();
            panel_show.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel_show.Controls.Add(form);
            form.Show();
        }

        private void menuItemBaoHiem_Click(object sender , EventArgs e) {
            BaoHiemForm form = new BaoHiemForm();
            panel_show.Show();
            panel_show.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel_show.Controls.Add(form);
            form.Show();
        }

        private void menuItemPhongBan_Click(object sender , EventArgs e) {
            PhongBanForm form = new PhongBanForm();
            panel_show.Show();
            panel_show.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel_show.Controls.Add(form);
            form.Show();
        }

        private void menuItemLuongNV_Click(object sender , EventArgs e) {
            LuongNVForm form = new LuongNVForm();
            panel_show.Show();
            panel_show.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel_show.Controls.Add(form);
            form.Show();
        }

        private void cmd_exit_Click(object sender , EventArgs e) {
            this.Hide();
            LoginForm form = new LoginForm();
            form.Show();
        }

        private void menuItemdmk_Click(object sender , EventArgs e) {
            DoiMatKhauForm form = new DoiMatKhauForm();
            panel_show.Show();
            panel_show.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel_show.Controls.Add(form);
            form.Show();
        }

        private void menuItemQuanLyTK_Click(object sender , EventArgs e) {
            DangKyForm form = new DangKyForm();
            panel_show.Show();
            panel_show.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel_show.Controls.Add(form);
            form.Show();
        }

        private void pictureBox1_Click(object sender , EventArgs e) {
            MessageBox.Show("Chức năng quản lý tài khoản và quản lý không\nđược truy cập trong quyền User" , "Help?");
        }
    }
}
