namespace TTNhom {
    partial class LuongNVForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LuongNVForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableMain = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonTong = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label64 = new System.Windows.Forms.Label();
            this.comboBoxPhong = new System.Windows.Forms.ComboBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.textBoxKyLuat = new System.Windows.Forms.TextBox();
            this.textBoxThuong = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.textBoxTong = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.textBoxMaLuong = new System.Windows.Forms.TextBox();
            this.comboBoxMaNV = new System.Windows.Forms.ComboBox();
            this.textBoxNgayCong = new System.Windows.Forms.TextBox();
            this.textBoxPhuCap = new System.Windows.Forms.TextBox();
            this.textBoxLuongCB = new System.Windows.Forms.TextBox();
            this.textBoxNgayNghi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableMain)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableMain);
            this.panel2.Location = new System.Drawing.Point(12, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 137);
            this.panel2.TabIndex = 8;
            // 
            // tableMain
            // 
            this.tableMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableMain.Location = new System.Drawing.Point(3, 3);
            this.tableMain.Name = "tableMain";
            this.tableMain.Size = new System.Drawing.Size(724, 129);
            this.tableMain.TabIndex = 0;
            this.tableMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableMain_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonTong);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.buttonXoa);
            this.groupBox3.Controls.Add(this.buttonSua);
            this.groupBox3.Location = new System.Drawing.Point(15, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(720, 51);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Các chức năng";
            // 
            // buttonTong
            // 
            this.buttonTong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTong.BackgroundImage")));
            this.buttonTong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTong.FlatAppearance.BorderSize = 0;
            this.buttonTong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonTong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonTong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTong.Image = global::TTNhom.Properties.Resources.TinhLuong;
            this.buttonTong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTong.Location = new System.Drawing.Point(475, 14);
            this.buttonTong.Name = "buttonTong";
            this.buttonTong.Size = new System.Drawing.Size(92, 33);
            this.buttonTong.TabIndex = 6;
            this.buttonTong.Text = "Tính lương";
            this.buttonTong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTong.UseVisualStyleBackColor = true;
            this.buttonTong.Click += new System.EventHandler(this.buttonTong_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(601, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Thoát ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonXoa.BackgroundImage")));
            this.buttonXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonXoa.FlatAppearance.BorderSize = 0;
            this.buttonXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoa.Image = ((System.Drawing.Image)(resources.GetObject("buttonXoa.Image")));
            this.buttonXoa.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonXoa.Location = new System.Drawing.Point(365, 16);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(77, 29);
            this.buttonXoa.TabIndex = 2;
            this.buttonXoa.Text = "Xóa   ";
            this.buttonXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSua.BackgroundImage")));
            this.buttonSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSua.FlatAppearance.BorderSize = 0;
            this.buttonSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSua.Image = ((System.Drawing.Image)(resources.GetObject("buttonSua.Image")));
            this.buttonSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSua.Location = new System.Drawing.Point(232, 16);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(77, 29);
            this.buttonSua.TabIndex = 1;
            this.buttonSua.Text = "Sửa   ";
            this.buttonSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label64);
            this.groupBox4.Controls.Add(this.comboBoxPhong);
            this.groupBox4.Controls.Add(this.label57);
            this.groupBox4.Controls.Add(this.label56);
            this.groupBox4.Controls.Add(this.textBoxKyLuat);
            this.groupBox4.Controls.Add(this.textBoxThuong);
            this.groupBox4.Controls.Add(this.label54);
            this.groupBox4.Controls.Add(this.textBoxTong);
            this.groupBox4.Controls.Add(this.label52);
            this.groupBox4.Controls.Add(this.label51);
            this.groupBox4.Controls.Add(this.textBoxMaLuong);
            this.groupBox4.Controls.Add(this.comboBoxMaNV);
            this.groupBox4.Controls.Add(this.textBoxNgayCong);
            this.groupBox4.Controls.Add(this.textBoxPhuCap);
            this.groupBox4.Controls.Add(this.textBoxLuongCB);
            this.groupBox4.Controls.Add(this.textBoxNgayNghi);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Location = new System.Drawing.Point(15, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(720, 160);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ghichu";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(6, 81);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(55, 13);
            this.label64.TabIndex = 24;
            this.label64.Text = "Mã phòng";
            // 
            // comboBoxPhong
            // 
            this.comboBoxPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPhong.FormattingEnabled = true;
            this.comboBoxPhong.Location = new System.Drawing.Point(66, 78);
            this.comboBoxPhong.Name = "comboBoxPhong";
            this.comboBoxPhong.Size = new System.Drawing.Size(123, 21);
            this.comboBoxPhong.TabIndex = 22;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(405, 81);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(40, 13);
            this.label57.TabIndex = 21;
            this.label57.Text = "Kỉ Luật";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(211, 81);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(44, 13);
            this.label56.TabIndex = 20;
            this.label56.Text = "Thưởng";
            // 
            // textBoxKyLuat
            // 
            this.textBoxKyLuat.Location = new System.Drawing.Point(457, 78);
            this.textBoxKyLuat.Name = "textBoxKyLuat";
            this.textBoxKyLuat.Size = new System.Drawing.Size(106, 20);
            this.textBoxKyLuat.TabIndex = 19;
            // 
            // textBoxThuong
            // 
            this.textBoxThuong.Location = new System.Drawing.Point(263, 78);
            this.textBoxThuong.Name = "textBoxThuong";
            this.textBoxThuong.Size = new System.Drawing.Size(106, 20);
            this.textBoxThuong.TabIndex = 18;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(539, 123);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(65, 13);
            this.label54.TabIndex = 15;
            this.label54.Text = "Tổng Lương";
            // 
            // textBoxTong
            // 
            this.textBoxTong.Enabled = false;
            this.textBoxTong.Location = new System.Drawing.Point(611, 123);
            this.textBoxTong.Name = "textBoxTong";
            this.textBoxTong.ReadOnly = true;
            this.textBoxTong.Size = new System.Drawing.Size(89, 20);
            this.textBoxTong.TabIndex = 14;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(11, 55);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(51, 13);
            this.label52.TabIndex = 11;
            this.label52.Text = "Mã lương";
            // 
            // label51
            // 
            this.label51.Location = new System.Drawing.Point(0, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(162, 23);
            this.label51.TabIndex = 0;
            this.label51.Text = "Các thông tin về lương nhân viên";
            // 
            // textBoxMaLuong
            // 
            this.textBoxMaLuong.Location = new System.Drawing.Point(66, 52);
            this.textBoxMaLuong.Name = "textBoxMaLuong";
            this.textBoxMaLuong.ReadOnly = true;
            this.textBoxMaLuong.Size = new System.Drawing.Size(123, 20);
            this.textBoxMaLuong.TabIndex = 10;
            // 
            // comboBoxMaNV
            // 
            this.comboBoxMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaNV.FormattingEnabled = true;
            this.comboBoxMaNV.Location = new System.Drawing.Point(66, 25);
            this.comboBoxMaNV.Name = "comboBoxMaNV";
            this.comboBoxMaNV.Size = new System.Drawing.Size(123, 21);
            this.comboBoxMaNV.TabIndex = 0;
            // 
            // textBoxNgayCong
            // 
            this.textBoxNgayCong.Location = new System.Drawing.Point(457, 52);
            this.textBoxNgayCong.Name = "textBoxNgayCong";
            this.textBoxNgayCong.Size = new System.Drawing.Size(106, 20);
            this.textBoxNgayCong.TabIndex = 6;
            // 
            // textBoxPhuCap
            // 
            this.textBoxPhuCap.Enabled = false;
            this.textBoxPhuCap.Location = new System.Drawing.Point(263, 52);
            this.textBoxPhuCap.Name = "textBoxPhuCap";
            this.textBoxPhuCap.ReadOnly = true;
            this.textBoxPhuCap.Size = new System.Drawing.Size(106, 20);
            this.textBoxPhuCap.TabIndex = 2;
            // 
            // textBoxLuongCB
            // 
            this.textBoxLuongCB.Enabled = false;
            this.textBoxLuongCB.Location = new System.Drawing.Point(263, 25);
            this.textBoxLuongCB.Name = "textBoxLuongCB";
            this.textBoxLuongCB.ReadOnly = true;
            this.textBoxLuongCB.Size = new System.Drawing.Size(106, 20);
            this.textBoxLuongCB.TabIndex = 1;
            // 
            // textBoxNgayNghi
            // 
            this.textBoxNgayNghi.Location = new System.Drawing.Point(457, 26);
            this.textBoxNgayNghi.Name = "textBoxNgayNghi";
            this.textBoxNgayNghi.Size = new System.Drawing.Size(106, 20);
            this.textBoxNgayNghi.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(379, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Số ngày công ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(209, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Phụ Cấp";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(215, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "LCB";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(387, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Số ngày nghỉ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(11, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "MaNV";
            // 
            // LuongNVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(770, 400);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LuongNVForm";
            this.Text = "LuongNVForm";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableMain)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tableMain;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonTong;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBoxPhong;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox textBoxKyLuat;
        private System.Windows.Forms.TextBox textBoxThuong;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox textBoxTong;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox textBoxMaLuong;
        private System.Windows.Forms.ComboBox comboBoxMaNV;
        private System.Windows.Forms.TextBox textBoxNgayCong;
        private System.Windows.Forms.TextBox textBoxPhuCap;
        private System.Windows.Forms.TextBox textBoxLuongCB;
        private System.Windows.Forms.TextBox textBoxNgayNghi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label64;
    }
}