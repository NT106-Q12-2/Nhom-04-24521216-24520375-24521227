namespace Cau1
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
            label1 = new Label();
            btn_send = new Button();
            rtb_result = new RichTextBox();
            tb_from = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tb_subject = new TextBox();
            tb_to = new TextBox();
            label6 = new Label();
            tb_password = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 113);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "From:";
            // 
            // btn_send
            // 
            btn_send.Location = new Point(12, 57);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(118, 80);
            btn_send.TabIndex = 1;
            btn_send.Text = "SEND";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // rtb_result
            // 
            rtb_result.Location = new Point(182, 237);
            rtb_result.Name = "rtb_result";
            rtb_result.Size = new Size(506, 201);
            rtb_result.TabIndex = 2;
            rtb_result.Text = "";
            // 
            // tb_from
            // 
            tb_from.Location = new Point(226, 110);
            tb_from.Name = "tb_from";
            tb_from.Size = new Size(318, 27);
            tb_from.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 153);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 4;
            label2.Text = "To:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 195);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 5;
            label3.Text = "Subject:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 251);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 6;
            label4.Text = "Body:";
            // 
            // tb_subject
            // 
            tb_subject.Location = new Point(193, 195);
            tb_subject.Name = "tb_subject";
            tb_subject.Size = new Size(506, 27);
            tb_subject.TabIndex = 7;
            // 
            // tb_to
            // 
            tb_to.Location = new Point(226, 153);
            tb_to.Name = "tb_to";
            tb_to.Size = new Size(318, 27);
            tb_to.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(488, 72);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 10;
            label6.Text = "Password:";
            // 
            // tb_password
            // 
            tb_password.Location = new Point(567, 72);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(221, 27);
            tb_password.TabIndex = 11;
            // 
            // Cau1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_password);
            Controls.Add(label6);
            Controls.Add(tb_to);
            Controls.Add(tb_subject);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_from);
            Controls.Add(rtb_result);
            Controls.Add(btn_send);
            Controls.Add(label1);
            Name = "Cau1";
            Text = "Câu 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_send;
        private RichTextBox rtb_result;
        private TextBox tb_from;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_subject;
        private TextBox tb_to;
        private Label label6;
        private TextBox tb_password;
    }
}
