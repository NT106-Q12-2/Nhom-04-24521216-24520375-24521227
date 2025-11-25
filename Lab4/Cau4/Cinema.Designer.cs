namespace Cau4
{
    partial class Cinema
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
            cbb_cinemaUrl = new ComboBox();
            btn_downdata = new Button();
            label1 = new Label();
            progressBarDD = new ProgressBar();
            btn_mvnowshwing = new Button();
            tb_name = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tb_phone = new TextBox();
            cbb_movieSelection = new ComboBox();
            label4 = new Label();
            btn_bookticket = new Button();
            SuspendLayout();
            // 
            // cbb_cinemaUrl
            // 
            cbb_cinemaUrl.FormattingEnabled = true;
            cbb_cinemaUrl.Location = new Point(231, 28);
            cbb_cinemaUrl.Name = "cbb_cinemaUrl";
            cbb_cinemaUrl.Size = new Size(500, 33);
            cbb_cinemaUrl.TabIndex = 0;
            // 
            // btn_downdata
            // 
            btn_downdata.Location = new Point(754, 28);
            btn_downdata.Name = "btn_downdata";
            btn_downdata.Size = new Size(194, 34);
            btn_downdata.TabIndex = 1;
            btn_downdata.Text = "Download Data";
            btn_downdata.UseVisualStyleBackColor = true;
            btn_downdata.Click += btn_downdata_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 31);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 2;
            label1.Text = "Chọn Web Cinema";
            // 
            // progressBarDD
            // 
            progressBarDD.Location = new Point(231, 88);
            progressBarDD.Name = "progressBarDD";
            progressBarDD.Size = new Size(500, 23);
            progressBarDD.TabIndex = 3;
            // 
            // btn_mvnowshwing
            // 
            btn_mvnowshwing.Location = new Point(754, 88);
            btn_mvnowshwing.Name = "btn_mvnowshwing";
            btn_mvnowshwing.Size = new Size(194, 34);
            btn_mvnowshwing.TabIndex = 4;
            btn_mvnowshwing.Text = "Movie Now Showing";
            btn_mvnowshwing.UseVisualStyleBackColor = true;
            btn_mvnowshwing.Click += btn_mvnowshwing_Click;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(231, 148);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(500, 31);
            tb_name.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 148);
            label2.Name = "label2";
            label2.Size = new Size(162, 25);
            label2.TabIndex = 6;
            label2.Text = "Họ tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 211);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 7;
            label3.Text = "SĐT";
            // 
            // tb_phone
            // 
            tb_phone.Location = new Point(231, 211);
            tb_phone.Name = "tb_phone";
            tb_phone.Size = new Size(500, 31);
            tb_phone.TabIndex = 8;
            // 
            // cbb_movieSelection
            // 
            cbb_movieSelection.FormattingEnabled = true;
            cbb_movieSelection.Location = new Point(231, 273);
            cbb_movieSelection.Name = "cbb_movieSelection";
            cbb_movieSelection.Size = new Size(500, 33);
            cbb_movieSelection.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 273);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 10;
            label4.Text = "Phim";
            // 
            // btn_bookticket
            // 
            btn_bookticket.Location = new Point(231, 341);
            btn_bookticket.Name = "btn_bookticket";
            btn_bookticket.Size = new Size(112, 34);
            btn_bookticket.TabIndex = 11;
            btn_bookticket.Text = "Order";
            btn_bookticket.UseVisualStyleBackColor = true;
            btn_bookticket.Click += btn_bookticket_Click;
            // 
            // Cinema
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 415);
            Controls.Add(btn_bookticket);
            Controls.Add(label4);
            Controls.Add(cbb_movieSelection);
            Controls.Add(tb_phone);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_name);
            Controls.Add(btn_mvnowshwing);
            Controls.Add(progressBarDD);
            Controls.Add(label1);
            Controls.Add(btn_downdata);
            Controls.Add(cbb_cinemaUrl);
            Name = "Cinema";
            Text = "CinemaDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbb_cinemaUrl;
        private Button btn_downdata;
        private Label label1;
        private ProgressBar progressBarDD;
        private Button btn_mvnowshwing;
        private TextBox tb_name;
        private Label label2;
        private Label label3;
        private TextBox tb_phone;
        private ComboBox cbb_movieSelection;
        private Label label4;
        private Button btn_bookticket;
    }
}
