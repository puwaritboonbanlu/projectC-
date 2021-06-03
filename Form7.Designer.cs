
namespace Project_fial
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.เมนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.คำนวณคาBMRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.คำนวณคาBMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.บนทกขอมลToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ออกจากระบบToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ปดโปรแกรมToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(165, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(596, 351);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.menuStrip1.Size = new System.Drawing.Size(939, 28);
            this.menuStrip1.TabIndex = 32;
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
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonEdit.Font = new System.Drawing.Font("Cloud", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonEdit.Location = new System.Drawing.Point(380, 668);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(148, 67);
            this.buttonEdit.TabIndex = 33;
            this.buttonEdit.Text = "แก้ไขข้อมูล";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonInsert.Font = new System.Drawing.Font("Cloud", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonInsert.Location = new System.Drawing.Point(226, 668);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(148, 67);
            this.buttonInsert.TabIndex = 34;
            this.buttonInsert.Text = "เพิ่มข้อมูล";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonDelete.Font = new System.Drawing.Font("Cloud", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonDelete.Location = new System.Drawing.Point(534, 668);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(148, 67);
            this.buttonDelete.TabIndex = 35;
            this.buttonDelete.Text = "ลบข้อมูล";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(420, 554);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 31);
            this.textBox1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cloud Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(345, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 27);
            this.label2.TabIndex = 37;
            this.label2.Text = "ค่าBMR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cloud Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(349, 621);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 27);
            this.label1.TabIndex = 38;
            this.label1.Text = "ค่าBMI";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(420, 617);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 31);
            this.textBox2.TabIndex = 39;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox3.Location = new System.Drawing.Point(547, 424);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(214, 27);
            this.textBox3.TabIndex = 40;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cloud Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(489, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 27);
            this.label3.TabIndex = 41;
            this.label3.Text = "ค้นหา";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxUser.Location = new System.Drawing.Point(420, 504);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.ReadOnly = true;
            this.textBoxUser.Size = new System.Drawing.Size(214, 27);
            this.textBoxUser.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cloud Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(354, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 27);
            this.label4.TabIndex = 43;
            this.label4.Text = "ชื่อผู้ใช้";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 783);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem เมนToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem คำนวณคาBMRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem คำนวณคาBMIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem บนทกขอมลToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ออกจากระบบToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ปดโปรแกรมToolStripMenuItem;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label label4;
    }
}