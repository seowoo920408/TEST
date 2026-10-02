using Autodesk.Revit.DB;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Modless
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        private void InitializeComponent()
        {
            btnRun = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            button2 = new System.Windows.Forms.Button();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            button4 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            comboBox4 = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            comboBox3 = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            comboBox2 = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            tabPage2 = new System.Windows.Forms.TabPage();
            tabPage3 = new System.Windows.Forms.TabPage();
            panel2 = new System.Windows.Forms.Panel();
            textBox1 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Location = new System.Drawing.Point(6, 56);
            btnRun.Name = "btnRun";
            btnRun.Size = new System.Drawing.Size(121, 23);
            btnRun.TabIndex = 0;
            btnRun.Text = "슬라브 생성기";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(133, 56);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(121, 23);
            button1.TabIndex = 1;
            button1.Text = "보 생성기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(112, 438);
            panel1.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.images;
            pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new System.Drawing.Point(0, 218);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(112, 111);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.images;
            pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            pictureBox4.InitialImage = null;
            pictureBox4.Location = new System.Drawing.Point(0, 329);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(112, 109);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.images;
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new System.Drawing.Point(0, 109);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(112, 109);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.images;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(112, 109);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(260, 56);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(121, 23);
            button2.TabIndex = 5;
            button2.Text = "기둥 생성기";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(112, 16);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(621, 422);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(comboBox4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(comboBox3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(btnRun);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(613, 394);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ARC";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(260, 116);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(121, 23);
            button4.TabIndex = 15;
            button4.Text = "마감벽 생성기";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(260, 87);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(121, 23);
            button3.TabIndex = 14;
            button3.Text = "벽 생성기";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.RoyalBlue;
            label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label4.Location = new System.Drawing.Point(6, 97);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(47, 15);
            label4.TabIndex = 13;
            label4.Text = "벽 타입";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new System.Drawing.Point(6, 115);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new System.Drawing.Size(121, 23);
            comboBox4.TabIndex = 12;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.RoyalBlue;
            label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label3.Location = new System.Drawing.Point(260, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 15);
            label3.TabIndex = 11;
            label3.Text = "기둥 타입";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new System.Drawing.Point(260, 27);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new System.Drawing.Size(121, 23);
            comboBox3.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.RoyalBlue;
            label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label2.Location = new System.Drawing.Point(133, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(47, 15);
            label2.TabIndex = 9;
            label2.Text = "보 타입";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(133, 27);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(121, 23);
            comboBox2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.RoyalBlue;
            label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label1.Location = new System.Drawing.Point(6, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 15);
            label1.TabIndex = 7;
            label1.Text = "슬라브 타입";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(6, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(613, 394);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "STR";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new System.Drawing.Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new System.Drawing.Size(613, 394);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "MEP";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(112, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(621, 16);
            panel2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(133, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(121, 23);
            textBox1.TabIndex = 16;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.RoyalBlue;
            label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label5.Location = new System.Drawing.Point(133, 97);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(47, 15);
            label5.TabIndex = 17;
            label5.Text = "벽 높이";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLightLight;
            ClientSize = new System.Drawing.Size(733, 438);
            Controls.Add(tabControl1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Vivian Pj";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}
