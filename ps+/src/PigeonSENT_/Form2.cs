namespace PigeonSENT_
{
    using PigeonSENT_.Properties;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;
    using System.Windows.Forms;

    public class Form2 : Form
    {
        private Socket sck;
        private EndPoint epLocal;
        private EndPoint epRemote;
        private IContainer components = null;
        private TextBox textLocalPort;
        private TextBox textLocalIp;
        private Label label2;
        private TextBox textFriendsIp;
        private TextBox textFriendsPort;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox listMessage;
        private TextBox textMessage;
        private Button button2;
        private Label label4;
        private Label label1;
        private LinkLabel linkLabel1;
        private Label label3;
        private Label label6;
        private PictureBox pictureBox2;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Button button3;
        private Label time_lbl;
        private PictureBox picCapture;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem startToolStripMenuItem;
        private ToolStripMenuItem iPToolStripMenuItem;
        private ToolStripMenuItem hostToolStripMenuItem;
        private ToolStripMenuItem portToolStripMenuItem;
        private ToolStripMenuItem endChattingToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem screenShareToolStripMenuItem;
        private ToolStripMenuItem shareToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem viewHelpToolStripMenuItem;
        private ToolStripMenuItem visitOurSiteToolStripMenuItem;
        private ToolStripMenuItem downloaderToolStripMenuItem;
        private ToolStripMenuItem downloadToolStripMenuItem;
        private PictureBox pictureBox4;
        private ToolStripMenuItem downloadToolStripMenuItem1;
        private ToolStripMenuItem connectToolStripMenuItem;
        private NotifyIcon notifyIcon1;
        private ToolStripMenuItem minimizeToolStripMenuItem;
        private Button button4;
        private HelpProvider helpProvider1;
        private Label label5;
        private Button button5;

        public Form2()
        {
            this.InitializeComponent();
            this.timer1.Start();
            this.sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            this.sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            this.textLocalIp.Text = this.GetLocalIP();
            this.textFriendsIp.Text = "";
        }

        private void activationToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                base.ClientSize = new Size(0x3dd, 0x12b);
                this.listMessage.Enabled = true;
                this.textMessage.Enabled = true;
                this.textBox1.Enabled = false;
                this.textBox2.Enabled = false;
                this.textLocalIp.Enabled = false;
                this.textFriendsIp.Enabled = false;
                this.textFriendsPort.Enabled = false;
                this.textLocalPort.Enabled = false;
                base.ClientSize = new Size(0x43f, 0x137);
                this.time_lbl.Text = DateTime.Now.ToShortTimeString();
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
                object[] objArray = new object[] { "(", DateTime.Now, ")", this.textBox1.Text, ":", this.textMessage.Text };
                this.listMessage.Items.Add(string.Concat(objArray));
                this.textMessage.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed :(");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("Contacts.txt");
            writer.Write("Name                 | IP               ");
            writer.Close();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            try
            {
                byte[] bytes = new byte[0x5dc];
                bytes = new ASCIIEncoding().GetBytes("Your Partner has ended his chat");
                this.sck.Send(bytes);
                this.listMessage.Items.Add("Your partner has ended his chat");
                this.textMessage.Clear();
                this.textMessage.Size = new Size(0x255, 0x29);
                this.textMessage.Location = new Point(0x16a, 240);
                this.textBox2.Enabled = true;
                this.button2.Location = new Point(0x3c5, 240);
                this.button2.Size = new Size(0x49, 0x29);
                this.textFriendsIp.Enabled = true;
                this.label5.Visible = false;
                this.textFriendsPort.Enabled = true;
                this.button1.Enabled = true;
                this.button1.Text = "Connect";
                this.listMessage.Location = new Point(0x16a, 0x36);
                this.listMessage.Size = new Size(0x2a4, 0xad);
                this.time_lbl.Location = new Point(0x17f, 4);
                this.time_lbl.Size = new Size(0x33, 20);
                this.button2.Size = new Size(0x49, 0x29);
                this.button3.Location = new Point(0x3c7, -1);
                this.button3.Size = new Size(0x42, 30);
                this.button4.Location = new Point(0x397, -2);
                this.button4.Size = new Size(0x2a, 0x1f);
                base.AutoScaleDimensions = new SizeF(6f, 13f);
                base.ClientSize = new Size(340, 0x128);
                this.pictureBox4.Visible = false;
            }
            catch (Exception)
            {
                this.pictureBox4.Visible = false;
                this.listMessage.Location = new Point(0x17a, 0x4a);
                this.listMessage.Size = new Size(0x261, 0xad);
                this.textMessage.Location = new Point(0x16a, 0xfd);
                this.textMessage.Size = new Size(0x234, 0x29);
                this.button2.Location = new Point(0x3a0, 0xfd);
                this.button2.Size = new Size(0x49, 0x29);
                base.ClientSize = new Size(0x14f, 0x12b);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.notifyIcon1.Visible = true;
            base.Visible = false;
            this.notifyIcon1.BalloonTipTitle = "PigeonSENT is still running";
            this.notifyIcon1.BalloonTipText = "Please click this icon to resume chatting";
            this.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            this.notifyIcon1.ShowBalloonTip(0x3e8);
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Process.Start(@"C:\Windows\System32\dialer.exe");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void connectToolStripMenuItem_Click_1(object sender, EventArgs e)
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
                base.ClientSize = new Size(0x403, 0x12b);
                this.listMessage.Enabled = true;
                this.textMessage.Enabled = true;
                this.textBox1.Enabled = false;
                this.textBox2.Enabled = false;
                this.textLocalIp.Enabled = false;
                this.textFriendsIp.Enabled = false;
                this.textFriendsPort.Enabled = false;
                this.textLocalPort.Enabled = false;
                base.ClientSize = new Size(0x43f, 0x137);
                this.time_lbl.Text = DateTime.Now.ToShortTimeString();
                this.textMessage.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not Connect or your friend is offline. Please try later.");
            }
        }

        private void displayTime()
        {
            this.time_lbl.Text = DateTime.Now.ToShortTimeString();
        }

        protected override void Dispose(bool disposing)
        {
            if (!(!disposing || ReferenceEquals(this.components, null)))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("www.pigeonsent.webs.com/Download");
        }

        private void downloadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://onedrive.live.com/download?cid=543EF193B467CB5C&resid=543EF193B467CB5C%211026&authkey=AMOnaTAXNaSLuUs");
        }

        private void downloadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("www.downloadmanagerpro.blogspot.com");
        }

        private void downloadToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Process.Start("http://download1639.mediafire.com/bpbx4zy4dwdg/85pumi72kdyggzb/dmp.EXE");
        }

        private void endChattingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] bytes = new byte[0x5dc];
                bytes = new ASCIIEncoding().GetBytes(this.textMessage.Text);
                this.sck.Send(bytes);
                this.listMessage.Items.Add("Your partner has ended his chat.");
                this.textMessage.Clear();
                this.button2.Enabled = false;
                this.pictureBox1.Enabled = false;
                base.ClientSize = new Size(0x14f, 0x12b);
                this.listMessage.Enabled = true;
                this.textMessage.Enabled = true;
                this.textBox1.Enabled = true;
                this.textBox2.Enabled = true;
                this.textLocalIp.Enabled = true;
                this.textFriendsIp.Enabled = true;
                this.textFriendsPort.Enabled = true;
                this.textLocalPort.Enabled = true;
                this.listMessage.Text = "";
            }
            catch (Exception)
            {
                this.pictureBox4.Visible = false;
                this.listMessage.Location = new Point(0x17a, 0x4a);
                this.listMessage.Size = new Size(0x261, 0xad);
                this.textMessage.Location = new Point(0x16a, 0xfd);
                this.textMessage.Size = new Size(0x234, 0x29);
                this.button2.Location = new Point(0x3a0, 0xfd);
                this.button2.Size = new Size(0x49, 0x29);
                base.ClientSize = new Size(0x14f, 0x12b);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.iPToolStripMenuItem.Text = "IP = " + this.textLocalIp.Text;
            this.hostToolStripMenuItem.Text = "Host = " + Dns.GetHostName();
            IPAddress[] hostAddresses = Dns.GetHostAddresses(Dns.GetHostName());
            int index = 0;
            while (true)
            {
                if (index >= hostAddresses.Length)
                {
                    this.textLocalPort.Text = new Random().Next(0, 0x3e8).ToString();
                    this.portToolStripMenuItem.Text = "Port = " + this.textLocalPort.Text;
                    this.button1.Enabled = true;
                    return;
                }
                IPAddress address = hostAddresses[index];
                index++;
            }
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

        private void hostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.hostToolStripMenuItem.Text = "Host = " + Dns.GetHostName();
            foreach (IPAddress address in Dns.GetHostAddresses(Dns.GetHostName()))
            {
            }
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form2));
            this.textLocalPort = new TextBox();
            this.textLocalIp = new TextBox();
            this.label2 = new Label();
            this.textFriendsIp = new TextBox();
            this.textFriendsPort = new TextBox();
            this.button1 = new Button();
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.listMessage = new ListBox();
            this.textMessage = new TextBox();
            this.button2 = new Button();
            this.label4 = new Label();
            this.label1 = new Label();
            this.linkLabel1 = new LinkLabel();
            this.label3 = new Label();
            this.label6 = new Label();
            this.label8 = new Label();
            this.label9 = new Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new Button();
            this.time_lbl = new Label();
            this.menuStrip1 = new MenuStrip();
            this.startToolStripMenuItem = new ToolStripMenuItem();
            this.iPToolStripMenuItem = new ToolStripMenuItem();
            this.hostToolStripMenuItem = new ToolStripMenuItem();
            this.portToolStripMenuItem = new ToolStripMenuItem();
            this.connectToolStripMenuItem = new ToolStripMenuItem();
            this.endChattingToolStripMenuItem = new ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new ToolStripMenuItem();
            this.exitToolStripMenuItem = new ToolStripMenuItem();
            this.screenShareToolStripMenuItem = new ToolStripMenuItem();
            this.shareToolStripMenuItem = new ToolStripMenuItem();
            this.downloadToolStripMenuItem = new ToolStripMenuItem();
            this.downloaderToolStripMenuItem = new ToolStripMenuItem();
            this.downloadToolStripMenuItem1 = new ToolStripMenuItem();
            this.helpToolStripMenuItem = new ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new ToolStripMenuItem();
            this.visitOurSiteToolStripMenuItem = new ToolStripMenuItem();
            this.pictureBox4 = new PictureBox();
            this.pictureBox1 = new PictureBox();
            this.pictureBox2 = new PictureBox();
            this.picCapture = new PictureBox();
            this.pictureBox3 = new PictureBox();
            this.notifyIcon1 = new NotifyIcon(this.components);
            this.button4 = new Button();
            this.helpProvider1 = new HelpProvider();
            this.label5 = new Label();
            this.button5 = new Button();
            this.menuStrip1.SuspendLayout();
            ((ISupportInitialize) this.pictureBox4).BeginInit();
            ((ISupportInitialize) this.pictureBox1).BeginInit();
            ((ISupportInitialize) this.pictureBox2).BeginInit();
            ((ISupportInitialize) this.picCapture).BeginInit();
            ((ISupportInitialize) this.pictureBox3).BeginInit();
            base.SuspendLayout();
            this.textLocalPort.Enabled = false;
            this.textLocalPort.Location = new Point(0x9a, 170);
            this.textLocalPort.Multiline = true;
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new Size(0x3f, 0x12);
            this.textLocalPort.TabIndex = 1;
            this.textLocalIp.Enabled = false;
            this.textLocalIp.Location = new Point(0x53, 0xc5);
            this.textLocalIp.Multiline = true;
            this.textLocalIp.Name = "textLocalIp";
            this.textLocalIp.Size = new Size(0xb5, 0x15);
            this.textLocalIp.TabIndex = 2;
            this.textLocalIp.Visible = false;
            this.textLocalIp.TextChanged += new EventHandler(this.textLocalIp_TextChanged);
            this.label2.AutoSize = true;
            this.label2.Location = new Point(0x33, 0x91);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x11, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "IP";
            this.label2.Click += new EventHandler(this.label2_Click);
            this.textFriendsIp.Location = new Point(0x55, 0x8e);
            this.textFriendsIp.Name = "textFriendsIp";
            this.textFriendsIp.Size = new Size(140, 20);
            this.textFriendsIp.TabIndex = 5;
            this.textFriendsPort.Location = new Point(0x108, 0x8e);
            this.textFriendsPort.Name = "textFriendsPort";
            this.textFriendsPort.Size = new Size(0x36, 20);
            this.textFriendsPort.TabIndex = 4;
            this.textFriendsPort.TextChanged += new EventHandler(this.textFriendsPort_Click);
            this.button1.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button1.Location = new Point(0x10, 0xe0);
            this.button1.Name = "button1";
            this.button1.Size = new Size(0x12e, 0x39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.textBox1.Location = new Point(0x183, 0x1b);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(0x3f, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "You";
            this.textBox1.Visible = false;
            this.textBox2.Location = new Point(0x56, 0x72);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(0xb2, 0x16);
            this.textBox2.TabIndex = 10;
            this.listMessage.FormattingEnabled = true;
            this.listMessage.Location = new Point(0x16a, 0x36);
            this.listMessage.Name = "listMessage";
            this.listMessage.ScrollAlwaysVisible = true;
            this.listMessage.Size = new Size(0x2a4, 0xad);
            this.listMessage.TabIndex = 11;
            this.listMessage.SelectedIndexChanged += new EventHandler(this.listMessage_SelectedIndexChanged);
            this.textMessage.Location = new Point(0x16a, 240);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new Size(0x255, 0x29);
            this.textMessage.TabIndex = 12;
            this.textMessage.TextChanged += new EventHandler(this.textMessage_TextChanged);
            this.button2.Enabled = false;
            this.button2.Location = new Point(0x3c5, 240);
            this.button2.Name = "button2";
            this.button2.Size = new Size(0x49, 0x29);
            this.button2.TabIndex = 13;
            this.button2.Text = "Sent";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new EventHandler(this.button2_Click);
            this.label4.AutoSize = true;
            this.label4.Location = new Point(0x58, 0xac);
            this.label4.Name = "label4";
            this.label4.Size = new Size(60, 13);
            this.label4.TabIndex = 0x10;
            this.label4.Text = "Your port is";
            this.label4.Click += new EventHandler(this.label4_Click);
            this.label1.AutoSize = true;
            this.label1.Location = new Point(0x2a, 0x77);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x23, 13);
            this.label1.TabIndex = 0x11;
            this.label1.Text = "Name";
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new Point(0x5d, 200);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new Size(0x9f, 13);
            this.linkLabel1.TabIndex = 0x12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Want to know your IP address ?";
            this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.label3.AutoSize = true;
            this.label3.BackColor = SystemColors.Control;
            this.label3.Location = new Point(0xe7, 0x92);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x1a, 13);
            this.label3.TabIndex = 0x13;
            this.label3.Text = "Port";
            this.label3.Click += new EventHandler(this.label3_Click);
            this.label6.AutoSize = true;
            this.label6.Location = new Point(0x7c, 0x47);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x5d, 13);
            this.label6.TabIndex = 0x15;
            this.label6.Text = "A personal chatter";
            this.label8.AutoSize = true;
            this.label8.Location = new Point(0x1e2, 0x128);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0, 13);
            this.label8.TabIndex = 0x1b;
            this.label9.AutoSize = true;
            this.label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label9.Location = new Point(0x48, 0x5d);
            this.label9.Name = "label9";
            this.label9.Size = new Size(0xb0, 0x10);
            this.label9.TabIndex = 0x1c;
            this.label9.Text = "Please insert your partner's :";
            this.timer1.Interval = 1;
            this.timer1.Tick += new EventHandler(this.timer1_Tick);
            this.button3.Location = new Point(0x3c7, -1);
            this.button3.Name = "button3";
            this.button3.Size = new Size(0x42, 30);
            this.button3.TabIndex = 40;
            this.button3.Text = "End";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new EventHandler(this.button3_Click_2);
            this.time_lbl.AutoSize = true;
            this.time_lbl.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.time_lbl.Location = new Point(0x17f, 4);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new Size(0x33, 20);
            this.time_lbl.TabIndex = 0x29;
            this.time_lbl.Text = "label5";
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.startToolStripMenuItem, this.screenShareToolStripMenuItem, this.helpToolStripMenuItem };
            this.menuStrip1.Items.AddRange(toolStripItems);
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(0x150, 0x18);
            this.menuStrip1.TabIndex = 0x2e;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            toolStripItems = new ToolStripItem[] { this.iPToolStripMenuItem, this.hostToolStripMenuItem, this.portToolStripMenuItem, this.connectToolStripMenuItem, this.endChattingToolStripMenuItem, this.minimizeToolStripMenuItem, this.exitToolStripMenuItem };
            this.startToolStripMenuItem.DropDownItems.AddRange(toolStripItems);
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new Size(0x2b, 20);
            this.startToolStripMenuItem.Text = "Start";
            this.iPToolStripMenuItem.Name = "iPToolStripMenuItem";
            this.iPToolStripMenuItem.Size = new Size(0x98, 0x16);
            this.iPToolStripMenuItem.Text = "IP";
            this.iPToolStripMenuItem.Click += new EventHandler(this.iPToolStripMenuItem_Click);
            this.hostToolStripMenuItem.Name = "hostToolStripMenuItem";
            this.hostToolStripMenuItem.Size = new Size(0x98, 0x16);
            this.hostToolStripMenuItem.Text = "Host";
            this.hostToolStripMenuItem.Click += new EventHandler(this.hostToolStripMenuItem_Click);
            this.portToolStripMenuItem.Name = "portToolStripMenuItem";
            this.portToolStripMenuItem.Size = new Size(0x98, 0x16);
            this.portToolStripMenuItem.Text = "Port";
            this.portToolStripMenuItem.Click += new EventHandler(this.portToolStripMenuItem_Click);
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new Size(0x98, 0x16);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new EventHandler(this.connectToolStripMenuItem_Click_1);
            this.endChattingToolStripMenuItem.Name = "endChattingToolStripMenuItem";
            this.endChattingToolStripMenuItem.Size = new Size(0x98, 0x16);
            this.endChattingToolStripMenuItem.Text = "End Chatting";
            this.endChattingToolStripMenuItem.Click += new EventHandler(this.endChattingToolStripMenuItem_Click);
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new Size(0x98, 0x16);
            this.minimizeToolStripMenuItem.Text = "Minimize";
            this.minimizeToolStripMenuItem.Click += new EventHandler(this.minimizeToolStripMenuItem_Click);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new Size(0x98, 0x16);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new EventHandler(this.exitToolStripMenuItem_Click);
            toolStripItems = new ToolStripItem[] { this.shareToolStripMenuItem, this.downloaderToolStripMenuItem };
            this.screenShareToolStripMenuItem.DropDownItems.AddRange(toolStripItems);
            this.screenShareToolStripMenuItem.Name = "screenShareToolStripMenuItem";
            this.screenShareToolStripMenuItem.Size = new Size(0x31, 20);
            this.screenShareToolStripMenuItem.Text = "Other";
            toolStripItems = new ToolStripItem[] { this.downloadToolStripMenuItem };
            this.shareToolStripMenuItem.DropDownItems.AddRange(toolStripItems);
            this.shareToolStripMenuItem.Name = "shareToolStripMenuItem";
            this.shareToolStripMenuItem.Size = new Size(0x98, 0x16);
            this.shareToolStripMenuItem.Text = "Screen Share";
            this.shareToolStripMenuItem.Click += new EventHandler(this.shareToolStripMenuItem_Click);
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new Size(0x80, 0x16);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new EventHandler(this.downloadToolStripMenuItem_Click_1);
            toolStripItems = new ToolStripItem[] { this.downloadToolStripMenuItem1 };
            this.downloaderToolStripMenuItem.DropDownItems.AddRange(toolStripItems);
            this.downloaderToolStripMenuItem.Name = "downloaderToolStripMenuItem";
            this.downloaderToolStripMenuItem.Size = new Size(0x98, 0x16);
            this.downloaderToolStripMenuItem.Text = "Downloader";
            this.downloadToolStripMenuItem1.Name = "downloadToolStripMenuItem1";
            this.downloadToolStripMenuItem1.Size = new Size(0x98, 0x16);
            this.downloadToolStripMenuItem1.Text = "Download";
            this.downloadToolStripMenuItem1.Click += new EventHandler(this.downloadToolStripMenuItem1_Click_1);
            toolStripItems = new ToolStripItem[] { this.viewHelpToolStripMenuItem, this.visitOurSiteToolStripMenuItem };
            this.helpToolStripMenuItem.DropDownItems.AddRange(toolStripItems);
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new Size(0x2c, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new Size(0x98, 0x16);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new EventHandler(this.viewHelpToolStripMenuItem_Click);
            this.visitOurSiteToolStripMenuItem.Name = "visitOurSiteToolStripMenuItem";
            this.visitOurSiteToolStripMenuItem.Size = new Size(0x98, 0x16);
            this.visitOurSiteToolStripMenuItem.Text = "Visit Our Site";
            this.visitOurSiteToolStripMenuItem.Click += new EventHandler(this.visitOurSiteToolStripMenuItem_Click);
            this.pictureBox4.Cursor = Cursors.Arrow;
            this.pictureBox4.Image = Resources.Picture31;
            this.pictureBox4.Location = new Point(340, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new Size(0x25, 30);
            this.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0x27;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            this.pictureBox4.Click += new EventHandler(this.pictureBox4_Click_1);
            this.pictureBox1.Cursor = Cursors.Arrow;
            this.pictureBox1.Image = Resources.Picture2;
            this.pictureBox1.Location = new Point(0x40f, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(0x25, 30);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0x26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click_1);
            this.pictureBox2.Image = Resources.Picture111;
            this.pictureBox2.Location = new Point(3, 0x1b);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Size(0x41, 0x39);
            this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0x17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new EventHandler(this.pictureBox2_Click);
            this.picCapture.Location = new Point(0x419, 0xc5);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new Size(20, 15);
            this.picCapture.TabIndex = 0x2b;
            this.picCapture.TabStop = false;
            this.pictureBox3.Image = Resources.Picture1;
            this.pictureBox3.Location = new Point(0x23, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new Size(0x133, 0x58);
            this.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0x1d;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new EventHandler(this.pictureBox3_Click);
            this.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            this.notifyIcon1.Icon = (Icon) manager.GetObject("notifyIcon1.Icon");
            this.notifyIcon1.Text = "PigeonSENT";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new MouseEventHandler(this.notifyIcon1_Click);
            this.button4.Location = new Point(0x397, -2);
            this.button4.Name = "button4";
            this.button4.Size = new Size(0x2a, 0x1f);
            this.button4.TabIndex = 0x2f;
            this.button4.Text = "__";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new EventHandler(this.button4_Click);
            this.label5.AutoSize = true;
            this.label5.Location = new Point(0x124, 0x26);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x1a, 13);
            this.label5.TabIndex = 0x30;
            this.label5.Text = "Mini";
            this.label5.Visible = false;
            this.button5.Location = new Point(0x92, 1);
            this.button5.Name = "button5";
            this.button5.Size = new Size(0x4f, 0x17);
            this.button5.TabIndex = 0x31;
            this.button5.Text = "Phone Dialer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new EventHandler(this.button5_Click_1);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.WhiteSmoke;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            base.ClientSize = new Size(0x150, 0x128);
            base.Controls.Add(this.button5);
            base.Controls.Add(this.label5);
            base.Controls.Add(this.button4);
            base.Controls.Add(this.button3);
            base.Controls.Add(this.time_lbl);
            base.Controls.Add(this.pictureBox4);
            base.Controls.Add(this.pictureBox1);
            base.Controls.Add(this.pictureBox2);
            base.Controls.Add(this.menuStrip1);
            base.Controls.Add(this.picCapture);
            base.Controls.Add(this.listMessage);
            base.Controls.Add(this.label9);
            base.Controls.Add(this.label8);
            base.Controls.Add(this.label6);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.linkLabel1);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.textMessage);
            base.Controls.Add(this.textBox2);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.textFriendsIp);
            base.Controls.Add(this.textFriendsPort);
            base.Controls.Add(this.textLocalIp);
            base.Controls.Add(this.textLocalPort);
            base.Controls.Add(this.pictureBox3);
            this.DoubleBuffered = true;
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.Name = "Form2";
            this.Text = "PigeonSENT+";
            base.Load += new EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((ISupportInitialize) this.pictureBox4).EndInit();
            ((ISupportInitialize) this.pictureBox1).EndInit();
            ((ISupportInitialize) this.pictureBox2).EndInit();
            ((ISupportInitialize) this.picCapture).EndInit();
            ((ISupportInitialize) this.pictureBox3).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void iPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.iPToolStripMenuItem.Text = "IP = " + this.textLocalIp.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.label3.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.textLocalIp.Visible = true;
            this.linkLabel1.Visible = false;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void listMessage_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listmessage_TextChanged(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                if (this.sck.EndReceiveFrom(aResult, ref this.epRemote) > 0)
                {
                    byte[] buffer = new byte[0x5b8];
                    object[] objArray = new object[] { "(", DateTime.Now, ") ", this.textBox2.Text, ":", new ASCIIEncoding().GetString((byte[]) aResult.AsyncState) };
                    this.listMessage.Items.Add(string.Concat(objArray));
                }
                byte[] buffer2 = new byte[0x5dc];
                this.sck.BeginReceiveFrom(buffer2, 0, buffer2.Length, SocketFlags.None, ref this.epRemote, new AsyncCallback(this.MessageCallBack), buffer2);
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString());
            }
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.notifyIcon1.Visible = true;
            base.Visible = false;
            this.notifyIcon1.BalloonTipTitle = "PigeonSENT is still running";
            this.notifyIcon1.BalloonTipText = "Please click this icon to resume chatting";
            this.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            this.notifyIcon1.ShowBalloonTip(0x3e8);
        }

        private void notifyIcon1_Click(object sender, MouseEventArgs e)
        {
            base.Visible = true;
            this.notifyIcon1.Visible = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.listMessage.Size = new Size(0x17d, 0xad);
            this.listMessage.Location = new Point(3, 90);
            this.textMessage.Location = new Point(3, 0x10c);
            this.textMessage.Size = new Size(0x12e, 0x29);
            this.time_lbl.Location = new Point(-1, 0x138);
            this.time_lbl.Size = new Size(0x33, 20);
            this.button2.Location = new Point(0x137, 0x10d);
            this.button2.Size = new Size(0x49, 0x29);
            this.pictureBox4.Visible = true;
            this.button4.Location = new Point(0x15c, 0x1f);
            this.button4.Size = new Size(0x2a, 0x1f);
            this.button3.Location = new Point(0x144, 0x3e);
            this.button3.Size = new Size(0x42, 30);
            base.ClientSize = new Size(390, 0x14f);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            this.label5.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.button3.Location = new Point(0x3c7, -1);
            this.button4.Location = new Point(0x397, -2);
            this.label5.Visible = false;
            this.pictureBox4.Visible = false;
            this.listMessage.Location = new Point(0x17a, 0x4a);
            this.listMessage.Size = new Size(0x261, 0xad);
            this.textMessage.Location = new Point(0x16a, 0xfd);
            this.textMessage.Size = new Size(0x234, 0x29);
            this.button2.Location = new Point(0x3a0, 0xfd);
            this.button2.Size = new Size(0x49, 0x29);
            base.ClientSize = new Size(0x434, 0x128);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void portToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.portToolStripMenuItem.Text = "Port = " + this.textLocalPort.Text;
        }

        private void shareToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void textFriendsPort_Click(object sender, EventArgs e)
        {
        }

        private void textLocalIp_TextChanged(object sender, EventArgs e)
        {
        }

        private void textMessage_TextChanged(object sender, EventArgs e)
        {
            this.button2.Visible = true;
            this.button2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.time_lbl.Text = DateTime.Now.ToString();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void visitOurSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("www.pigeonsent.webs.com");
        }
    }
}

