namespace Remote_Desktop
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Net.Sockets;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class Form1 : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("TextBox1")]
        private TextBox _TextBox1;
        [AccessedThroughProperty("TextBox2")]
        private TextBox _TextBox2;
        [AccessedThroughProperty("Button1")]
        private Button _Button1;
        [AccessedThroughProperty("Button2")]
        private Button _Button2;
        [AccessedThroughProperty("Timer1")]
        private Timer _Timer1;
        private TcpClient client;
        private NetworkStream ns;
        private int port;

        public Form1()
        {
            __ENCAddToList(this);
            this.client = new TcpClient();
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

        private void Button1_Click(object sender, EventArgs e)
        {
            this.port = int.Parse(this.TextBox2.Text);
            try
            {
                this.client.Connect(this.TextBox1.Text, this.port);
                Interaction.MsgBox("Client connected !", MsgBoxStyle.ApplicationModal, null);
                this.Button1.Text = "Connected";
                this.Button1.Enabled = false;
                this.Button2.Enabled = true;
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                Interaction.MsgBox("Failed to connect...", MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Timer1.Start();
        }

        public Image Desktop()
        {
            Rectangle bounds = new Rectangle();
            Bitmap image = null;
            bounds = Screen.PrimaryScreen.Bounds;
            image = new Bitmap(bounds.Width, bounds.Height, PixelFormat.Format32bppArgb);
            Graphics.FromImage(image).CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy);
            return image;
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

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form1));
            this.Label1 = new Label();
            this.Label2 = new Label();
            this.TextBox1 = new TextBox();
            this.TextBox2 = new TextBox();
            this.Button1 = new Button();
            this.Button2 = new Button();
            this.Timer1 = new Timer(this.components);
            this.SuspendLayout();
            this.Label1.AutoSize = true;
            Point point2 = new Point(12, 15);
            this.Label1.Location = point2;
            this.Label1.Name = "Label1";
            Size size2 = new Size(20, 13);
            this.Label1.Size = size2;
            this.Label1.TabIndex = 0;
            this.Label1.Text = "IP:";
            this.Label2.AutoSize = true;
            point2 = new Point(0x12, 0x85);
            this.Label2.Location = point2;
            this.Label2.Name = "Label2";
            size2 = new Size(40, 13);
            this.Label2.Size = size2;
            this.Label2.TabIndex = 1;
            this.Label2.Text = "PORT:";
            point2 = new Point(0x42, 12);
            this.TextBox1.Location = point2;
            this.TextBox1.Name = "TextBox1";
            size2 = new Size(0x84, 20);
            this.TextBox1.Size = size2;
            this.TextBox1.TabIndex = 2;
            point2 = new Point(0x42, 0x7e);
            this.TextBox2.Location = point2;
            this.TextBox2.Name = "TextBox2";
            size2 = new Size(0x84, 20);
            this.TextBox2.Size = size2;
            this.TextBox2.TabIndex = 3;
            this.TextBox2.Text = "65";
            point2 = new Point(12, 0x2c);
            this.Button1.Location = point2;
            this.Button1.Name = "Button1";
            size2 = new Size(0x59, 0x17);
            this.Button1.Size = size2;
            this.Button1.TabIndex = 4;
            this.Button1.Text = "Connect";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button2.Enabled = false;
            point2 = new Point(0x6c, 0x2c);
            this.Button2.Location = point2;
            this.Button2.Name = "Button2";
            size2 = new Size(90, 0x17);
            this.Button2.Size = size2;
            this.Button2.TabIndex = 5;
            this.Button2.Text = "Send Desktop";
            this.Button2.UseVisualStyleBackColor = true;
            SizeF ef2 = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef2;
            this.AutoScaleMode = AutoScaleMode.Font;
            size2 = new Size(210, 0x4b);
            this.ClientSize = size2;
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Icon = (Icon) manager.GetObject("$this.Icon");
            this.Name = "Form1";
            this.Text = "Screen Sharing - Client";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void SendDesktop()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            this.ns = this.client.GetStream();
            formatter.Serialize(this.ns, this.Desktop());
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.SendDesktop();
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

        internal virtual Label Label2
        {
            [DebuggerNonUserCode]
            get => 
                this._Label2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label2 = value;
        }

        internal virtual TextBox TextBox1
        {
            [DebuggerNonUserCode]
            get => 
                this._TextBox1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._TextBox1 = value;
        }

        internal virtual TextBox TextBox2
        {
            [DebuggerNonUserCode]
            get => 
                this._TextBox2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._TextBox2 = value;
        }

        internal virtual Button Button1
        {
            [DebuggerNonUserCode]
            get => 
                this._Button1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Button1_Click);
                if (!ReferenceEquals(this._Button1, null))
                {
                    this._Button1.Click -= handler;
                }
                this._Button1 = value;
                if (!ReferenceEquals(this._Button1, null))
                {
                    this._Button1.Click += handler;
                }
            }
        }

        internal virtual Button Button2
        {
            [DebuggerNonUserCode]
            get => 
                this._Button2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Button2_Click);
                if (!ReferenceEquals(this._Button2, null))
                {
                    this._Button2.Click -= handler;
                }
                this._Button2 = value;
                if (!ReferenceEquals(this._Button2, null))
                {
                    this._Button2.Click += handler;
                }
            }
        }

        internal virtual Timer Timer1
        {
            [DebuggerNonUserCode]
            get => 
                this._Timer1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Timer1_Tick);
                if (!ReferenceEquals(this._Timer1, null))
                {
                    this._Timer1.Tick -= handler;
                }
                this._Timer1 = value;
                if (!ReferenceEquals(this._Timer1, null))
                {
                    this._Timer1.Tick += handler;
                }
            }
        }
    }
}

