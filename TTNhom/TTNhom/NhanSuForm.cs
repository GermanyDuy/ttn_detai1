using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTNhom {
    public partial class NhanSuForm : Form {
        DBAccess access = new DBAccess();
        DataTable table;

        
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();
        List<string> listMP = new List<string>();
        List<string> listML = new List<string>();

        string maNV = "", ten, ngaySinh, cmt, chucVu, thoiGian, ngayKy, ngayHetHan, GioiTinh, MaLuong;

        private void ButtonSua_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            if(CheckThieuThongTin() == false)
            {
                
                    string queryUpdate = "UPDATE dbo.TblTTNVCoBan SET MaPhong = '"+cbMaPhong.Text+"', HoTen = N'"+ten+"', NgaySinh = '"+ngaySinh+"', GioiTinh = N'"+GioiTinh+"', CMTND = N'"+cmt+"', ChucVu = N'"+chucVu+"', ThoiGian = N'"+thoiGian+"', NgayKy = '"+ngayKy+"', NgayHetHan = '"+ngayHetHan+"', MaLuong = N'"+MaLuong+"' WHERE MaNV = '"+maNV+"'";
                    GetData(queryUpdate, dataGridView1, table);
                    GetData("select * from TblTTNVCoBan", dataGridView1, table);
                    MessageBox.Show("done");
                
            }
        }

        private void ButtonXoa_Click(object sender, EventArgs e)
        {
            if(maNV == "")
            {
                MessageBox.Show("ban chua chon nhan vien");
            }
            else
            {
                string queryDelete = "Delete TblTTNVCoBan where MaNV = '" + maNV + "'";
                GetData(queryDelete, dataGridView1, table);
                GetData("select * from TblTTNVCoBan", dataGridView1, table);
                MessageBox.Show("done");
            }
        }

        private void ButtonThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ButtonThem_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            if(CheckThieuThongTin() == false)
            {
                
                string queryCheck = "select * from TblTTNVCoBan where  CMTND = N'"+cmt+"'  ";
                access.readDataToAdapter(queryCheck, table);
                int a = table.Rows.Count;
                if (a != 0)
                {
                    MessageBox.Show("so chung minh thu bi trung");

                }
                else
                {
                    string queryInsert = "INSERT dbo.TblTTNVCoBan VALUES  " +
                            "( '" + cbMaPhong.Text + "' , N'" + ten + "' ,  '" + ngaySinh + "' , N'" + GioiTinh + "' ,  N'" + cmt + "' , N'" + chucVu + "' , N'" + thoiGian + "' , '" + ngayKy + "' , '" + ngayHetHan + "' ,N'" + MaLuong + "'  )";
                    GetData(queryInsert, dataGridView1, table);
                    GetData("select * from TblTTNVCoBan", dataGridView1, table);
                    MessageBox.Show("done");
                    
                }
                
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectRow = dataGridView1.Rows[index];

                cbMaPhong.SelectedIndex = cbMaPhong.FindStringExact(selectRow.Cells[0].Value.ToString());
                txtMaNV.Text = selectRow.Cells[0+1].Value.ToString();
                txtHoTen.Text = selectRow.Cells[1 + 1].Value.ToString();
                dateTimePickerNgaySinh.Value = Convert.ToDateTime(selectRow.Cells[2 + 1].Value.ToString());
                cbGioiTinh.SelectedIndex = cbGioiTinh.FindStringExact(selectRow.Cells[3 + 1].Value.ToString());
                txtCMTND.Text = selectRow.Cells[4 + 1].Value.ToString();
                txtChucVu.Text = selectRow.Cells[5 + 1].Value.ToString();
                txtThoiGian.Text = selectRow.Cells[6 + 1].Value.ToString();
                dateTimePickerNgayKy.Value = Convert.ToDateTime(selectRow.Cells[7 + 1].Value.ToString());
                dateTimePickerNgayHH.Value = Convert.ToDateTime(selectRow.Cells[8 + 1].Value.ToString());
                cbMaLuong.SelectedIndex = cbMaLuong.FindStringExact(selectRow.Cells[9 + 1].Value.ToString().Trim());

                maNV = txtMaNV.Text;
            }
            catch
            {

            }
        }

        private void NhanSuForm_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            GetData("select * from TblTTNVCoBan", dataGridView1, table);
        }

        public NhanSuForm() {
            InitializeComponent();
            dateTimePickerNgayKy.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayKy.CustomFormat = "yyyy-MM-dd";
            dateTimePickerNgayHH.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayHH.CustomFormat = "yyyy-MM-dd";
            init();
        }

        private void init()
        {
            addComboBoxInt(conn, cmd, listMP, "MaPhong", "TblPhongBan", cbMaPhong);
            addComboBoxString(conn, cmd, listML, "MaLuong", "TblBangCongNVCB", cbMaLuong);
        }

        private void GetData(string query, DataGridView grid, DataTable table)
        {
            access.createConn();
            adt = new SqlDataAdapter(query, conn);
            adt.Fill(table);
            grid.DataSource = table;
            conn.Close();
        }
        private void addComboBoxInt(SqlConnection conn, SqlCommand cmd, List<string> list, string tenCot, string tenTable, ComboBox cb)
        {
            conn.Open();
            cmd = new SqlCommand("Select " + tenCot + " FROM " + tenTable, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(dr.GetInt32(0).ToString());
            }
            cb.DataSource = list;
            conn.Close();
        }
        private void addComboBoxString(SqlConnection conn, SqlCommand cmd, List<string> list, string tenCot, string tenTable, ComboBox cb)
        {
            conn.Open();
            cmd = new SqlCommand("Select " + tenCot + " FROM " + tenTable, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(dr.GetString(0));
            }
            cb.DataSource = list;
            conn.Close();
        }
        private bool CheckThieuThongTin()
        {
            maNV = txtMaNV.Text.Trim();
            ten = txtHoTen.Text.Trim();
            ngaySinh = dateTimePickerNgaySinh.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
            GioiTinh = cbGioiTinh.Text;
            cmt = txtCMTND.Text;
            chucVu = txtChucVu.Text;
            thoiGian = txtThoiGian.Text;
            ngayKy = dateTimePickerNgayKy.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
            ngayHetHan = dateTimePickerNgayHH.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
            MaLuong = cbMaLuong.Text;
            
            //  MessageBox.Show(ngaySinh);
            if (GioiTinh =="" || ten.Equals("") || cmt.Equals("") || chucVu.Equals("")
                || thoiGian.Equals("") )
            {
                MessageBox.Show("Thiếu thông tin !!");
                return true;
            }
            return false;
        }
    }
}
