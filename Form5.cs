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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxW.Text == "" | textBoxT.Text == "" | textBoxAge.Text =="" |(radioButton1.Checked==false && radioButton2.Checked==false) | comboBox1.Text=="")
            {
                MessageBox.Show("โปรดระบุข้อมูลให้ครบถ้วน");
            }
            else
            {
                double Hg = double.Parse(textBoxW.Text);
                double GG = double.Parse(textBoxT.Text);
                double Year = double.Parse(textBoxAge.Text);
                double BMR = 0;
                double TDEE = 0;

                if (radioButton1.Checked)
                {
                    BMR = 66 + (13.7 * GG) + (5 * Hg) - (6.8 * Year);
                }

                else if (radioButton2.Checked)
                {
                    BMR = 665 + (9.6 * GG) + (1.8 * Hg) - (4.7 * Year);
                }

                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        TDEE = BMR * 1.2;
                        label9.Text = ($"BMR พลังงานที่จำเป็นพื้นฐานในการมีชีวิต {BMR} กิโลแคลอรี่");
                        label10.Text = ($"TDEE พลังงานที่คุณใช้ในแต่ละวัน {TDEE} กิโลแคลอรี่");
                        break;
                    case 1:
                        TDEE = BMR * 1.375;
                        label9.Text = ($"BMR พลังงานที่จำเป็นพื้นฐานในการมีชีวิต {BMR} กิโลแคลอรี่");
                        label10.Text = ($"TDEE พลังงานที่คุณใช้ในแต่ละวัน {TDEE} กิโลแคลอรี่");
                        break;
                    case 2:
                        TDEE = BMR * 1.55;
                        label9.Text = ($"BMR พลังงานที่จำเป็นพื้นฐานในการมีชีวิต {BMR} กิโลแคลอรี่");
                        label10.Text = ($"TDEE พลังงานที่คุณใช้ในแต่ละวัน {TDEE} กิโลแคลอรี่");
                        break;
                    case 3:
                        TDEE = BMR * 1.725;
                        label9.Text = ($"BMR พลังงานที่จำเป็นพื้นฐานในการมีชีวิต {BMR} กิโลแคลอรี่");
                        label10.Text = ($"TDEE พลังงานที่คุณใช้ในแต่ละวัน {TDEE} กิโลแคลอรี่");
                        break;
                    case 4:
                        TDEE = BMR * 1.9;
                        label9.Text = ($"BMR พลังงานที่จำเป็นพื้นฐานในการมีชีวิต {BMR} กิโลแคลอรี่");
                        label10.Text = ($"TDEE พลังงานที่คุณใช้ในแต่ละวัน {TDEE} กิโลแคลอรี่");
                        break;
                }
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            
        }


        private void textBoxT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                MessageBox.Show("กรุณาใส่เฉพาะตัวเลข");
                e.Handled = true;
            }
        }

        private void textBoxW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                MessageBox.Show("กรุณาใส่เฉพาะตัวเลข");
                e.Handled = true;
            }
        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                MessageBox.Show("กรุณาใส่เฉพาะตัวเลข");
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxW.Clear();
            textBoxT.Clear();
            textBoxAge.Clear();
            label9.Text = "";
            label10.Text = "";
            comboBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
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

        private void บนทกขอมลToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            this.Hide();
            f7.Show();
        }

        private void dietPlanningToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ออกจากระบบToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }
    }
}
