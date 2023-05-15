namespace PHANHE2_PRJ
{
    partial class MH_NHANVIEN_CAPNHATNGAYSINHNV
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
            this.label2 = new System.Windows.Forms.Label();
            this.P_NGAYSINH = new System.Windows.Forms.TextBox();
            this.btn_CAPNHAT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "CẬP NHẬT NGÀY SINH ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "NGÀY SINH MỚI";
            // 
            // P_NGAYSINH
            // 
            this.P_NGAYSINH.Location = new System.Drawing.Point(183, 157);
            this.P_NGAYSINH.Margin = new System.Windows.Forms.Padding(2);
            this.P_NGAYSINH.Name = "P_NGAYSINH";
            this.P_NGAYSINH.Size = new System.Drawing.Size(322, 20);
            this.P_NGAYSINH.TabIndex = 9;
            // 
            // btn_CAPNHAT
            // 
            this.btn_CAPNHAT.BackColor = System.Drawing.Color.Cyan;
            this.btn_CAPNHAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CAPNHAT.Location = new System.Drawing.Point(367, 227);
            this.btn_CAPNHAT.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CAPNHAT.Name = "btn_CAPNHAT";
            this.btn_CAPNHAT.Size = new System.Drawing.Size(136, 47);
            this.btn_CAPNHAT.TabIndex = 12;
            this.btn_CAPNHAT.Text = "CẬP NHẬT";
            this.btn_CAPNHAT.UseVisualStyleBackColor = false;
            this.btn_CAPNHAT.Click += new System.EventHandler(this.btn_CAPNHAT_Click);
            // 
            // MH_NHANVIEN_CAPNHATNGAYSINHNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.btn_CAPNHAT);
            this.Controls.Add(this.P_NGAYSINH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(600, 350);
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "MH_NHANVIEN_CAPNHATNGAYSINHNV";
            this.Text = "MH_NHANVIEN_CAPNHATNGAYSINHNV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox P_NGAYSINH;
        private System.Windows.Forms.Button btn_CAPNHAT;
    }
}