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
    public class Form3 : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("TextBox1")]
        private TextBox _TextBox1;
        [AccessedThroughProperty("Button1")]
        private Button _Button1;

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
            MyProject.Forms.Form4.Show();
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form3));
            this.Label1 = new Label();
            this.TextBox1 = new TextBox();
            this.Button1 = new Button();
            this.SuspendLayout();
            this.Label1.AutoSize = true;
            Point point2 = new Point(0x1c, 0x25);
            this.Label1.Location = point2;
            this.Label1.Name = "Label1";
            Size size2 = new Size(40, 13);
            this.Label1.Size = size2;
            this.Label1.TabIndex = 0;
            this.Label1.Text = "PORT:";
            point2 = new Point(0x66, 30);
            this.TextBox1.Location = point2;
            this.TextBox1.Name = "TextBox1";
            size2 = new Size(100, 20);
            this.TextBox1.Size = size2;
            this.TextBox1.TabIndex = 1;
            this.TextBox1.Text = "65";
            point2 = new Point(0x51, 1);
            this.Button1.Location = point2;
            this.Button1.Name = "Button1";
            size2 = new Size(110, 0x17);
            this.Button1.Size = size2;
            this.Button1.TabIndex = 2;
            this.Button1.Text = "Begin Listening";
            this.Button1.UseVisualStyleBackColor = true;
            SizeF ef2 = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef2;
            this.AutoScaleMode = AutoScaleMode.Font;
            size2 = new Size(280, 0x1b);
            this.ClientSize = size2;
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.Icon = (Icon) manager.GetObject("$this.Icon");
            this.Name = "Form3";
            this.Text = "Screen Sharing - Server";
            this.ResumeLayout(false);
            this.PerformLayout();
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

        internal virtual TextBox TextBox1
        {
            [DebuggerNonUserCode]
            get => 
                this._TextBox1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._TextBox1 = value;
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
    }
}

