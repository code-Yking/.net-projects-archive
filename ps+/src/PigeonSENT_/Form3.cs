namespace PigeonSENT_
{
    using PigeonSENT_.Properties;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Net;
    using System.Net.NetworkInformation;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public class Form3 : Form
    {
        private IContainer components = null;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label6;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private Label label3;

        public Form3()
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
            Process.Start(@"C:\Windows\System32\dialer.exe");
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
            this.label2.Text = Dns.GetHostName();
            IPAddress[] hostAddresses = Dns.GetHostAddresses(Dns.GetHostName());
            int index = 0;
            while (true)
            {
                if (index >= hostAddresses.Length)
                {
                    this.timer1.Start();
                    if (NetworkInterface.GetIsNetworkAvailable())
                    {
                        this.timer1.Tick += new EventHandler(this.timer1_Tick);
                    }
                    else
                    {
                        MessageBox.Show("Not connected to net");
                    }
                    return;
                }
                IPAddress address = hostAddresses[index];
                index++;
            }
        }

        private void Form3_Shown(object sender, EventArgs e)
        {
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form3));
            this.label6 = new Label();
            this.linkLabel1 = new LinkLabel();
            this.pictureBox4 = new PictureBox();
            this.pictureBox1 = new PictureBox();
            this.pictureBox2 = new PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            ((ISupportInitialize) this.pictureBox4).BeginInit();
            ((ISupportInitialize) this.pictureBox1).BeginInit();
            ((ISupportInitialize) this.pictureBox2).BeginInit();
            base.SuspendLayout();
            this.label6.AutoSize = true;
            this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(0x67, 0xd6);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x74, 0x10);
            this.label6.TabIndex = 0x17;
            this.label6.Text = "A personal chatter";
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new Point(0x67, 0x21);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new Size(0x89, 13);
            this.linkLabel1.TabIndex = 0x18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.pigeonsent.webs.com";
            this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.pictureBox4.Image = Resources.Picture41;
            this.pictureBox4.Location = new Point(0x39, -3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new Size(0xb7, 0x21);
            this.pictureBox4.TabIndex = 0x19;
            this.pictureBox4.TabStop = false;
            this.pictureBox1.Image = Resources.Picture111;
            this.pictureBox1.Location = new Point(0x42, 0x24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(0xb7, 0x92);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox2.Image = Resources.Picture1;
            this.pictureBox2.Location = new Point(12, 0x91);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Size(0x134, 100);
            this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.timer1.Interval = 0xbb8;
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Modern No. 20", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(0x52, 0x115);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0xa7, 15);
            this.label1.TabIndex = 0x1a;
            this.label1.Text = "All rights reserved \x00a9 2015-16 \r\n";
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Futurist Fixed-width", 12f, FontStyle.Underline, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(0xa9, 0xf8);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0xa9, 20);
            this.label2.TabIndex = 0x1c;
            this.label2.Text = "Host name:";
            this.label2.TextAlign = ContentAlignment.MiddleCenter;
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Futurist Fixed-width", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(8, 0xf8);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0xa9, 20);
            this.label3.TabIndex = 0x1d;
            this.label3.Text = "Host name:";
            this.label3.TextAlign = ContentAlignment.MiddleCenter;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(330, 0x12d);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.linkLabel1);
            base.Controls.Add(this.label6);
            base.Controls.Add(this.pictureBox1);
            base.Controls.Add(this.pictureBox2);
            base.Controls.Add(this.pictureBox4);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.Name = "Form3";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "PigeonSENT+";
            base.Load += new EventHandler(this.Form3_Load);
            base.Shown += new EventHandler(this.Form3_Shown);
            ((ISupportInitialize) this.pictureBox4).EndInit();
            ((ISupportInitialize) this.pictureBox1).EndInit();
            ((ISupportInitialize) this.pictureBox2).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        [DllImport("wininet.dll")]
        private static extern bool InternetGetConnectedState(out int Description, int ReservedValue);
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.pigeonsent.webs.com");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Stop();
            new Form2().Show();
            base.Hide();
        }
    }
}

