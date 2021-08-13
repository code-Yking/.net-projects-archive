namespace PigeonSENT
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    public class Form2 : Form
    {
        private IContainer components = null;
        private Label label1;
        private Button button1;
        private Button button2;

        public Form2()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        protected override void Dispose(bool disposing)
        {
            if (!(!disposing || ReferenceEquals(this.components, null)))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form2));
            this.label1 = new Label();
            this.button1 = new Button();
            this.button2 = new Button();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you realy want to stop chatting with PigeonSENT?";
            this.button1.Location = new Point(14, 40);
            this.button1.Name = "button1";
            this.button1.Size = new Size(0x6a, 0x17);
            this.button1.TabIndex = 1;
            this.button1.Text = "Yes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.button2.Location = new Point(0x9e, 40);
            this.button2.Name = "button2";
            this.button2.Size = new Size(0x6a, 0x17);
            this.button2.TabIndex = 2;
            this.button2.Text = "No";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new EventHandler(this.button2_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x114, 0x47);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.label1);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.Name = "Form2";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Exit -=PigeonSENT=-";
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}

