using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TTNhom {
    public partial class LoginForm : Form {
        DBAccess dbAccess = new DBAccess();
        DataTable dt = new DataTable();

        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();

        public static string ten;
        public static string quyen;
        public static string Username;

        public LoginForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender , EventArgs e) {
            Username = textBoxUsername.Text;
            string query = "Select * From dbo.tbuser where Username= '" + textBoxUsername.Text + "' and Pass= '" + textBoxPassword.Text + "'";
            dbAccess.readDataToAdapter(query , dt);
            int a = dt.Rows.Count;
            if(a != 0) {
                adt = new SqlDataAdapter(query , conn);
                DataTable table = new DataTable();
                adt.Fill(table);

                ten = table.Rows[0][3].ToString().Trim();
                quyen = table.Rows[0][2].ToString().Trim();

                if(quyen == "admin") {
                    MessageBox.Show("Đăng nhập vào hệ thống (Quyền Admin) !" , "Thông báo !");
                }
                else {
                    MessageBox.Show("Đăng nhập vào hệ thống (Quyền user) !" , "Thông báo !");

                }

                MainForm main = new MainForm();
                main.Show();
            }
            else {
                MessageBox.Show("Tài Khoản hoặc Mật Khẩu không đúng !! Vui Lòng thử lại.");
                textBoxUsername.Clear();
                textBoxPassword.Clear();
                textBoxUsername.Focus();
            }

        }

        private void LoginForm_Load(object sender , EventArgs e) {

        }
    }
}
