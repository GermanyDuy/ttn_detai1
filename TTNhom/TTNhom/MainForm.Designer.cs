namespace TTNhom {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_show = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemTK = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemQuanLyTK = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemdmk = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNhanSu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTTCN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCheDo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPhongBan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBoPhan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLuongNV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBangLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::TTNhom.Properties.Resources.Main;
            this.panel1.Controls.Add(this.panel_show);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 561);
            this.panel1.TabIndex = 17;
            // 
            // panel_show
            // 
            this.panel_show.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_show.Location = new System.Drawing.Point(135, 168);
            this.panel_show.Name = "panel_show";
            this.panel_show.Size = new System.Drawing.Size(757, 384);
            this.panel_show.TabIndex = 19;
            this.panel_show.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_show_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemTK,
            this.menuItemDanhMuc,
            this.menuItemChucNang,
            this.menuItemQuanLy});
            this.menuStrip1.Location = new System.Drawing.Point(17, 113);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(339, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemTK
            // 
            this.menuItemTK.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDangNhap,
            this.menuItemQuanLyTK,
            this.menuItemdmk});
            this.menuItemTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemTK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuItemTK.Name = "menuItemTK";
            this.menuItemTK.Size = new System.Drawing.Size(81, 20);
            this.menuItemTK.Text = "&Tài khoản";
            // 
            // menuItemDangNhap
            // 
            this.menuItemDangNhap.Name = "menuItemDangNhap";
            this.menuItemDangNhap.Size = new System.Drawing.Size(164, 24);
            this.menuItemDangNhap.Text = "Đăng Nhập";
            // 
            // menuItemQuanLyTK
            // 
            this.menuItemQuanLyTK.Enabled = false;
            this.menuItemQuanLyTK.Name = "menuItemQuanLyTK";
            this.menuItemQuanLyTK.Size = new System.Drawing.Size(164, 24);
            this.menuItemQuanLyTK.Text = "QLy tài khoản";
            // 
            // menuItemdmk
            // 
            this.menuItemdmk.Name = "menuItemdmk";
            this.menuItemdmk.Size = new System.Drawing.Size(164, 24);
            this.menuItemdmk.Text = "Đổi mật khẩu";
            // 
            // menuItemDanhMuc
            // 
            this.menuItemDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNhanSu,
            this.menuItemTTCN,
            this.menuItemCheDo});
            this.menuItemDanhMuc.Enabled = false;
            this.menuItemDanhMuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemDanhMuc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuItemDanhMuc.Name = "menuItemDanhMuc";
            this.menuItemDanhMuc.Size = new System.Drawing.Size(85, 20);
            this.menuItemDanhMuc.Text = "&Danh Mục";
            // 
            // menuItemNhanSu
            // 
            this.menuItemNhanSu.Name = "menuItemNhanSu";
            this.menuItemNhanSu.Size = new System.Drawing.Size(197, 24);
            this.menuItemNhanSu.Text = "Nhân Sự";
            this.menuItemNhanSu.Click += new System.EventHandler(this.menuItemNhanSu_Click);
            // 
            // menuItemTTCN
            // 
            this.menuItemTTCN.Name = "menuItemTTCN";
            this.menuItemTTCN.Size = new System.Drawing.Size(197, 24);
            this.menuItemTTCN.Text = "Thông Tin Cá Nhân";
            // 
            // menuItemCheDo
            // 
            this.menuItemCheDo.Name = "menuItemCheDo";
            this.menuItemCheDo.Size = new System.Drawing.Size(197, 24);
            this.menuItemCheDo.Text = "Chế độ";
            // 
            // menuItemChucNang
            // 
            this.menuItemChucNang.Enabled = false;
            this.menuItemChucNang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemChucNang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuItemChucNang.Name = "menuItemChucNang";
            this.menuItemChucNang.Size = new System.Drawing.Size(72, 20);
            this.menuItemChucNang.Text = "Tra Cứu";
            this.menuItemChucNang.Click += new System.EventHandler(this.menuItemChucNang_Click);
            // 
            // menuItemQuanLy
            // 
            this.menuItemQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPhongBan,
            this.menuItemBoPhan,
            this.menuItemLuongNV,
            this.menuItemBangLuong});
            this.menuItemQuanLy.Enabled = false;
            this.menuItemQuanLy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemQuanLy.Name = "menuItemQuanLy";
            this.menuItemQuanLy.Size = new System.Drawing.Size(74, 20);
            this.menuItemQuanLy.Text = "&Quản Lý";
            // 
            // menuItemPhongBan
            // 
            this.menuItemPhongBan.Name = "menuItemPhongBan";
            this.menuItemPhongBan.Size = new System.Drawing.Size(186, 24);
            this.menuItemPhongBan.Text = "&Phòng ban";
            // 
            // menuItemBoPhan
            // 
            this.menuItemBoPhan.Name = "menuItemBoPhan";
            this.menuItemBoPhan.Size = new System.Drawing.Size(186, 24);
            this.menuItemBoPhan.Text = "&Bộ phận";
            // 
            // menuItemLuongNV
            // 
            this.menuItemLuongNV.Name = "menuItemLuongNV";
            this.menuItemLuongNV.Size = new System.Drawing.Size(186, 24);
            this.menuItemLuongNV.Text = "&Lương Nhân Viên";
            // 
            // menuItemBangLuong
            // 
            this.menuItemBangLuong.Name = "menuItemBangLuong";
            this.menuItemBangLuong.Size = new System.Drawing.Size(186, 24);
            this.menuItemBangLuong.Text = "&Bảng Lương";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(945, 576);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_show;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemTK;
        private System.Windows.Forms.ToolStripMenuItem menuItemDangNhap;
        private System.Windows.Forms.ToolStripMenuItem menuItemQuanLyTK;
        private System.Windows.Forms.ToolStripMenuItem menuItemdmk;
        public System.Windows.Forms.ToolStripMenuItem menuItemDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem menuItemNhanSu;
        private System.Windows.Forms.ToolStripMenuItem menuItemTTCN;
        private System.Windows.Forms.ToolStripMenuItem menuItemCheDo;
        public System.Windows.Forms.ToolStripMenuItem menuItemChucNang;
        public System.Windows.Forms.ToolStripMenuItem menuItemQuanLy;
        private System.Windows.Forms.ToolStripMenuItem menuItemPhongBan;
        private System.Windows.Forms.ToolStripMenuItem menuItemBoPhan;
        private System.Windows.Forms.ToolStripMenuItem menuItemLuongNV;
        private System.Windows.Forms.ToolStripMenuItem menuItemBangLuong;
    }
}