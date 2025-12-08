namespace Lab4
{
    partial class Cau1
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
            tb_webURL = new TextBox();
            btn_get = new Button();
            rtb_showHTML = new RichTextBox();
            SuspendLayout();
            // 
            // tb_webURL
            // 
            tb_webURL.Location = new Point(12, 24);
            tb_webURL.Name = "tb_webURL";
            tb_webURL.Size = new Size(608, 31);
            tb_webURL.TabIndex = 0;
            // 
            // btn_get
            // 
            btn_get.Location = new Point(639, 21);
            btn_get.Name = "btn_get";
            btn_get.Size = new Size(112, 34);
            btn_get.TabIndex = 1;
            btn_get.Text = "Get";
            btn_get.UseVisualStyleBackColor = true;
            btn_get.Click += btn_get_Click;
            // 
            // rtb_showHTML
            // 
            rtb_showHTML.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtb_showHTML.Location = new Point(0, 73);
            rtb_showHTML.Name = "rtb_showHTML";
            rtb_showHTML.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtb_showHTML.Size = new Size(759, 405);
            rtb_showHTML.TabIndex = 2;
            rtb_showHTML.Text = "";
            // 
            // Cau1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 478);
            Controls.Add(rtb_showHTML);
            Controls.Add(btn_get);
            Controls.Add(tb_webURL);
            Name = "Cau1";
            Text = "Câu 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_webURL;
        private Button btn_get;
        private RichTextBox rtb_showHTML;
    }
}
