namespace PigeonSENT
{
    using PigeonSENT.Properties;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class Form3 : Form
    {
        private IContainer components = null;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label7;
        private Button button2;

        public Form3()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            base.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        protected override void Dispose(bool disposing)
        {
            if (!(!disposing || ReferenceEquals(this.components, null)))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new PictureBox();
            this.button1 = new Button();
            this.label1 = new Label();
            this.pictureBox2 = new PictureBox();
            this.label7 = new Label();
            this.button2 = new Button();
            ((ISupportInitialize) this.pictureBox1).BeginInit();
            ((ISupportInitialize) this.pictureBox2).BeginInit();
            base.SuspendLayout();
            this.pictureBox1.Image = Resources.landing_digi_1_;
            this.pictureBox1.Location = new Point(270, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(0x176, 0x146);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.button1.Font = new Font("Microsoft Sans Serif", 24f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button1.Location = new Point(0x19, 0xdd);
            this.button1.Name = "button1";
            this.button1.Size = new Size(0xff, 0x31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(3, 70);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x131, 0x4b);
            this.label1.TabIndex = 10;
            this.label1.Text = manager.GetString("label1.Text");
            this.pictureBox2.Image = Resources.Picture1;
            this.pictureBox2.Location = new Point(6, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Size(60, 0x35);
            this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.label7.AutoSize = true;
            this.label7.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(0x48, 0x15);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0xa6, 0x1d);
            this.label7.TabIndex = 11;
            this.label7.Text = "PigeonSENT";
            this.button2.Location = new Point(0x4d, 0xae);
            this.button2.Name = "button2";
            this.button2.Size = new Size(0x9c, 0x1b);
            this.button2.TabIndex = 13;
            this.button2.Text = "Introduction";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new EventHandler(this.button2_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(630, 0x126);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.pictureBox2);
            base.Controls.Add(this.label7);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.pictureBox1);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.MinimizeBox = false;
            base.Name = "Form3";
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Welcome -=PigeonSENT=-";
            base.Load += new EventHandler(this.Form3_Load);
            ((ISupportInitialize) this.pictureBox1).EndInit();
            ((ISupportInitialize) this.pictureBox2).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}

