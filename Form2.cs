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
    public partial class Form2 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_final";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM login WHERE username = \"{textBox1.Text}\"AND password = \"{textBoxpassword.Text}\"";

            MySqlDataReader row = cmd.ExecuteReader();
            if (row.HasRows)
            {
                MessageBox.Show("เข้าสู่ระบบสำเร็จ");
                Program.user = textBox1.Text;
                Form5 f5 = new Form5();
                this.Hide();
                f5.Show();
            }
            else { MessageBox.Show("เข้าสู่ระบบล้มเหลว\nบัญชีผู้ใช้ หรือ รหัสผ่าน ไม่ถูกต้อง"); }
            conn.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBoxpassword.UseSystemPasswordChar = false;
            }
            else if (checkBox1.Checked == false)
            {
                textBoxpassword.UseSystemPasswordChar = true;
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxpassword.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void textBoxpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
