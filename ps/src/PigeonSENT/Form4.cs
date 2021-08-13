namespace PigeonSENT
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class Form4 : Form
    {
        private IContainer components = null;
        private Label label1;
        private Label label2;

        public Form4()
        {
            this.InitializeComponent();
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form4));
            this.label1 = new Label();
            this.label2 = new Label();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x88, 0x19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduction";
            this.label2.AutoSize = true;
            this.label2.Location = new Point(0x11, 0x33);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x13e, 0x5b);
            this.label2.TabIndex = 1;
            this.label2.Text = manager.GetString("label2.Text");
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(360, 0xa7);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.Name = "Form4";
            this.Text = "Introduction -=PigeonSENT=-";
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}

