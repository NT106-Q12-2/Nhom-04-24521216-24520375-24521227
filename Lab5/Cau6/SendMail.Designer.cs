namespace Cau6
{
    partial class SendMail
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
            btn_browse = new Button();
            label1 = new Label();
            tb_from = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tb_subject = new TextBox();
            tb_to = new TextBox();
            tb_name = new TextBox();
            btn_send = new Button();
            tb_attachment = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cb_html = new CheckBox();
            tb_body = new TextBox();
            SuspendLayout();
            // 
            // btn_browse
            // 
            btn_browse.Location = new Point(547, 403);
            btn_browse.Name = "btn_browse";
            btn_browse.Size = new Size(94, 29);
            btn_browse.TabIndex = 0;
            btn_browse.Text = "Browse";
            btn_browse.UseVisualStyleBackColor = true;
            btn_browse.Click += btn_browse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 19);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 1;
            label1.Text = "From";
            // 
            // tb_from
            // 
            tb_from.Location = new Point(140, 12);
            tb_from.Name = "tb_from";
            tb_from.Size = new Size(501, 27);
            tb_from.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 52);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 84);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 4;
            label3.Text = "To";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 124);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 5;
            label4.Text = "Subject";
            // 
            // tb_subject
            // 
            tb_subject.Location = new Point(140, 117);
            tb_subject.Name = "tb_subject";
            tb_subject.Size = new Size(501, 27);
            tb_subject.TabIndex = 6;
            // 
            // tb_to
            // 
            tb_to.Location = new Point(140, 84);
            tb_to.Name = "tb_to";
            tb_to.Size = new Size(501, 27);
            tb_to.TabIndex = 7;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(140, 45);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(501, 27);
            tb_name.TabIndex = 8;
            // 
            // btn_send
            // 
            btn_send.Location = new Point(547, 438);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(94, 29);
            btn_send.TabIndex = 9;
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // tb_attachment
            // 
            tb_attachment.Location = new Point(128, 403);
            tb_attachment.Name = "tb_attachment";
            tb_attachment.Size = new Size(413, 27);
            tb_attachment.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 403);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 11;
            label5.Text = "Attachment";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 163);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 12;
            label6.Text = "Body";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(164, 163);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 13;
            label7.Text = "HTML";
            // 
            // cb_html
            // 
            cb_html.AutoSize = true;
            cb_html.Location = new Point(140, 166);
            cb_html.Name = "cb_html";
            cb_html.Size = new Size(18, 17);
            cb_html.TabIndex = 15;
            cb_html.UseVisualStyleBackColor = true;
            // 
            // tb_body
            // 
            tb_body.Location = new Point(128, 189);
            tb_body.Multiline = true;
            tb_body.Name = "tb_body";
            tb_body.Size = new Size(513, 208);
            tb_body.TabIndex = 16;
            // 
            // SendMail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 467);
            Controls.Add(tb_body);
            Controls.Add(cb_html);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tb_attachment);
            Controls.Add(btn_send);
            Controls.Add(tb_name);
            Controls.Add(tb_to);
            Controls.Add(tb_subject);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_from);
            Controls.Add(label1);
            Controls.Add(btn_browse);
            Margin = new Padding(2);
            Name = "SendMail";
            Text = "SendMail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_browse;
        private Label label1;
        private TextBox tb_from;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_subject;
        private TextBox tb_to;
        private TextBox tb_name;
        private Button btn_send;
        private TextBox tb_attachment;
        private Label label5;
        private Label label6;
        private Label label7;
        private CheckBox cb_html;
        private TextBox tb_body;
    }
}