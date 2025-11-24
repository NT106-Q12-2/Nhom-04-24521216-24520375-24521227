namespace Cau7
{
    partial class MonAn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_ten = new System.Windows.Forms.Label();
            this.label_gia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_contributor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 304);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_ten
            // 
            this.label_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ten.Location = new System.Drawing.Point(464, 26);
            this.label_ten.Name = "label_ten";
            this.label_ten.Size = new System.Drawing.Size(456, 47);
            this.label_ten.TabIndex = 1;
            this.label_ten.Text = "label1";
            // 
            // label_gia
            // 
            this.label_gia.AutoSize = true;
            this.label_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gia.Location = new System.Drawing.Point(369, 73);
            this.label_gia.Name = "label_gia";
            this.label_gia.Size = new System.Drawing.Size(94, 32);
            this.label_gia.TabIndex = 2;
            this.label_gia.Text = "Price: ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(519, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "label2";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address: ";
            // 
            // label_address
            // 
            this.label_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address.Location = new System.Drawing.Point(519, 130);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(518, 44);
            this.label_address.TabIndex = 5;
            this.label_address.Text = "label2";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(367, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 45);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contributor: ";
            // 
            // label_contributor
            // 
            this.label_contributor.AutoSize = true;
            this.label_contributor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contributor.ForeColor = System.Drawing.Color.SpringGreen;
            this.label_contributor.Location = new System.Drawing.Point(555, 192);
            this.label_contributor.Name = "label_contributor";
            this.label_contributor.Size = new System.Drawing.Size(92, 32);
            this.label_contributor.TabIndex = 7;
            this.label_contributor.Text = "label2";
            // 
            // MonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label_contributor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_gia);
            this.Controls.Add(this.label_ten);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MonAn";
            this.Size = new System.Drawing.Size(1064, 302);
            this.Load += new System.EventHandler(this.MonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_ten;
        private System.Windows.Forms.Label label_gia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_contributor;
    }
}
