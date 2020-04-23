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
    public partial class BaoHiemForm : Form {
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();
        DBAccess access = new DBAccess();
        DataTable table;
        string MaSBH = "-1", MaNV, MaLuong, NgayCapSo, NoiCapSo;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridView1.Rows[index];
            MaNV = selectRow.Cells[1].Value.ToString().Trim();
            MaLuong = selectRow.Cells[2].Value.ToString().Trim();
            NgayCapSo = selectRow.Cells[3].Value.ToString().Trim();
            NoiCapSo = selectRow.Cells[4].Value.ToString().Trim();
            MaSBH = selectRow.Cells[0].Value.ToString().Trim();

            txtMaBaoHiem.Text = MaSBH;
            txtNoiCap.Text = NoiCapSo;
            cbMaLuong.Text = MaLuong;
            cbMaNV.Text = MaNV;
        }

        public BaoHiemForm() {
            InitializeComponent();
            addData();
            init();
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
                list.Add(dr.GetString(0).ToString());
            }
            cb.DataSource = list;
            conn.Close();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MaSBH = txtMaBaoHiem.Text.Trim();
            MaNV = cbMaNV.Text.Trim();
            MaLuong = cbMaLuong.Text.Trim();
            NgayCapSo = dtpNgayCap.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
            NoiCapSo = txtNoiCap.Text.Trim();
            if(MaSBH.Equals("") || MaNV.Equals("") || MaLuong.Equals("") || NgayCapSo.Equals("") || NoiCapSo.Equals(""))
            {
                MessageBox.Show("Nhap Thieu Thong Tin");
            }
            else
            {
                conn.Open();
                table = new DataTable();
                string queryInsert = "INSERT INTO dbo.TblSoBH( MaSoBH ,MaNV ,MaLuong ,NgayCapSo ,NoiCapSo)VALUES  ( '"+MaSBH+"' ,'"+MaNV+"' ,'"+MaLuong+"' ,'"+NgayCapSo+"' ,N'"+NoiCapSo+"')";
                cmd = new SqlCommand(queryInsert, conn);
                cmd.CommandType = CommandType.Text;
                int i = cmd.ExecuteNonQuery();
                if(i != 0)
                {
                    MessageBox.Show("Them Bao Hiem Thanh Cong");
                    conn.Close();
                    GetData("SELECT * FROM dbo.TblSoBH", dataGridView1, table);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            MaSBH = txtMaBaoHiem.Text.Trim();
            MaNV = cbMaNV.Text.Trim();
            MaLuong = cbMaLuong.Text.Trim();
            NgayCapSo = dtpNgayCap.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
            NoiCapSo = txtNoiCap.Text.Trim();
            if (MaSBH.Equals("") || MaNV.Equals("") || MaLuong.Equals("") || NgayCapSo.Equals("") || NoiCapSo.Equals(""))
            {
                MessageBox.Show("Nhap Thieu Thong Tin");
            }
            else
            {
                conn.Close();              
                conn.Open();
                table = new DataTable();
                string queryInsert = "UPDATE dbo.TblSoBH SET MaSoBH = '" + MaSBH + "', MaNV = '" + MaNV + "', MaLuong = '" + MaLuong + "', NgayCapSo = '" + NgayCapSo + "', NoiCapSo = N'" + NoiCapSo + "' WHERE MaSoBH = '" + MaSBH + "'";
                cmd = new SqlCommand(queryInsert, conn);
                cmd.CommandType = CommandType.Text;
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Sửa Bao Hiem Thanh Cong");
                    conn.Close();
                    GetData("SELECT * FROM dbo.TblSoBH", dataGridView1, table);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MaSBH.Equals("-1"))
            {
                MessageBox.Show("Chua Chon Phong Ban De Xoa");
            }
            else
            {
                table = new DataTable();
                string query1 = "DELETE dbo.TblSoBH WHERE MaSoBH = '" + MaSBH + "'";
                GetData(query1, dataGridView1, table);
                GetData("SELECT * FROM dbo.TblSoBH", dataGridView1, table);
                MessageBox.Show("Xoa Thanh Cong");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addData()
        {
            List<string> listMNV = new List<string>();
            List<string> listML = new List<string>();
            addComboBoxString(conn, cmd, listML, "MaLuong", "TblBangCongNVCB", cbMaLuong);
            addComboBoxInt(conn, cmd, listMNV, "MaNV", "TblTTNVCoBan", cbMaNV);
            
        }
        private void GetData(string query, DataGridView grid, DataTable table)
        {
            access.createConn();
            adt = new SqlDataAdapter(query, conn);
            adt.Fill(table);
            grid.DataSource = table;
            conn.Close();
        }

        private void BaoHiemForm_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            GetData("SELECT * FROM dbo.TblSoBH", dataGridView1, table);
        }


        private void init()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            if (LoginForm.quyen.Equals("admin"))
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }
    }
}
