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
    public partial class ThongTinCaNhanForm : Form
    {
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();
        DBAccess access = new DBAccess();
        DataTable table;

        string noisinh, diachi, sdt, dantoc, tongiao, quoctich, hocvan;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            manv = txtMaNV.Text;
            if (manv.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn 'Mã Nhân Viên' để thực hiện Xóa");
            }
            else
            {
                table = new DataTable();
                string queryDelete = "delete dbo.TblTTCaNhan where MaNV = N'" + manv + "' ";
                GetData(queryDelete, dataGridView1, table);
                GetData("select * from dbo.TblTTCaNhan", dataGridView1, table);
                MessageBox.Show("Done");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            noisinh = txtNoiSinh.Text;
            diachi = txtDiachi.Text;
            sdt = txtSDT.Text;
            dantoc = txtDantoc.Text;
            tongiao = txtTonGiao.Text;
            quoctich = txtQuoctich.Text;
            hocvan = txtHocVan.Text;

            if (noisinh.Equals("") || diachi.Equals("") || sdt.Equals("") || dantoc.Equals("") || tongiao.Equals("") || quoctich.Equals("") || hocvan.Equals(""))
            {
                MessageBox.Show("Thiếu Thông tin !!!");

            }
            else
            {
                string query = "UPDATE dbo.TblTTCaNhan SET " +
                "NoiSinh = N'" + noisinh + "', DiaChi = N'" + diachi + "', SDT = '" + sdt + "', DanToc = N'" + dantoc + "', TonGiao = N'" + tongiao + "', QuocTich = N'" + quoctich + "', HocVan = N'" + hocvan + "' " +
                "WHERE MaNV = '" + manv + "'  ";
                GetData(query, dataGridView1, table);
                GetData("select * from dbo.TblTTCaNhan", dataGridView1, table);
                MessageBox.Show("Done");
            }
        }

        public static string manv;

        private void btnThem_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            manv = txtMaNV.Text;
            noisinh = txtNoiSinh.Text;
            diachi = txtDiachi.Text;
            sdt = txtSDT.Text;
            dantoc = txtDantoc.Text;
            tongiao = txtTonGiao.Text;
            quoctich = txtQuoctich.Text;
            hocvan = txtHocVan.Text;

            if (manv.Equals("") || noisinh.Equals("") || diachi.Equals("") || sdt.Equals("") || dantoc.Equals("") || tongiao.Equals("") || quoctich.Equals("") || hocvan.Equals(""))
            {
                MessageBox.Show("Thiếu Thông tin !!!");

            }
            else if (manv != NhanSuForm.maNV)
            {
                MessageBox.Show("Mã NV này không tồn tại !!!");
            }
            else
            {
                string queryInsert = "INSERT dbo.TblTTCaNhan VALUES  " +
                            "( '" + txtMaNV.Text + "' , N'" + noisinh + "' ,  '" + diachi + "' , N'" + sdt + "' ,  N'" + dantoc + "' , N'" + tongiao + "' , N'" + quoctich + "' , N'" + hocvan + "')";
                GetData(queryInsert, dataGridView1, table);
                GetData("select * from TblTTCaNhan", dataGridView1, table);
                MessageBox.Show("done");

            }
        }

        string quyen;
        List<string> list = new List<string>();
        public ThongTinCaNhanForm()
        {
            InitializeComponent();
            table = new DataTable();
            string query = "Select * From TblTTCaNhan";
            GetData(query, dataGridView1, table);

            quyen = LoginForm.quyen;
            if (quyen == "admin")
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
            }
            else
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = false;
            }
        }
        private void GetData(string query, DataGridView grid, DataTable table)
        {
            access.createConn();
            adt = new SqlDataAdapter(query, conn);
            adt.Fill(table);
            grid.DataSource = table;
            conn.Close();
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridView1.Rows[index];

            manv = selectRow.Cells[0].Value.ToString();
            noisinh = selectRow.Cells[1].Value.ToString();
            diachi = selectRow.Cells[2].Value.ToString();
            sdt = selectRow.Cells[3].Value.ToString();
            dantoc = selectRow.Cells[4].Value.ToString();
            tongiao = selectRow.Cells[5].Value.ToString();
            quoctich = selectRow.Cells[6].Value.ToString();
            hocvan = selectRow.Cells[7].Value.ToString();

            txtMaNV.Text = manv;
            txtNoiSinh.Text = noisinh;
            txtDiachi.Text = diachi;
            txtSDT.Text = sdt;
            txtDantoc.Text = dantoc;
            txtTonGiao.Text = tongiao;
            txtQuoctich.Text = quoctich;
            txtHocVan.Text = hocvan;

        }
        private void addComboBox(SqlConnection conn, SqlCommand cmd, List<string> list, string tenCot, string tenTable, ComboBox cb)
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
    }
}
