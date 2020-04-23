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
    public partial class DoiMatKhauForm : Form {
        DBAccess access = new DBAccess();
        DataTable table;

        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();

        public DoiMatKhauForm() {
            InitializeComponent();
        }
        private void GetData(string query , DataTable table) {
            access.createConn();
            adt = new SqlDataAdapter(query , conn);
            adt.Fill(table);
            conn.Close();
        }
        private void buttonQuit_Click(object sender , EventArgs e) {
            this.Close();
        }
        private void buttonDone_Click(object sender , EventArgs e) {
            table = new DataTable();
            string update="update tbuser set Pass='"+textBoxNewpass.Text+"' where(Username=N'"+textBoxUser.Text+"' and Pass='"+textBoxOldpass.Text+"')";
            string user = textBoxUser.Text;
            if (user == "")
            {
                MessageBox.Show("Bạn chưa nhập tên truy cập");
            }
            else
            {
                if (textBoxOldpass.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu");
                }
                else
                {
                    if (textBoxNewpass.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu mới");
                    }
                    else
                    {
                        if (textBoxNewpassAgain.Text == "")
                        {
                            MessageBox.Show("Bạn chưa nhập lại mật khẩu");
                        }
                        else
                        {
                            if (textBoxNewpass.Text == textBoxNewpassAgain.Text)
                            {
                                GetData(update , table);
                                MessageBox.Show("Bạn đã thay đổi mật khẩu thành công");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Bạn nhập lại mật khẩu không đúng");
                            }
                        }
                    }
                }
            }
        }
        private void buttonNhapLai_Click(object sender , EventArgs e) {
            foreach(Control ctr in this.groupBox1.Controls) {
                if((ctr is TextBox)) {
                    ctr.Text = "";
                }
            }
        }
    }
}
