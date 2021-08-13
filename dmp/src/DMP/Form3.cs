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
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class Form3 : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("Button1")]
        private Button _Button1;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;

        [DebuggerNonUserCode]
        public Form3()
        {
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
            MyProject.Forms.Form1.Show();
            this.Close();
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
            this.Button1 = new Button();
            this.Label1 = new Label();
            this.Label2 = new Label();
            this.Label3 = new Label();
            this.Label4 = new Label();
            this.SuspendLayout();
            this.Button1.BackColor = Color.MintCream;
            this.Button1.Cursor = Cursors.Hand;
            this.Button1.FlatStyle = FlatStyle.Popup;
            this.Button1.Font = new Font("Cooper Black", 21.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Point point2 = new Point(0x14e, 0x6f);
            this.Button1.Location = point2;
            this.Button1.Name = "Button1";
            Size size2 = new Size(0x94, 0x34);
            this.Button1.Size = size2;
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Open";
            this.Button1.UseVisualStyleBackColor = false;
            this.Label1.AutoSize = true;
            this.Label1.BackColor = Color.Transparent;
            this.Label1.Font = new Font("Mistral", 72f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point2 = new Point(12, 0xcf);
            this.Label1.Location = point2;
            this.Label1.Name = "Label1";
            size2 = new Size(0x12e, 0x72);
            this.Label1.Size = size2;
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Welcome";
            this.Label2.AutoSize = true;
            this.Label2.BackColor = Color.Transparent;
            this.Label2.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = Color.FromArgb(0, 0, 0xc0);
            point2 = new Point(0x11f, 0xc1);
            this.Label2.Location = point2;
            this.Label2.Name = "Label2";
            size2 = new Size(0x10b, 0x1d);
            this.Label2.Size = size2;
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Download Manager Pro";
            this.Label3.AutoSize = true;
            this.Label3.BackColor = Color.Transparent;
            this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point2 = new Point(370, 0xeb);
            this.Label3.Location = point2;
            this.Label3.Name = "Label3";
            size2 = new Size(0x4a, 0x10);
            this.Label3.Size = size2;
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Version 2.0";
            this.Label4.AutoSize = true;
            this.Label4.BackColor = Color.Transparent;
            this.Label4.Font = new Font("Modern No. 20", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point2 = new Point(0x137, 260);
            this.Label4.Location = point2;
            this.Label4.Name = "Label4";
            size2 = new Size(0xc2, 0x12);
            this.Label4.Size = size2;
            this.Label4.TabIndex = 4;
            this.Label4.Text = "DMP \x00a9 All Right Reserved.";
            SizeF ef2 = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef2;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackgroundImage = DMP.My.Resources.Resources.Picture11;
            size2 = new Size(0x236, 330);
            this.ClientSize = size2;
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button1);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();
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
    }
}

