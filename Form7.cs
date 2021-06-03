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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        MySqlDataAdapter oda;
        DataTable dt;
        int ed;
        private void loaddatatogid()
        {
            MySqlConnection conn = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project_final");
            string sql = "SELECT * FROM datauser";
            oda = new MySqlDataAdapter(sql, conn);
            dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            textBoxUser.Text = Program.user;
            loaddatatogid();

        }

        private void คำนวณคาBMRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }

        private void คำนวณคาBMIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }


        private void บนทกขอมลToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            this.Hide();
            f7.Show();
        }

        private void ปดโปรแกรมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ออกจากระบบToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            MySqlConnection conn1 = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project_final");
            conn1.Open();
            string sql1 = "INSERT INTO datauser(username,BMR,BMI) VALUES('" + textBoxUser.Text + "','" + textBox1.Text + "','" + textBox2.Text + "')";

            MySqlCommand cmd1 = new MySqlCommand(sql1, conn1);
            cmd1.ExecuteReader();
            conn1.Close();
            MessageBox.Show("บันทึกข้อมูลเรียบร้อย");
            textBox1.Text = "";
            textBox2.Text = "";
            loaddatatogid();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //เก็บค่าเก่า
            string BMROld = dataGridView1.Rows[ed].Cells["BMR"].FormattedValue.ToString();
            string BMIOld = dataGridView1.Rows[ed].Cells["BMI"].FormattedValue.ToString();

            MySqlConnection conn1 = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project_final");
            conn1.Open();
            string sql1 = "UPDATE datauser SET BMR = '" + textBox1.Text + "',BMI = '" + textBox2.Text + "' WHERE username ='" + textBoxUser.Text + "' AND BMR = '" + BMROld.ToString() +"' AND '"+BMIOld.ToString()+"'";

            MySqlCommand cmd1 = new MySqlCommand(sql1, conn1);
            cmd1.ExecuteReader();
            conn1.Close();
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย");
            loaddatatogid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["BMR"].FormattedValue.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["BMI"].FormattedValue.ToString();
            ed = dataGridView1.CurrentCell.RowIndex;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string BMROld = dataGridView1.Rows[ed].Cells["BMR"].FormattedValue.ToString();
            string BMIOld = dataGridView1.Rows[ed].Cells["BMI"].FormattedValue.ToString();

            MySqlConnection conn1 = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project_final");
            conn1.Open();
            string sql1 = " DELETE FROM datauser WHERE username ='" + textBoxUser.Text + "' AND BMR = '" + BMROld.ToString() + "' AND '" + BMIOld.ToString() + "'";

            MySqlCommand cmd1 = new MySqlCommand(sql1, conn1);
            cmd1.ExecuteReader();
            conn1.Close();
            MessageBox.Show("ลบข้อมูลเรียบร้อย");
            loaddatatogid();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project_final");
            string sql = "SELECT * FROM datauser WHERE username like '%" + textBox3.Text + "%'";
            oda = new MySqlDataAdapter(sql, conn);
            dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
