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
    public partial class PhongBanForm : Form {
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();
        DBAccess access = new DBAccess();
        DataTable table;
        int maPB = -1;
        string tenPB;
        public PhongBanForm() {
            InitializeComponent();
        }

        private void GetData(string query, DataGridView grid, DataTable table)
        {
            access.createConn();
            adt = new SqlDataAdapter(query, conn);
            adt.Fill(table);
            grid.DataSource = table;
            conn.Close();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            tenPB = txtTenPB.Text.Trim();
            if (tenPB.Equals(""))
                MessageBox.Show("Nhap Thieu Thong Tin");
            else
            {
                conn.Open();
                table = new DataTable();
                string queryInsert = "INSERT dbo.TblPhongBan( TenPhong ) VALUES  ( N'"+tenPB+"')";
                cmd = new SqlCommand(queryInsert, conn);
                cmd.CommandType = CommandType.Text;
                int i = cmd.ExecuteNonQuery();
                if(i != 0)
                {
                    MessageBox.Show("Them Phong Ban Thanh Cong");
                    conn.Close();
                    string query = "SELECT * FROM dbo.TblPhongBan";
                    GetData(query, dataGridView1, table);
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            tenPB = txtTenPB.Text.Trim();
            if (tenPB.Equals(""))
                MessageBox.Show("Nhap Thieu Thong Tin");
            else
            {
                conn.Open();
                table = new DataTable();
                string queryInsert = "UPDATE dbo.TblPhongBan SET TenPhong = N'" + tenPB + "' WHERE MaPhong = '" + maPB + "'";
                cmd = new SqlCommand(queryInsert, conn);
                cmd.CommandType = CommandType.Text;
                int i = cmd.ExecuteNonQuery();
                if (i!=0){
                    MessageBox.Show("Sua Thanh Cong");
                    conn.Close();
                    string query = "SELECT * FROM dbo.TblPhongBan";
                    GetData(query, dataGridView1, table); 
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(maPB == -1)
            {
                MessageBox.Show("Chua Chon Phong Ban De Xoa");
            }
            else
            {
                table = new DataTable();
                string query1 = "UPDATE dbo.TblTTNVCoBan SET MaPhong = NULL WHERE MaPhong = '"+maPB+"'";
                string query2 = "UPDATE  dbo.TblBangCongNVCB SET MaPhong = NULL WHERE MaPhong = '"+maPB+"'";
                string query3 = "DELETE dbo.TblPhongBan WHERE MaPhong = '"+maPB+"'";
                GetData(query1, dataGridView1, table);
                GetData(query2, dataGridView1, table);
                GetData(query3, dataGridView1, table);
                GetData("SELECT * FROM dbo.TblPhongBan", dataGridView1, table);
                MessageBox.Show("Xoa Thanh Cong");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Show(object sender, EventArgs e)
        {
            table = new DataTable();
            GetData("SELECT * FROM dbo.TblPhongBan", dataGridView1, table);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridView1.Rows[index];
            tenPB = selectRow.Cells[1].Value.ToString();
            maPB = int.Parse(selectRow.Cells[0].Value.ToString());

            txtTenPB.Text = tenPB;
            txtMaP.Text = maPB.ToString();
        }

        private void pictureBox1_Click(object sender , EventArgs e) {
            MessageBox.Show("Chức năng quản lý phòng ban cho Admin","Help?");
        }
    }
}
