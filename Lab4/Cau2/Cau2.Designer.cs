namespace Cau2
{
    partial class Cau2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_url = new TextBox();
            tb_filepath = new TextBox();
            btn_download = new Button();
            rtb_showhtml = new RichTextBox();
            SuspendLayout();
            // 
            // tb_url
            // 
            tb_url.Location = new Point(12, 12);
            tb_url.Name = "tb_url";
            tb_url.Size = new Size(641, 31);
            tb_url.TabIndex = 0;
            // 
            // tb_filepath
            // 
            tb_filepath.Location = new Point(12, 71);
            tb_filepath.Name = "tb_filepath";
            tb_filepath.ReadOnly = true;
            tb_filepath.Size = new Size(641, 31);
            tb_filepath.TabIndex = 1;
            // 
            // btn_download
            // 
            btn_download.Location = new Point(676, 12);
            btn_download.Name = "btn_download";
            btn_download.Size = new Size(138, 34);
            btn_download.TabIndex = 2;
            btn_download.Text = "DOWNLOAD";
            btn_download.UseVisualStyleBackColor = true;
            btn_download.Click += btn_download_Click;
            // 
            // rtb_showhtml
            // 
            rtb_showhtml.Dock = DockStyle.Bottom;
            rtb_showhtml.Location = new Point(0, 129);
            rtb_showhtml.Name = "rtb_showhtml";
            rtb_showhtml.Size = new Size(826, 321);
            rtb_showhtml.TabIndex = 3;
            rtb_showhtml.Text = "";
            // 
            // Cau2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 450);
            Controls.Add(rtb_showhtml);
            Controls.Add(btn_download);
            Controls.Add(tb_filepath);
            Controls.Add(tb_url);
            Name = "Cau2";
            Text = "Câu 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_url;
        private TextBox tb_filepath;
        private Button btn_download;
        private RichTextBox rtb_showhtml;
    }
}
