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
using System.Text.RegularExpressions;

namespace TTNhom {
    public partial class TimkiemForm : Form {
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();
        DBAccess access = new DBAccess();
        DataTable table;
        List<string> list = new List<string>();

        public TimkiemForm() {
            InitializeComponent();
            table = new DataTable();
            string query = "Select * From tblTTNVCoBan";
            GetData(query, dataGridView1, table);        }

        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        private void GetData(string query, DataGridView grid, DataTable table)
        {
            access.createConn();
            adt = new SqlDataAdapter(query, conn);
            adt.Fill(table);
            grid.DataSource = table;
            conn.Close();
        }

        private void addComboBox(SqlConnection conn, SqlCommand cmd, List<string> list, string tenCot, string tenTable, ComboBox cb)
        {
            conn.Open();
            cmd = new SqlCommand("Select " + tenCot + " From " + tenTable, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(dr.GetValue(0).ToString());
            }
            cb.DataSource = list;
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            table = new DataTable();
            string key = textBox1.Text.Trim();
            if (key.Equals(""))
            {
                GetData("SELECT * FROM tblTTNVCoBan", dataGridView1, table);
            }
            else
            {
                if (IsNumber(key))
                {
                    string queryID = "SELECT * FROM tblTTNVCoBan WHERE MaPhong = " + key + " "+
                        "OR MaNV = " + key + " ";
                    GetData(queryID, dataGridView1, table);
                }
                string query =
                    "SELECT * FROM tblTTNVCoBan WHERE HoTen LIKE N'%" + key + "%' " +
                    " OR GioiTinh LIKE N'%" + key + "%'" +
                    " OR CMTND LIKE N'%" + key + "%'" +
                    " OR ThoiGian LIKE N'%" + key + "%'" +
                    " OR MaLuong LIKE N'%" + key + "%'";
                GetData(query, dataGridView1, table);
            }
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            DataView dv = table.DefaultView;
            string NgaySinh = dateTimePickerDob.Text;
            string DangKyHD = dateTimePickerHD.Text;
            string ChucVu = comboBox1.Text;
            string key = textBox1.Text.Trim();
            if (key.Equals(""))
            {
                GetData("SELECT * FROM tblTTNVCoBan", dataGridView1, table);
            }
            else
            {
                if (IsNumber(key))
                {
                    string queryID = "SELECT * FROM tblTTNVCoBan WHERE MaPhong = " + key + " " +
                        "OR MaNV = " + key + " ";
                    GetData(queryID, dataGridView1, table);
                }
                string query =
                    "SELECT * FROM tblTTNVCoBan WHERE HoTen LIKE N'%" + key + "%' " +
                    " OR GioiTinh LIKE N'%" + key + "%'" +
                    " OR CMTND LIKE N'%" + key + "%'" +
                    " OR ThoiGian LIKE N'%" + key + "%'" +
                    " OR MaLuong LIKE N'%" + key + "%'";
                GetData(query, dataGridView1, table);
            }
            if (!NgaySinh.Equals(" "))
            {
                dv.RowFilter = string.Format(" NgaySinh = '" + Convert.ToDateTime(NgaySinh) + "' ");
                dataGridView1.DataSource = dv.ToTable();
            }
            if (!DangKyHD.Equals(" "))
            {
                dv.RowFilter = string.Format(" NgayKy = '" + Convert.ToDateTime(DangKyHD) + "' ");
                dataGridView1.DataSource = dv.ToTable();
            }
            if (!ChucVu.Equals(""))
            {
                dv.RowFilter = string.Format(" ChucVu = '" + ChucVu + "' ");
                dataGridView1.DataSource = dv.ToTable();
            }
        }

        private void dateTimePickerHD_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerHD.Format = DateTimePickerFormat.Custom;
            dateTimePickerHD.CustomFormat = "yyyy-MM-dd";
        }

        private void dateTimePickerDob_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerDob.Format = DateTimePickerFormat.Custom;
            dateTimePickerDob.CustomFormat = "yyyy-MM-dd";
        }
    }
}
