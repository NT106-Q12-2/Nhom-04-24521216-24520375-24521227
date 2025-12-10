namespace NT106_Test
{
    partial class Server
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
            this.btn_startserver = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Table = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_tableID = new System.Windows.Forms.TextBox();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.btn_charge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_startserver
            // 
            this.btn_startserver.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startserver.Location = new System.Drawing.Point(75, 46);
            this.btn_startserver.Name = "btn_startserver";
            this.btn_startserver.Size = new System.Drawing.Size(334, 89);
            this.btn_startserver.TabIndex = 0;
            this.btn_startserver.Text = "Start server";
            this.btn_startserver.UseVisualStyleBackColor = true;
            this.btn_startserver.Click += new System.EventHandler(this.btn_startserver_Click);
            // 
            // label_status
            // 
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(445, 72);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(763, 50);
            this.label_status.TabIndex = 1;
            this.label_status.Text = "Status ...";
            this.label_status.Click += new System.EventHandler(this.label_status_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Table,
            this.Name,
            this.SoLuong,
            this.Total});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(83, 177);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(953, 546);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Table
            // 
            this.Table.Text = "Table";
            this.Table.Width = 150;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 300;
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "Qty";
            this.SoLuong.Width = 200;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.Width = 300;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(83, 762);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(953, 196);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1131, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter table";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1131, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "Amount";
            // 
            // textBox_tableID
            // 
            this.textBox_tableID.Location = new System.Drawing.Point(1137, 250);
            this.textBox_tableID.Name = "textBox_tableID";
            this.textBox_tableID.Size = new System.Drawing.Size(211, 26);
            this.textBox_tableID.TabIndex = 6;
            this.textBox_tableID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(1138, 528);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(211, 26);
            this.textBox_amount.TabIndex = 7;
            // 
            // btn_charge
            // 
            this.btn_charge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_charge.Location = new System.Drawing.Point(1137, 323);
            this.btn_charge.Name = "btn_charge";
            this.btn_charge.Size = new System.Drawing.Size(334, 89);
            this.btn_charge.TabIndex = 8;
            this.btn_charge.Text = "Charge";
            this.btn_charge.UseVisualStyleBackColor = true;
            this.btn_charge.Click += new System.EventHandler(this.btn_charge_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 987);
            this.Controls.Add(this.btn_charge);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.textBox_tableID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.btn_startserver);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_startserver;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Table;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader SoLuong;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_tableID;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.Button btn_charge;
    }
}