﻿namespace PHANHE2_PRJ
{
    partial class MH_TAICHINH_CAPNHATPHUCAPNV
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_PhuCap = new System.Windows.Forms.TextBox();
            this.btnPhuCap_Update = new System.Windows.Forms.Button();
            this.txt_MANV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "CẬP NHẬT PHỤ CẤP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "PHỤ CẤP MỚI";
            // 
            // txt_PhuCap
            // 
            this.txt_PhuCap.Location = new System.Drawing.Point(174, 154);
            this.txt_PhuCap.Margin = new System.Windows.Forms.Padding(2);
            this.txt_PhuCap.Name = "txt_PhuCap";
            this.txt_PhuCap.Size = new System.Drawing.Size(322, 20);
            this.txt_PhuCap.TabIndex = 11;
            // 
            // btnPhuCap_Update
            // 
            this.btnPhuCap_Update.BackColor = System.Drawing.Color.Cyan;
            this.btnPhuCap_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhuCap_Update.Location = new System.Drawing.Point(361, 207);
            this.btnPhuCap_Update.Margin = new System.Windows.Forms.Padding(2);
            this.btnPhuCap_Update.Name = "btnPhuCap_Update";
            this.btnPhuCap_Update.Size = new System.Drawing.Size(136, 47);
            this.btnPhuCap_Update.TabIndex = 13;
            this.btnPhuCap_Update.Text = "CẬP NHẬT";
            this.btnPhuCap_Update.UseVisualStyleBackColor = false;
            this.btnPhuCap_Update.Click += new System.EventHandler(this.btnPhuCap_Update_Click);
            // 
            // txt_MANV
            // 
            this.txt_MANV.Location = new System.Drawing.Point(174, 105);
            this.txt_MANV.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MANV.Name = "txt_MANV";
            this.txt_MANV.Size = new System.Drawing.Size(322, 20);
            this.txt_MANV.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "MÃ NHÂN VIÊN";
            // 
            // MH_TAICHINH_CAPNHATPHUCAPNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 271);
            this.Controls.Add(this.txt_MANV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPhuCap_Update);
            this.Controls.Add(this.txt_PhuCap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(555, 310);
            this.MinimumSize = new System.Drawing.Size(555, 310);
            this.Name = "MH_TAICHINH_CAPNHATPHUCAPNV";
            this.Text = "MH_TAICHINH_CAPNHATPHUCAPNV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_PhuCap;
        private System.Windows.Forms.Button btnPhuCap_Update;
        private System.Windows.Forms.TextBox txt_MANV;
        private System.Windows.Forms.Label label2;
    }
}