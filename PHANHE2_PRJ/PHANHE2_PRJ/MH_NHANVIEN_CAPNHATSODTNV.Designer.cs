namespace PHANHE2_PRJ
{
    partial class MH_NHANVIEN_CAPNHATSODTNV
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
            this.btn_CAPNHAT = new System.Windows.Forms.Button();
            this.P_SODT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_CAPNHAT
            // 
            this.btn_CAPNHAT.BackColor = System.Drawing.Color.Cyan;
            this.btn_CAPNHAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CAPNHAT.Location = new System.Drawing.Point(413, 219);
            this.btn_CAPNHAT.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CAPNHAT.Name = "btn_CAPNHAT";
            this.btn_CAPNHAT.Size = new System.Drawing.Size(136, 47);
            this.btn_CAPNHAT.TabIndex = 18;
            this.btn_CAPNHAT.Text = "CẬP NHẬT";
            this.btn_CAPNHAT.UseVisualStyleBackColor = false;
            this.btn_CAPNHAT.Click += new System.EventHandler(this.btn_CAPNHAT_Click);
            // 
            // P_SODT
            // 
            this.P_SODT.Location = new System.Drawing.Point(229, 150);
            this.P_SODT.Margin = new System.Windows.Forms.Padding(2);
            this.P_SODT.Name = "P_SODT";
            this.P_SODT.Size = new System.Drawing.Size(322, 20);
            this.P_SODT.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "SỐ ĐIỆN THOẠI MỚI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "CẬP NHẬT SỐ ĐIỆN THOẠI";
            // 
            // MH_NHANVIEN_CAPNHATSODTNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 311);
            this.Controls.Add(this.btn_CAPNHAT);
            this.Controls.Add(this.P_SODT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(620, 350);
            this.MinimumSize = new System.Drawing.Size(620, 350);
            this.Name = "MH_NHANVIEN_CAPNHATSODTNV";
            this.Text = "MH_NHANVIEN_CAPNHATSODTNV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CAPNHAT;
        private System.Windows.Forms.TextBox P_SODT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}