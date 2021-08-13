namespace Remote_Desktop
{
    using Microsoft.VisualBasic.CompilerServices;
    using Remote_Desktop.My;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Net.Sockets;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Threading;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class Form4 : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("Panel1")]
        private Panel _Panel1;
        [AccessedThroughProperty("PictureBox1")]
        private PictureBox _PictureBox1;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        private TcpClient client;
        private int port;
        private TcpListener server;
        private NetworkStream ns;
        private Thread listening;
        private Thread GetImage;

        public Form4()
        {
            base.Load += new EventHandler(this.Form3_Load);
            __ENCAddToList(this);
            this.client = new TcpClient();
            this.listening = new Thread(new ThreadStart(this.Listen));
            this.GetImage = new Thread(new ThreadStart(this.ReceiveImage));
            this.InitializeComponent();
        }

        [DebuggerNonUserCode]
        private static void __ENCAddToList(object value)
        {
            List<WeakReference> list = __ENCList;
            lock (list)
            {
                if (__ENCList.Count == __ENCList.Capacity)
                {
                    int index = 0;
                    int num3 = __ENCList.Count - 1;
                    int num2 = 0;
                    while (true)
                    {
                        int num4 = num3;
                        if (num2 > num4)
                        {
                            __ENCList.RemoveRange(index, __ENCList.Count - index);
                            __ENCList.Capacity = __ENCList.Count;
                            break;
                        }
                        WeakReference reference = __ENCList[num2];
                        if (reference.IsAlive)
                        {
                            if (num2 != index)
                            {
                                __ENCList[index] = __ENCList[num2];
                            }
                            index++;
                        }
                        num2++;
                    }
                }
                __ENCList.Add(new WeakReference(value));
            }
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (((!disposing || (this.components == null)) ? 0 : 1) != 0)
                {
                    this.components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.port = int.Parse(MyProject.Forms.Form3.TextBox1.Text);
            this.server = new TcpListener(this.port);
            this.listening.Start();
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form4));
            this.Panel1 = new Panel();
            this.PictureBox1 = new PictureBox();
            this.Label1 = new Label();
            this.Panel1.SuspendLayout();
            ((ISupportInitialize) this.PictureBox1).BeginInit();
            this.SuspendLayout();
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Dock = DockStyle.Fill;
            Point point2 = new Point(0, 0);
            this.Panel1.Location = point2;
            this.Panel1.Name = "Panel1";
            Size size2 = new Size(0x2ec, 0x209);
            this.Panel1.Size = size2;
            this.Panel1.TabIndex = 0;
            this.PictureBox1.Dock = DockStyle.Fill;
            point2 = new Point(0, 0);
            this.PictureBox1.Location = point2;
            this.PictureBox1.Name = "PictureBox1";
            size2 = new Size(0x2ec, 0x209);
            this.PictureBox1.Size = size2;
            this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            this.Label1.AutoSize = true;
            point2 = new Point(3, 0);
            this.Label1.Location = point2;
            this.Label1.Name = "Label1";
            size2 = new Size(0x183, 13);
            this.Label1.Size = size2;
            this.Label1.TabIndex = 1;
            this.Label1.Text = "You will be able to see the remote screen only after they connect. Please wait.....";
            SizeF ef2 = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef2;
            this.AutoScaleMode = AutoScaleMode.Font;
            size2 = new Size(0x2ec, 0x209);
            this.ClientSize = size2;
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.Icon = (Icon) manager.GetObject("$this.Icon");
            this.Name = "Form4";
            this.Text = "Screen Sharing - Viewing";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((ISupportInitialize) this.PictureBox1).EndInit();
            this.ResumeLayout(false);
        }

        private void Listen()
        {
            while (true)
            {
                if (this.client.Connected)
                {
                    this.GetImage.Start();
                    return;
                }
                this.server.Start();
                this.client = this.server.AcceptTcpClient();
            }
        }

        private void ReceiveImage()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            while (this.client.Connected)
            {
                this.ns = this.client.GetStream();
                this.PictureBox1.Image = (Image) formatter.Deserialize(this.ns);
            }
        }

        internal virtual Panel Panel1
        {
            [DebuggerNonUserCode]
            get => 
                this._Panel1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Panel1 = value;
        }

        internal virtual PictureBox PictureBox1
        {
            [DebuggerNonUserCode]
            get => 
                this._PictureBox1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._PictureBox1 = value;
        }

        internal virtual Label Label1
        {
            [DebuggerNonUserCode]
            get => 
                this._Label1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label1 = value;
        }
    }
}

