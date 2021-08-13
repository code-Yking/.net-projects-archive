namespace PigeonSENT_
{
    using PigeonSENT_.Properties;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Net;
    using System.Windows.Forms;

    public class Form1 : Form
    {
        private IContainer components = null;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label6;
        private Button button1;
        private Label label4;
        private TextBox textBox2;
        private PictureBox pictureBox3;

        public Form1()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            base.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        protected override void Dispose(bool disposing)
        {
            if (!(!disposing || ReferenceEquals(this.components, null)))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.textBox2.Text = Dns.GetHostName();
            foreach (IPAddress address in Dns.GetHostAddresses(Dns.GetHostName()))
            {
            }
        }

        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form1));
            this.label1 = new Label();
            this.label6 = new Label();
            this.button1 = new Button();
            this.label4 = new Label();
            this.textBox2 = new TextBox();
            this.pictureBox2 = new PictureBox();
            this.pictureBox1 = new PictureBox();
            this.pictureBox3 = new PictureBox();
            ((ISupportInitialize) this.pictureBox2).BeginInit();
            ((ISupportInitialize) this.pictureBox1).BeginInit();
            ((ISupportInitialize) this.pictureBox3).BeginInit();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(2, 0x4b);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x4f, 0x1d);
            this.label1.TabIndex = 1;
            this.label1.Text = "Log In";
            this.label6.AutoSize = true;
            this.label6.Location = new Point(0x55, 0x34);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x5d, 13);
            this.label6.TabIndex = 0x16;
            this.label6.Text = "A personal chatter";
            this.button1.Location = new Point(0x2d, 0x95);
            this.button1.Name = "button1";
            this.button1.Size = new Size(0x85, 0x1a);
            this.button1.TabIndex = 0x19;
            this.button1.Text = "Procceed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.Location = new Point(0x45, 0x68);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x49, 0x10);
            this.label4.TabIndex = 0x1b;
            this.label4.Text = "Host name";
            this.textBox2.Enabled = false;
            this.textBox2.Location = new Point(0x21, 0x7b);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(0x9d, 20);
            this.textBox2.TabIndex = 0x1c;
            this.textBox2.TextChanged += new EventHandler(this.textBox2_TextChanged);
            this.pictureBox2.Image = Resources.Picture1;
            this.pictureBox2.Location = new Point(0x21, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Size(0x109, 0x45);
            this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox1.Image = Resources.landing_digi_1_;
            this.pictureBox1.Location = new Point(0xb8, 0x4b);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(0x9e, 0x7f);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox3.Image = Resources.Picture111;
            this.pictureBox3.Location = new Point(-2, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new Size(0x41, 0x39);
            this.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0x1d;
            this.pictureBox3.TabStop = false;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x158, 0xc2);
            base.Controls.Add(this.textBox2);
            base.Controls.Add(this.pictureBox1);
            base.Controls.Add(this.pictureBox3);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.label6);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.pictureBox2);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.Name = "Form1";
            this.Text = "PigeonSENT";
            base.Load += new EventHandler(this.Form2_Load);
            ((ISupportInitialize) this.pictureBox2).EndInit();
            ((ISupportInitialize) this.pictureBox1).EndInit();
            ((ISupportInitialize) this.pictureBox3).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
        }
    }
}

