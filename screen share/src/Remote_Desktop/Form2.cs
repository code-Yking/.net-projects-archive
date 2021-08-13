namespace Remote_Desktop
{
    using Microsoft.VisualBasic.CompilerServices;
    using Remote_Desktop.My;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class Form2 : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("Button1")]
        private Button _Button1;
        [AccessedThroughProperty("Button2")]
        private Button _Button2;

        [DebuggerNonUserCode]
        public Form2()
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
            this.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MyProject.Forms.Form3.Show();
            this.Visible = false;
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form2));
            this.Button1 = new Button();
            this.Button2 = new Button();
            this.SuspendLayout();
            Point point2 = new Point(12, 12);
            this.Button1.Location = point2;
            this.Button1.Name = "Button1";
            Size size2 = new Size(0xa3, 0x1a);
            this.Button1.Size = size2;
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Share";
            this.Button1.UseVisualStyleBackColor = true;
            point2 = new Point(0xc4, 12);
            this.Button2.Location = point2;
            this.Button2.Name = "Button2";
            size2 = new Size(0xa3, 0x1a);
            this.Button2.Size = size2;
            this.Button2.TabIndex = 1;
            this.Button2.Text = "Listen";
            this.Button2.UseVisualStyleBackColor = true;
            SizeF ef2 = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef2;
            this.AutoScaleMode = AutoScaleMode.Font;
            size2 = new Size(0x179, 0x2a);
            this.ClientSize = size2;
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.Icon = (Icon) manager.GetObject("$this.Icon");
            this.Name = "Form2";
            this.Text = "Screen Sharing - Samuel Kurian";
            this.ResumeLayout(false);
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
    }
}

