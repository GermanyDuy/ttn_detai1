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
    public partial class DangKyForm : Form {

        DBAccess access = new DBAccess();
        DataTable table;

        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();

        string user, password, name, quyen;
        public DangKyForm() {
            InitializeComponent();
            addData();
        }
        private void GetData(string query , DataGridView grid , DataTable table) {
            access.createConn();
            adt = new SqlDataAdapter(query , conn);
            adt.Fill(table);
            grid.DataSource = table;
            conn.Close();
        }
        private void addData() {
            table = new DataTable();
            GetData("select * from tbuser" , tableMain , table);
        }
        private void buttonThem_Click(object sender , EventArgs e) {
            user = textBoxUser.Text.Trim();
            password= textBoxPass.Text;
            name= textBoxName.Text.Trim();
            quyen = comboBoxQuyen.Text.Trim();
            //maLop = queryID(cmd , "id" , "classes" , "class_name" , tenLop);
            //if(tenLop.Equals("")) {
            //    MessageBox.Show("Nhập thiếu thông tin!");
            //}
            //else if(maLop != null && soHS < 10) {
            //    MessageBox.Show("Tên lớp đã tồn tại hoặc số lượng học sinh nhỏ hơn 10!");
            //}
            //else {
            //    maGVCN = queryID(cmd , "id" , "teachers" , "teacher_name" , tenGVCN);
            //    conn.Open();
            //    string queryInsert = "INSERT INTO dbo.classes (class_name , student_amount , homeroom_teacher_id) VALUES(N'" + tenLop + "'," + soHS + "," + maGVCN + ")";
            //    cmd = new SqlCommand(queryInsert , conn);
            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //    MessageBox.Show("Thêm lớp thành công");
            //}
        }
        private void buttonXoa_Click(object sender , EventArgs e) {
            if(user.Equals("")) {
                MessageBox.Show("Chưa chọn user nào để xoá");
            }
            else {
                table = new DataTable();
                string query1 = "DELETE dbo.tbuser WHERE Username = " + user;
                GetData(query1 , tableMain , table);
                GetData("select * from tbuser" , tableMain , table);
                MessageBox.Show("Done");

            }
        }
        private void tableMain_CellClick(object sender , DataGridViewCellEventArgs e) {
            int index = e.RowIndex;
            DataGridViewRow selectRow = tableMain.Rows[index];
            user= selectRow.Cells[0].Value.ToString().Trim();
            password= selectRow.Cells[1].Value.ToString().Trim();
            quyen= selectRow.Cells[2].Value.ToString().Trim();
            name= selectRow.Cells[3].Value.ToString().Trim();

            textBoxUser.Text = user;
            textBoxPass.Text = password;
            textBoxName.Text = name;
            comboBoxQuyen.SelectedIndex = comboBoxQuyen.FindStringExact(quyen);
        }
        private void button2_Click(object sender , EventArgs e) {
            this.Close();
        }
        private void buttonNhaplai_Click(object sender , EventArgs e) {
            foreach(Control ctr in this.groupBox1.Controls) {
                if((ctr is TextBox)) {
                    ctr.Text = "";
                }
            }
        }
    }
}
