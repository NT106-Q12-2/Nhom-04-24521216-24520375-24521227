namespace Cau3
{
    partial class ShowHTML
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtb_htmlview = new RichTextBox();
            SuspendLayout();
            // 
            // rtb_htmlview
            // 
            rtb_htmlview.Dock = DockStyle.Fill;
            rtb_htmlview.Location = new Point(0, 0);
            rtb_htmlview.Name = "rtb_htmlview";
            rtb_htmlview.ReadOnly = true;
            rtb_htmlview.Size = new Size(800, 450);
            rtb_htmlview.TabIndex = 0;
            rtb_htmlview.Text = "";
            // 
            // ShowHTML
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtb_htmlview);
            Name = "ShowHTML";
            Text = "Show HTML";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtb_htmlview;
    }
}