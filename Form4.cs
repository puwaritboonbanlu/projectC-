using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_fial
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" | textBox2.Text == "")
            {
                MessageBox.Show("โปรดระบุตัวเลขข้อมูล");
            }
            else
            {
                double weight = Convert.ToDouble(textBox1.Text);
                double hight = Convert.ToDouble(textBox2.Text);

                double bmi = weight / ((hight / 100) * 2);

                textBox3.Text = string.Format("{0:F2}", bmi);

                if (bmi < 18.50)
                {
                    label9.Text = ("เกณฑ์ ผอม / น้ำหนักน้อย");
                }
                if (bmi < 22.90 && bmi > 18.50)
                {
                    label9.Text = ("เกณฑ์ ปกติ สุขภาพดี");
                }
                if (bmi < 24.90 && bmi > 23)
                {
                    label9.Text = ("เกณฑ์ ท้วม / โรคอ้วนระดับ 1");
                }
                if (bmi < 29.90 && bmi > 25)
                {
                    label9.Text = ("เกณฑ์ อ้วน / โรคอ้วนระดับ 2");
                }
                if (bmi > 30)
                {
                    label9.Text = ("อ้วนมาก / โรคอ้วนระดับ 3");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void ปดโปรแกรมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void dietPlanningToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void บนทกขอมลToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            this.Hide();
            f7.Show();
        }

        private void ออกจากระบบToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }
    }
}
