using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_fial
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string usernamefromdb;

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "" | textBoxpw1.Text == "" | textBoxpw2.Text == "")
            {
                MessageBox.Show("โปรดระบุข้อมูลให้ครบถ้วน");
            }
            else if (textBoxpw1.Text != textBoxpw2.Text)
            {
                MessageBox.Show("กรอกรหัสผ่านของคุณให้ตรงกัน");
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project_final");
                conn.Open();
                string sql = "SELECT * FROM login WHERE Username = '"+ textBoxUser.Text + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                bool check = false;
                while (reader.Read())
                {
                    usernamefromdb = reader.GetString("username");
                    check = true;
                }
                conn.Close();

                if (check == true)
                {
                    MessageBox.Show("ชื่อผู้ใช้นี้มีผู้ใช้อื่นใช้แล้วกรุณาเปลี่ยนชื่อผู้ใช้ใหม่");
                }

                else if (check == false)
                {
                    MySqlConnection conn1 = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project_final");
                    conn1.Open();
                    string sql1 = "INSERT INTO login(username,password) VALUES('" + textBoxUser.Text + "','" + textBoxpw1.Text + "')";

                    MySqlCommand cmd1 = new MySqlCommand(sql1, conn1);
                    cmd1.ExecuteReader();
                    conn1.Close();
                    MessageBox.Show("ลงทะเบียนเสร็จสิ้น");

                    textBoxUser.Text = "";
                    textBoxpw1.Text = "";
                    textBoxpw2.Text = "";

                }
            } 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBoxpw1.UseSystemPasswordChar = false;
            }
            else if (checkBox1.Checked == false)
            {
                textBoxpw1.UseSystemPasswordChar = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBoxpw1.UseSystemPasswordChar = true;
        }
    }
}
