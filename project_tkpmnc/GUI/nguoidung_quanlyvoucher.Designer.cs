﻿namespace project_tkpmnc.GUI
{
    partial class nguoidung_quanlyvoucher
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_save = new System.Windows.Forms.Button();
            this.comboBox_timkiem = new System.Windows.Forms.ComboBox();
            this.button_timkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_tailai = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_thongtinvoucher = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtinvoucher)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button_save);
            this.groupBox1.Controls.Add(this.comboBox_timkiem);
            this.groupBox1.Controls.Add(this.button_timkiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_tailai);
            this.groupBox1.Location = new System.Drawing.Point(7, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 73);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác";
            // 
            // button_save
            // 
            this.button_save.Enabled = false;
            this.button_save.Location = new System.Drawing.Point(97, 41);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(85, 23);
            this.button_save.TabIndex = 7;
            this.button_save.Text = "Ghi lại";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // comboBox_timkiem
            // 
            this.comboBox_timkiem.FormattingEnabled = true;
            this.comboBox_timkiem.Items.AddRange(new object[] {
            "Toàn bộ",
            "Chưa phát",
            "Đã phát",
            "Đã sử dụng"});
            this.comboBox_timkiem.Location = new System.Drawing.Point(61, 14);
            this.comboBox_timkiem.Name = "comboBox_timkiem";
            this.comboBox_timkiem.Size = new System.Drawing.Size(121, 21);
            this.comboBox_timkiem.TabIndex = 6;
            // 
            // button_timkiem
            // 
            this.button_timkiem.Location = new System.Drawing.Point(188, 14);
            this.button_timkiem.Name = "button_timkiem";
            this.button_timkiem.Size = new System.Drawing.Size(85, 23);
            this.button_timkiem.TabIndex = 4;
            this.button_timkiem.Text = "Tìm kiếm";
            this.button_timkiem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm";
            // 
            // button_tailai
            // 
            this.button_tailai.Location = new System.Drawing.Point(6, 41);
            this.button_tailai.Name = "button_tailai";
            this.button_tailai.Size = new System.Drawing.Size(85, 23);
            this.button_tailai.TabIndex = 1;
            this.button_tailai.Text = "Tải lại";
            this.button_tailai.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv_thongtinvoucher);
            this.groupBox2.Location = new System.Drawing.Point(7, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 254);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin voucher";
            // 
            // dgv_thongtinvoucher
            // 
            this.dgv_thongtinvoucher.AllowUserToAddRows = false;
            this.dgv_thongtinvoucher.AllowUserToDeleteRows = false;
            this.dgv_thongtinvoucher.AllowUserToOrderColumns = true;
            this.dgv_thongtinvoucher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_thongtinvoucher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_thongtinvoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongtinvoucher.Location = new System.Drawing.Point(8, 19);
            this.dgv_thongtinvoucher.MultiSelect = false;
            this.dgv_thongtinvoucher.Name = "dgv_thongtinvoucher";
            this.dgv_thongtinvoucher.ReadOnly = true;
            this.dgv_thongtinvoucher.Size = new System.Drawing.Size(476, 229);
            this.dgv_thongtinvoucher.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "Quản lý voucher";
            // 
            // nguoidung_quanlyvoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Name = "nguoidung_quanlyvoucher";
            this.Size = new System.Drawing.Size(506, 364);
            this.Load += new System.EventHandler(this.nguoidung_quanlyvoucher_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtinvoucher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.ComboBox comboBox_timkiem;
        private System.Windows.Forms.Button button_timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_tailai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_thongtinvoucher;
        private System.Windows.Forms.Label label6;
    }
}