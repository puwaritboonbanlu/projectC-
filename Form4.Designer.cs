
namespace Project_fial
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.เมนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.คำนวณคาBMRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.คำนวณคาBMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.บนทกขอมลToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ออกจากระบบToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ปดโปรแกรมToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(210, 96);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(249, 245);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cloud", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(197, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "คำนวณค่าดัชนีมวลกาย (BMI)\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cloud Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(205, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "น้ำหนัก\r\n";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cloud Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.Lavender;
            this.label3.Location = new System.Drawing.Point(205, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "ส่วนสูง";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(291, 383);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 27);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(291, 448);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 27);
            this.textBox2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Cloud", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(221, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "คำนวณ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Font = new System.Drawing.Font("Cloud Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.เมนToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(670, 28);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // เมนToolStripMenuItem
            // 
            this.เมนToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.คำนวณคาBMRToolStripMenuItem,
            this.คำนวณคาBMIToolStripMenuItem,
            this.บนทกขอมลToolStripMenuItem,
            this.ออกจากระบบToolStripMenuItem,
            this.ปดโปรแกรมToolStripMenuItem});
            this.เมนToolStripMenuItem.Name = "เมนToolStripMenuItem";
            this.เมนToolStripMenuItem.Size = new System.Drawing.Size(42, 24);
            this.เมนToolStripMenuItem.Text = "เมนู";
            // 
            // คำนวณคาBMRToolStripMenuItem
            // 
            this.คำนวณคาBMRToolStripMenuItem.Name = "คำนวณคาBMRToolStripMenuItem";
            this.คำนวณคาBMRToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.คำนวณคาBMRToolStripMenuItem.Text = "คำนวณค่า BMR";
            this.คำนวณคาBMRToolStripMenuItem.Click += new System.EventHandler(this.คำนวณคาBMRToolStripMenuItem_Click);
            // 
            // คำนวณคาBMIToolStripMenuItem
            // 
            this.คำนวณคาBMIToolStripMenuItem.Name = "คำนวณคาBMIToolStripMenuItem";
            this.คำนวณคาBMIToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.คำนวณคาBMIToolStripMenuItem.Text = "คำนวณค่า BMI";
            this.คำนวณคาBMIToolStripMenuItem.Click += new System.EventHandler(this.คำนวณคาBMIToolStripMenuItem_Click);
            // 
            // บนทกขอมลToolStripMenuItem
            // 
            this.บนทกขอมลToolStripMenuItem.Name = "บนทกขอมลToolStripMenuItem";
            this.บนทกขอมลToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.บนทกขอมลToolStripMenuItem.Text = "บันทึกข้อมูล";
            this.บนทกขอมลToolStripMenuItem.Click += new System.EventHandler(this.บนทกขอมลToolStripMenuItem_Click);
            // 
            // ออกจากระบบToolStripMenuItem
            // 
            this.ออกจากระบบToolStripMenuItem.Name = "ออกจากระบบToolStripMenuItem";
            this.ออกจากระบบToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ออกจากระบบToolStripMenuItem.Text = "ออกจากระบบ";
            this.ออกจากระบบToolStripMenuItem.Click += new System.EventHandler(this.ออกจากระบบToolStripMenuItem_Click);
            // 
            // ปดโปรแกรมToolStripMenuItem
            // 
            this.ปดโปรแกรมToolStripMenuItem.Name = "ปดโปรแกรมToolStripMenuItem";
            this.ปดโปรแกรมToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ปดโปรแกรมToolStripMenuItem.Text = "ปิดโปรแกรม";
            this.ปดโปรแกรมToolStripMenuItem.Click += new System.EventHandler(this.ปดโปรแกรมToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Cloud", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(344, 525);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 36);
            this.button2.TabIndex = 32;
            this.button2.Text = "เคลียร์ข้อมูล";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(293, 644);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 44);
            this.label4.TabIndex = 33;
            this.label4.Text = "BMI";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cloud Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.ForeColor = System.Drawing.Color.Lavender;
            this.label6.Location = new System.Drawing.Point(439, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 27);
            this.label6.TabIndex = 35;
            this.label6.Text = "กก.";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cloud Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.ForeColor = System.Drawing.Color.Lavender;
            this.label7.Location = new System.Drawing.Point(439, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 27);
            this.label7.TabIndex = 36;
            this.label7.Text = "ซม.";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox3.Location = new System.Drawing.Point(273, 702);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 45);
            this.textBox3.TabIndex = 37;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.ForeColor = System.Drawing.Color.HotPink;
            this.label9.Location = new System.Drawing.Point(267, 785);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 25);
            this.label9.TabIndex = 38;
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(670, 890);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem เมนToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem คำนวณคาBMRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem คำนวณคาBMIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem บนทกขอมลToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ออกจากระบบToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ปดโปรแกรมToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
    }
}