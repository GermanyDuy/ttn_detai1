using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTNhom {
    public partial class LuongNVForm : Form {

        DBAccess access = new DBAccess();
        DataTable table;

        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();

        int maNV = -1;
        int maPhong, LCB, phuCap, ngayCong, ngayNghi;
        string maLuong, thuong, kyLuat;

        List<string> listMaNV = new List<string>();
        List<string> listPhong = new List<string>();
        public LuongNVForm() {
            InitializeComponent();
            addComboBox(conn , cmd , listMaNV , "MaNV" , "TblBangCongNVCB" , comboBoxMaNV);
            addComboBox(conn , cmd , listPhong , "MaPhong" , "TblPhongBan" , comboBoxPhong);
            addData();
        }

        private void button2_Click(object sender , EventArgs e) {
            this.Close();
        }

        private void buttonTong_Click(object sender , EventArgs e) {

        }

        private void GetData(string query , DataGridView grid , DataTable table) {
            access.createConn();
            adt = new SqlDataAdapter(query , conn);
            adt.Fill(table);
            grid.DataSource = table;
            conn.Close();
        }
        private void addComboBox(SqlConnection conn , SqlCommand cmd , List<string> list , string tenCot , string tenTable , ComboBox cb) {
            conn.Open();
            cmd = new SqlCommand("Select " + tenCot + " From " + tenTable , conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read()) {
                list.Add(dr.GetValue(0).ToString());
            }
            cb.DataSource = list;
            conn.Close();
        }
        private void addData() {
            table = new DataTable();
            GetData("select * from TblBangCongNVCB" , tableMain , table);
        }

        private void tableMain_CellClick(object sender , DataGridViewCellEventArgs e) {
            int index = e.RowIndex;
            DataGridViewRow selectRow = tableMain.Rows[index];
            maNV = int.Parse(selectRow.Cells[0].Value.ToString().Trim());
            maPhong = int.Parse(selectRow.Cells[1].Value.ToString().Trim());
            maLuong = selectRow.Cells[2].Value.ToString().Trim();
            LCB = int.Parse(selectRow.Cells[3].Value.ToString().Trim());
            phuCap = int.Parse(selectRow.Cells[4].Value.ToString().Trim());
            thuong = selectRow.Cells[5].Value.ToString().Trim();
            kyLuat = selectRow.Cells[6].Value.ToString().Trim();
            ngayCong = int.Parse(selectRow.Cells[7].Value.ToString().Trim());
            ngayNghi = int.Parse(selectRow.Cells[8].Value.ToString().Trim());

            textBoxMaLuong.Text = maLuong.ToString();
            textBoxLuongCB.Text = LCB.ToString();
            textBoxPhuCap.Text = phuCap.ToString();
            textBoxNgayNghi.Text = ngayNghi.ToString();
            textBoxNgayCong.Text = ngayCong.ToString();
            textBoxThuong.Text = thuong;
            textBoxKyLuat.Text = kyLuat;
            comboBoxMaNV.SelectedIndex = comboBoxMaNV.FindStringExact(maNV.ToString());
            comboBoxPhong.SelectedIndex = comboBoxPhong.FindStringExact(maPhong.ToString());
        }
        private void btnXoa_Click(object sender , EventArgs e) {
            if(maNV == -1) {
                MessageBox.Show("Chưa chọn nhân viên nào để xoá");
            }
            else {
                table = new DataTable();
                string query1 = "UPDATE dbo.TblSoBH SET maLuong = NULL WHERE maLuong = '" + maLuong + "'";
                string query2 = "DELETE dbo.TblBangCongNVCB WHERE maNV = " + maNV;

                GetData(query1 , tableMain , table);
                GetData(query2 , tableMain , table);
                GetData("select * from TblBangCongNVCB" , tableMain , table);
                MessageBox.Show("Done");

            }
        }
        private void btnSua_Click(object sender , EventArgs e) {
            table = new DataTable();
            maNV = int.Parse(comboBoxMaNV.Text.ToString());
            maPhong = int.Parse(comboBoxPhong.Text.ToString());
            maLuong = textBoxMaLuong.Text.Trim();
            thuong = textBoxThuong.Text.Trim();
            kyLuat = textBoxKyLuat.Text.Trim();
            ngayCong = int.Parse(textBoxNgayCong.Text.ToString());
            ngayNghi = int.Parse(textBoxNgayNghi.Text.ToString());

            if(maLuong.Equals("") || thuong.Equals("") || kyLuat.Equals("") || ngayCong.Equals(null) || ngayNghi.Equals(null)) {
                MessageBox.Show("Thieu Thong tin");
            }
            else {
                string query = "UPDATE dbo.TblBangCongNVCB SET MaNV ='" + maNV + "' , MaPhong = '" + maPhong + "', MaLuong = '" + maLuong + "' , Thuong = N'" + thuong + "' , KyLuat = N'" + kyLuat + "' , SoNgaycong = '" + ngayCong + "' ,SoNgayNghi = '"+ ngayNghi + "' WHERE MaNV = '" + maNV + "'";
                GetData(query , tableMain , table);
                GetData("select * from TblBangCongNVCB" , tableMain , table);
                MessageBox.Show("Done");
            }
        }
    }
}
