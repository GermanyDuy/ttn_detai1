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
            this.cmd_exit = new System.Windows.Forms.Button();
            this.panel_show = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemTK = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemQuanLyTK = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemdmk = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNhanSu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTTCN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBaoHiem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPhongBan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLuongNV = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::TTNhom.Properties.Resources.Main;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cmd_exit);
            this.panel1.Controls.Add(this.panel_show);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 561);
            this.panel1.TabIndex = 17;
            // 
            // cmd_exit
            // 
            this.cmd_exit.BackColor = System.Drawing.Color.Transparent;
            this.cmd_exit.BackgroundImage = global::TTNhom.Properties.Resources._133;
            this.cmd_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_exit.FlatAppearance.BorderSize = 0;
            this.cmd_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmd_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmd_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_exit.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_exit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.cmd_exit.Location = new System.Drawing.Point(30, 529);
            this.cmd_exit.Name = "cmd_exit";
            this.cmd_exit.Size = new System.Drawing.Size(75, 23);
            this.cmd_exit.TabIndex = 20;
            this.cmd_exit.Text = "Thoát    \r\n";
            this.cmd_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_exit.UseVisualStyleBackColor = false;
            this.cmd_exit.Click += new System.EventHandler(this.cmd_exit_Click);
            // 
            // panel_show
            // 
            this.panel_show.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_show.Location = new System.Drawing.Point(135, 168);
            this.panel_show.Name = "panel_show";
            this.panel_show.Size = new System.Drawing.Size(757, 384);
            this.panel_show.TabIndex = 19;
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
            this.menuItemQuanLyTK,
            this.menuItemdmk});
            this.menuItemTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemTK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuItemTK.Name = "menuItemTK";
            this.menuItemTK.Size = new System.Drawing.Size(81, 20);
            this.menuItemTK.Text = "&Tài khoản";
            // 
            // menuItemQuanLyTK
            // 
            this.menuItemQuanLyTK.Enabled = false;
            this.menuItemQuanLyTK.Name = "menuItemQuanLyTK";
            this.menuItemQuanLyTK.Size = new System.Drawing.Size(180, 24);
            this.menuItemQuanLyTK.Text = "QLy tài khoản";
            this.menuItemQuanLyTK.Click += new System.EventHandler(this.menuItemQuanLyTK_Click);
            // 
            // menuItemdmk
            // 
            this.menuItemdmk.Name = "menuItemdmk";
            this.menuItemdmk.Size = new System.Drawing.Size(180, 24);
            this.menuItemdmk.Text = "Đổi mật khẩu";
            this.menuItemdmk.Click += new System.EventHandler(this.menuItemdmk_Click);
            // 
            // menuItemDanhMuc
            // 
            this.menuItemDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNhanSu,
            this.menuItemTTCN,
            this.menuItemBaoHiem});
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
            this.menuItemTTCN.Click += new System.EventHandler(this.menuItemTTCN_Click);
            // 
            // menuItemBaoHiem
            // 
            this.menuItemBaoHiem.Name = "menuItemBaoHiem";
            this.menuItemBaoHiem.Size = new System.Drawing.Size(197, 24);
            this.menuItemBaoHiem.Text = "Bảo Hiểm";
            this.menuItemBaoHiem.Click += new System.EventHandler(this.menuItemBaoHiem_Click);
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
            this.menuItemLuongNV});
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
            this.menuItemPhongBan.Click += new System.EventHandler(this.menuItemPhongBan_Click);
            // 
            // menuItemLuongNV
            // 
            this.menuItemLuongNV.Name = "menuItemLuongNV";
            this.menuItemLuongNV.Size = new System.Drawing.Size(186, 24);
            this.menuItemLuongNV.Text = "&Lương Nhân Viên";
            this.menuItemLuongNV.Click += new System.EventHandler(this.menuItemLuongNV_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TTNhom.Properties.Resources._1269825271_system_help;
            this.pictureBox1.Location = new System.Drawing.Point(859, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 20);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_show;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemTK;
        private System.Windows.Forms.ToolStripMenuItem menuItemQuanLyTK;
        private System.Windows.Forms.ToolStripMenuItem menuItemdmk;
        public System.Windows.Forms.ToolStripMenuItem menuItemDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem menuItemNhanSu;
        private System.Windows.Forms.ToolStripMenuItem menuItemTTCN;
        private System.Windows.Forms.ToolStripMenuItem menuItemBaoHiem;
        public System.Windows.Forms.ToolStripMenuItem menuItemChucNang;
        public System.Windows.Forms.ToolStripMenuItem menuItemQuanLy;
        private System.Windows.Forms.ToolStripMenuItem menuItemPhongBan;
        private System.Windows.Forms.ToolStripMenuItem menuItemLuongNV;
        private System.Windows.Forms.Button cmd_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}