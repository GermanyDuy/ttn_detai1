﻿using System;
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
        public int k = 1;

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
                menuItemQuanLy.Enabled = true;
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

        private void panel_show_Paint(object sender , PaintEventArgs e) {
            ThongTinCaNhanForm form = new ThongTinCaNhanForm();
            panel_show.Show();
            panel_show.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel_show.Controls.Add(form);
            form.Show();
        }
    }
}