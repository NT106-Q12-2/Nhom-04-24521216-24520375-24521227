namespace Cau3
{
    partial class Cau3
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
            wbvw2_shweb = new Microsoft.Web.WebView2.WinForms.WebView2();
            tb_url = new TextBox();
            btn_reload = new Button();
            btn_load = new Button();
            btn_downfile = new Button();
            btn_downresources = new Button();
            ((System.ComponentModel.ISupportInitialize)wbvw2_shweb).BeginInit();
            SuspendLayout();
            // 
            // wbvw2_shweb
            // 
            wbvw2_shweb.AllowExternalDrop = true;
            wbvw2_shweb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            wbvw2_shweb.CreationProperties = null;
            wbvw2_shweb.DefaultBackgroundColor = Color.White;
            wbvw2_shweb.Location = new Point(2, 112);
            wbvw2_shweb.Name = "wbvw2_shweb";
            wbvw2_shweb.Size = new Size(1012, 383);
            wbvw2_shweb.TabIndex = 0;
            wbvw2_shweb.ZoomFactor = 1D;
            // 
            // tb_url
            // 
            tb_url.Location = new Point(203, 15);
            tb_url.Name = "tb_url";
            tb_url.Size = new Size(629, 31);
            tb_url.TabIndex = 1;
            // 
            // btn_reload
            // 
            btn_reload.Location = new Point(30, 12);
            btn_reload.Name = "btn_reload";
            btn_reload.Size = new Size(133, 34);
            btn_reload.TabIndex = 2;
            btn_reload.Text = "Reload Web";
            btn_reload.UseVisualStyleBackColor = true;
            btn_reload.Click += btn_reload_Click;
            // 
            // btn_load
            // 
            btn_load.Location = new Point(872, 12);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(112, 34);
            btn_load.TabIndex = 3;
            btn_load.Text = "Load Web";
            btn_load.UseVisualStyleBackColor = true;
            btn_load.Click += btn_load_Click;
            // 
            // btn_downfile
            // 
            btn_downfile.Location = new Point(687, 66);
            btn_downfile.Name = "btn_downfile";
            btn_downfile.Size = new Size(145, 34);
            btn_downfile.TabIndex = 4;
            btn_downfile.Text = "Download File";
            btn_downfile.UseVisualStyleBackColor = true;
            btn_downfile.Click += btn_downfile_Click;
            // 
            // btn_downresources
            // 
            btn_downresources.Location = new Point(456, 66);
            btn_downresources.Name = "btn_downresources";
            btn_downresources.Size = new Size(201, 34);
            btn_downresources.TabIndex = 5;
            btn_downresources.Text = "Download Resources";
            btn_downresources.UseVisualStyleBackColor = true;
            btn_downresources.Click += btn_downresources_Click;
            // 
            // Cau3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 494);
            Controls.Add(btn_downresources);
            Controls.Add(btn_downfile);
            Controls.Add(btn_load);
            Controls.Add(btn_reload);
            Controls.Add(tb_url);
            Controls.Add(wbvw2_shweb);
            Name = "Cau3";
            Text = "Câu 3";
            ((System.ComponentModel.ISupportInitialize)wbvw2_shweb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wbvw2_shweb;
        private TextBox tb_url;
        private Button btn_reload;
        private Button btn_load;
        private Button btn_downfile;
        private Button btn_downresources;
    }
}
