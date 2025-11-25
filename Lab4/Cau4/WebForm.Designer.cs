namespace Cau4
{
    partial class WebMovie
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
            WebViewMovie = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)WebViewMovie).BeginInit();
            SuspendLayout();
            // 
            // WebViewMovie
            // 
            WebViewMovie.AllowExternalDrop = true;
            WebViewMovie.CreationProperties = null;
            WebViewMovie.DefaultBackgroundColor = Color.White;
            WebViewMovie.Dock = DockStyle.Fill;
            WebViewMovie.Location = new Point(0, 0);
            WebViewMovie.Name = "WebViewMovie";
            WebViewMovie.Size = new Size(1081, 474);
            WebViewMovie.TabIndex = 0;
            WebViewMovie.ZoomFactor = 1D;
            // 
            // WebMovie
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 474);
            Controls.Add(WebViewMovie);
            Name = "WebMovie";
            Text = "Url";
            ((System.ComponentModel.ISupportInitialize)WebViewMovie).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 WebViewMovie;
    }
}