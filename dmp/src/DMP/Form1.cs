namespace DMP
{
    using DMP.My;
    using DMP.My.Resources;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Net;
    using System.Runtime.CompilerServices;
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
        [AccessedThroughProperty("cmdsave")]
        private Button _cmdsave;
        [AccessedThroughProperty("ProgressBar1")]
        private ProgressBar _ProgressBar1;
        [AccessedThroughProperty("SaveFileDialog1")]
        private SaveFileDialog _SaveFileDialog1;
        [AccessedThroughProperty("Button1")]
        private Button _Button1;
        [AccessedThroughProperty("ProgressBar2")]
        private ProgressBar _ProgressBar2;
        [AccessedThroughProperty("Button2")]
        private Button _Button2;
        [AccessedThroughProperty("Button3")]
        private Button _Button3;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Button4")]
        private Button _Button4;
        [AccessedThroughProperty("download")]
        private WebClient _download;

        [DebuggerNonUserCode]
        public Form1()
        {
            base.Load += new EventHandler(this.Form1_Load);
            __ENCAddToList(this);
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
            this.download = new WebClient();
            this.download.DownloadFileAsync(new Uri(this.TextBox1.Text), this.TextBox2.Text);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MyProject.Forms.Form2.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Process.Start("www.downloadmanagerpro.blogspot.com");
        }

        private void cmdsave_Click(object sender, EventArgs e)
        {
            this.SaveFileDialog1.Filter = ".jpg|*.jpg|.exe|*.exe|.zip|*.zip|.rar|*.rar|.png|*.png|.gif|*.gif|.mp4|*.mp4|.iso|*.iso|.mp3|*.mp3";
            this.SaveFileDialog1.ShowDialog();
            this.TextBox2.Text = this.SaveFileDialog1.FileName;
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

        private void download_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.ProgressBar1.Value = e.ProgressPercentage;
            this.ProgressBar2.Value = e.ProgressPercentage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form1));
            this.Label1 = new Label();
            this.Label2 = new Label();
            this.TextBox1 = new TextBox();
            this.TextBox2 = new TextBox();
            this.cmdsave = new Button();
            this.ProgressBar1 = new ProgressBar();
            this.SaveFileDialog1 = new SaveFileDialog();
            this.ProgressBar2 = new ProgressBar();
            this.Button3 = new Button();
            this.Button2 = new Button();
            this.Button1 = new Button();
            this.Label3 = new Label();
            this.Label4 = new Label();
            this.Button4 = new Button();
            this.SuspendLayout();
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("20th Century Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = Color.Maroon;
            Point point2 = new Point(0x2f, 0x1a);
            this.Label1.Location = point2;
            this.Label1.Name = "Label1";
            Size size2 = new Size(0x2c, 20);
            this.Label1.Size = size2;
            this.Label1.TabIndex = 0;
            this.Label1.Text = "URL:";
            this.Label2.AutoSize = true;
            this.Label2.Font = new Font("20th Century Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = Color.Yellow;
            point2 = new Point(14, 0x34);
            this.Label2.Location = point2;
            this.Label2.Name = "Label2";
            size2 = new Size(0x4d, 20);
            this.Label2.Size = size2;
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Save As:";
            point2 = new Point(0x67, 0x17);
            this.TextBox1.Location = point2;
            this.TextBox1.Name = "TextBox1";
            size2 = new Size(0x241, 20);
            this.TextBox1.Size = size2;
            this.TextBox1.TabIndex = 2;
            point2 = new Point(0x67, 0x33);
            this.TextBox2.Location = point2;
            this.TextBox2.Name = "TextBox2";
            size2 = new Size(0x1e8, 20);
            this.TextBox2.Size = size2;
            this.TextBox2.TabIndex = 3;
            this.cmdsave.BackColor = SystemColors.GradientActiveCaption;
            this.cmdsave.FlatStyle = FlatStyle.Flat;
            point2 = new Point(0x255, 0x31);
            this.cmdsave.Location = point2;
            this.cmdsave.Name = "cmdsave";
            size2 = new Size(70, 0x17);
            this.cmdsave.Size = size2;
            this.cmdsave.TabIndex = 4;
            this.cmdsave.Text = "Browse";
            this.cmdsave.UseVisualStyleBackColor = false;
            point2 = new Point(0, -8);
            this.ProgressBar1.Location = point2;
            this.ProgressBar1.Name = "ProgressBar1";
            size2 = new Size(0x2c3, 10);
            this.ProgressBar1.Size = size2;
            this.ProgressBar1.TabIndex = 6;
            this.ProgressBar2.Cursor = Cursors.UpArrow;
            point2 = new Point(0x20, 0x77);
            this.ProgressBar2.Location = point2;
            this.ProgressBar2.Name = "ProgressBar2";
            size2 = new Size(0x288, 13);
            this.ProgressBar2.Size = size2;
            this.ProgressBar2.TabIndex = 10;
            this.Button3.FlatStyle = FlatStyle.System;
            point2 = new Point(0x26f, 0x8a);
            this.Button3.Location = point2;
            this.Button3.Name = "Button3";
            size2 = new Size(0x52, 0x15);
            this.Button3.Size = size2;
            this.Button3.TabIndex = 12;
            this.Button3.Text = "Cancel";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button2.BackgroundImage = DMP.My.Resources.Resources.Open_File;
            this.Button2.BackgroundImageLayout = ImageLayout.Stretch;
            this.Button2.Cursor = Cursors.Hand;
            this.Button2.FlatStyle = FlatStyle.Flat;
            point2 = new Point(0x28d, 0x4b);
            this.Button2.Location = point2;
            this.Button2.Name = "Button2";
            size2 = new Size(40, 0x26);
            this.Button2.Size = size2;
            this.Button2.TabIndex = 11;
            this.Button2.UseVisualStyleBackColor = true;
            this.Button1.BackColor = Color.SteelBlue;
            this.Button1.BackgroundImage = DMP.My.Resources.Resources.Download;
            this.Button1.BackgroundImageLayout = ImageLayout.Stretch;
            this.Button1.Cursor = Cursors.Hand;
            this.Button1.FlatStyle = FlatStyle.Popup;
            this.Button1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point2 = new Point(0x10d, 0x4c);
            this.Button1.Location = point2;
            this.Button1.Name = "Button1";
            size2 = new Size(0x92, 0x25);
            this.Button1.Size = size2;
            this.Button1.TabIndex = 9;
            this.Button1.UseVisualStyleBackColor = false;
            this.Label3.AutoSize = true;
            point2 = new Point(270, 0x8e);
            this.Label3.Location = point2;
            this.Label3.Name = "Label3";
            size2 = new Size(0x89, 13);
            this.Label3.Size = size2;
            this.Label3.TabIndex = 14;
            this.Label3.Text = "DMP     All rights Reserved.";
            this.Label4.AutoSize = true;
            this.Label4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point2 = new Point(0x128, 140);
            this.Label4.Location = point2;
            this.Label4.Name = "Label4";
            size2 = new Size(0x10, 15);
            this.Label4.Size = size2;
            this.Label4.TabIndex = 15;
            this.Label4.Text = "\x00a9";
            this.Button4.BackColor = Color.SteelBlue;
            this.Button4.FlatStyle = FlatStyle.Popup;
            point2 = new Point(12, 0x8a);
            this.Button4.Location = point2;
            this.Button4.Name = "Button4";
            size2 = new Size(0x41, 0x15);
            this.Button4.Size = size2;
            this.Button4.TabIndex = 0x10;
            this.Button4.Text = "Our Web";
            this.Button4.UseVisualStyleBackColor = false;
            SizeF ef2 = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef2;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.HotTrack;
            size2 = new Size(0x2c1, 160);
            this.ClientSize = size2;
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.ProgressBar2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.cmdsave);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.Icon = (Icon) manager.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Download Manager Pro";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            this.download = new WebClient();
            this.download.DownloadFileAsync(new Uri(this.TextBox1.Text), this.TextBox2.Text);
        }

        private void Label3_Click_1(object sender, EventArgs e)
        {
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            Process.Start(this.TextBox2.Text);
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {
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

        internal virtual Button cmdsave
        {
            [DebuggerNonUserCode]
            get => 
                this._cmdsave;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.cmdsave_Click);
                if (!ReferenceEquals(this._cmdsave, null))
                {
                    this._cmdsave.Click -= handler;
                }
                this._cmdsave = value;
                if (!ReferenceEquals(this._cmdsave, null))
                {
                    this._cmdsave.Click += handler;
                }
            }
        }

        internal virtual ProgressBar ProgressBar1
        {
            [DebuggerNonUserCode]
            get => 
                this._ProgressBar1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.ProgressBar1_Click);
                if (!ReferenceEquals(this._ProgressBar1, null))
                {
                    this._ProgressBar1.Click -= handler;
                }
                this._ProgressBar1 = value;
                if (!ReferenceEquals(this._ProgressBar1, null))
                {
                    this._ProgressBar1.Click += handler;
                }
            }
        }

        internal virtual SaveFileDialog SaveFileDialog1
        {
            [DebuggerNonUserCode]
            get => 
                this._SaveFileDialog1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._SaveFileDialog1 = value;
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

        internal virtual ProgressBar ProgressBar2
        {
            [DebuggerNonUserCode]
            get => 
                this._ProgressBar2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._ProgressBar2 = value;
        }

        internal virtual Button Button2
        {
            [DebuggerNonUserCode]
            get => 
                this._Button2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Button2 = value;
        }

        internal virtual Button Button3
        {
            [DebuggerNonUserCode]
            get => 
                this._Button3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Button3_Click);
                if (!ReferenceEquals(this._Button3, null))
                {
                    this._Button3.Click -= handler;
                }
                this._Button3 = value;
                if (!ReferenceEquals(this._Button3, null))
                {
                    this._Button3.Click += handler;
                }
            }
        }

        internal virtual Label Label3
        {
            [DebuggerNonUserCode]
            get => 
                this._Label3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label3 = value;
        }

        internal virtual Label Label4
        {
            [DebuggerNonUserCode]
            get => 
                this._Label4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label4 = value;
        }

        internal virtual Button Button4
        {
            [DebuggerNonUserCode]
            get => 
                this._Button4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Button4_Click);
                if (!ReferenceEquals(this._Button4, null))
                {
                    this._Button4.Click -= handler;
                }
                this._Button4 = value;
                if (!ReferenceEquals(this._Button4, null))
                {
                    this._Button4.Click += handler;
                }
            }
        }

        public virtual WebClient download
        {
            [DebuggerNonUserCode]
            get => 
                this._download;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                DownloadProgressChangedEventHandler handler = new DownloadProgressChangedEventHandler(this.download_DownloadProgressChanged);
                if (!ReferenceEquals(this._download, null))
                {
                    this._download.DownloadProgressChanged -= handler;
                }
                this._download = value;
                if (!ReferenceEquals(this._download, null))
                {
                    this._download.DownloadProgressChanged += handler;
                }
            }
        }
    }
}

