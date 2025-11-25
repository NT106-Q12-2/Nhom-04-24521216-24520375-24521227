namespace Cau4
{
    partial class MovieNowShowing
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
            MovieShowing = new ListView();
            SuspendLayout();
            // 
            // MovieShowing
            // 
            MovieShowing.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MovieShowing.Location = new Point(0, 0);
            MovieShowing.Name = "MovieShowing";
            MovieShowing.Size = new Size(558, 638);
            MovieShowing.TabIndex = 0;
            MovieShowing.UseCompatibleStateImageBehavior = false;
            // 
            // MovieNowShowing
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 638);
            Controls.Add(MovieShowing);
            Name = "MovieNowShowing";
            Text = "Now Showing";
            MouseClick += MovieNowShowing_MouseClick;
            ResumeLayout(false);
        }

        #endregion

        private ListView MovieShowing;
    }
}