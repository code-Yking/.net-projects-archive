namespace PigeonSENT
{
    using PigeonSENT.Properties;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;
    using System.Windows.Forms;

    public class Form1 : Form
    {
        private Socket sck;
        private EndPoint epLocal;
        private EndPoint epRemote;
        private IContainer components = null;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox textLocalPort;
        private TextBox textLocalIp;
        private GroupBox groupBox2;
        private Label label3;
        private Label label4;
        private TextBox textFriendsIp;
        private TextBox textFriendsPort;
        private ListBox listMessage;
        private TextBox textMessage;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private Label label7;
        private Button button3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private GroupBox groupBox3;
        private PictureBox pictureBox3;

        public Form1()
        {
            this.InitializeComponent();
            this.sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            this.sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            this.textLocalIp.Text = this.GetLocalIP();
            this.textFriendsIp.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.epLocal = new IPEndPoint(IPAddress.Parse(this.textLocalIp.Text), Convert.ToInt32(this.textLocalPort.Text));
                this.sck.Bind(this.epLocal);
                this.epRemote = new IPEndPoint(IPAddress.Parse(this.textFriendsIp.Text), Convert.ToInt32(this.textFriendsPort.Text));
                this.sck.Connect(this.epRemote);
                byte[] buffer = new byte[0x5dc];
                this.sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref this.epRemote, new AsyncCallback(this.MessageCallBack), buffer);
                this.button1.Text = "Connected";
                this.button1.Enabled = false;
                this.button2.Enabled = true;
                this.textMessage.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not Connect or your friend is offline. Please try later.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] bytes = new byte[0x5dc];
                bytes = new ASCIIEncoding().GetBytes(this.textMessage.Text);
                this.sck.Send(bytes);
                this.listMessage.Items.Add(this.textBox1.Text + ":" + this.textMessage.Text);
                this.textMessage.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Connect to a partner first");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Enabled = true;
        }

        protected override void Dispose(bool disposing)
        {
            if (!(!disposing || ReferenceEquals(this.components, null)))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private string GetLocalIP()
        {
            IPAddress[] addressList = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
            int index = 0;
            while (true)
            {
                string str;
                if (index >= addressList.Length)
                {
                    str = "127.0.0.1";
                }
                else
                {
                    IPAddress address = addressList[index];
                    if (address.AddressFamily != AddressFamily.InterNetwork)
                    {
                        index++;
                        continue;
                    }
                    str = address.ToString();
                }
                return str;
            }
        }

        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new GroupBox();
            this.button3 = new Button();
            this.textBox1 = new TextBox();
            this.label5 = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.textLocalPort = new TextBox();
            this.textLocalIp = new TextBox();
            this.groupBox2 = new GroupBox();
            this.textBox2 = new TextBox();
            this.label6 = new Label();
            this.textFriendsPort = new TextBox();
            this.label3 = new Label();
            this.label4 = new Label();
            this.textFriendsIp = new TextBox();
            this.listMessage = new ListBox();
            this.textMessage = new TextBox();
            this.button1 = new Button();
            this.button2 = new Button();
            this.label7 = new Label();
            this.groupBox3 = new GroupBox();
            this.pictureBox3 = new PictureBox();
            this.pictureBox2 = new PictureBox();
            this.pictureBox1 = new PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((ISupportInitialize) this.pictureBox3).BeginInit();
            ((ISupportInitialize) this.pictureBox2).BeginInit();
            ((ISupportInitialize) this.pictureBox1).BeginInit();
            base.SuspendLayout();
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textLocalPort);
            this.groupBox1.Controls.Add(this.textLocalIp);
            this.groupBox1.Location = new Point(5, 0x31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x100, 0x6d);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "You";
            this.button3.Font = new Font("Microsoft Sans Serif", 6f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button3.Location = new Point(100, 0x1d);
            this.button3.Name = "button3";
            this.button3.Size = new Size(0x22, 0x11);
            this.button3.TabIndex = 7;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new EventHandler(this.button3_Click);
            this.textBox1.Enabled = false;
            this.textBox1.Location = new Point(0x8d, 0x1a);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "You";
            this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
            this.label5.AutoSize = true;
            this.label5.Location = new Point(6, 0x1a);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name:";
            this.label2.AutoSize = true;
            this.label2.Location = new Point(8, 0x51);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x1d, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            this.label1.AutoSize = true;
            this.label1.Location = new Point(6, 0x37);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Internet Protocol:";
            this.textLocalPort.Location = new Point(0x8d, 0x4e);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new Size(100, 20);
            this.textLocalPort.TabIndex = 1;
            this.textLocalIp.Enabled = false;
            this.textLocalIp.Location = new Point(0x8d, 0x34);
            this.textLocalIp.Name = "textLocalIp";
            this.textLocalIp.Size = new Size(100, 20);
            this.textLocalIp.TabIndex = 0;
            this.textLocalIp.TextChanged += new EventHandler(this.textLocalIp_TextChanged);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textFriendsPort);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textFriendsIp);
            this.groupBox2.Location = new Point(0x126, 0x31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(0x100, 0x6d);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Friend";
            this.textBox2.Location = new Point(0x8b, 0x1a);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(100, 20);
            this.textBox2.TabIndex = 7;
            this.label6.AutoSize = true;
            this.label6.Location = new Point(12, 0x1a);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x26, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name:";
            this.textFriendsPort.Location = new Point(0x8b, 0x4e);
            this.textFriendsPort.Name = "textFriendsPort";
            this.textFriendsPort.Size = new Size(100, 20);
            this.textFriendsPort.TabIndex = 3;
            this.label3.AutoSize = true;
            this.label3.Location = new Point(12, 0x37);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Internet Protocol:";
            this.label4.AutoSize = true;
            this.label4.Location = new Point(12, 0x51);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x1d, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Port:";
            this.textFriendsIp.Location = new Point(0x8b, 0x34);
            this.textFriendsIp.Name = "textFriendsIp";
            this.textFriendsIp.Size = new Size(100, 20);
            this.textFriendsIp.TabIndex = 2;
            this.listMessage.FormattingEnabled = true;
            this.listMessage.Location = new Point(12, 0xb2);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new Size(0x285, 0x79);
            this.listMessage.TabIndex = 2;
            this.textMessage.Location = new Point(12, 0x13c);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new Size(0x225, 20);
            this.textMessage.TabIndex = 3;
            this.button1.Cursor = Cursors.Hand;
            this.button1.Location = new Point(0x238, 0x4b);
            this.button1.Name = "button1";
            this.button1.Size = new Size(0x59, 0x2a);
            this.button1.TabIndex = 4;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.button2.Cursor = Cursors.Hand;
            this.button2.Location = new Point(0x238, 0x13c);
            this.button2.Name = "button2";
            this.button2.Size = new Size(0x59, 0x18);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sent";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new EventHandler(this.button2_Click);
            this.label7.AutoSize = true;
            this.label7.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(0x42, 9);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0xa6, 0x1d);
            this.label7.TabIndex = 6;
            this.label7.Text = "PigeonSENT";
            this.groupBox3.BackColor = SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new Point(-1, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(0x2a1, 0x2d);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.pictureBox3.Cursor = Cursors.Hand;
            this.pictureBox3.Image = Resources.giant_close_button;
            this.pictureBox3.Location = new Point(0x265, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new Size(60, 0x2d);
            this.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new EventHandler(this.pictureBox3_Click);
            this.pictureBox2.Image = Resources.Picture1;
            this.pictureBox2.Location = new Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Size(60, 0x35);
            this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new EventHandler(this.pictureBox2_Click);
            this.pictureBox1.Image = Resources.landing_digi_1_;
            this.pictureBox1.Location = new Point(0x1ce, 0x99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(0xc3, 0xa7);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x2a0, 370);
            base.Controls.Add(this.groupBox3);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.textMessage);
            base.Controls.Add(this.pictureBox1);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.listMessage);
            base.Controls.Add(this.groupBox2);
            base.Controls.Add(this.groupBox1);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "Form1";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Chat-er -=PigeonSENT=-";
            base.Load += new EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((ISupportInitialize) this.pictureBox3).EndInit();
            ((ISupportInitialize) this.pictureBox2).EndInit();
            ((ISupportInitialize) this.pictureBox1).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void listmessage_TextChanged(object sender, EventArgs e)
        {
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                if (this.sck.EndReceiveFrom(aResult, ref this.epRemote) > 0)
                {
                    byte[] buffer = new byte[0x5b8];
                    string str = new ASCIIEncoding().GetString((byte[]) aResult.AsyncState);
                    this.listMessage.Items.Add(this.textBox2.Text + ":" + str);
                }
                byte[] buffer2 = new byte[0x5dc];
                this.sck.BeginReceiveFrom(buffer2, 0, buffer2.Length, SocketFlags.None, ref this.epRemote, new AsyncCallback(this.MessageCallBack), buffer2);
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.pigeonsent.webs.com");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textLocalIp_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

