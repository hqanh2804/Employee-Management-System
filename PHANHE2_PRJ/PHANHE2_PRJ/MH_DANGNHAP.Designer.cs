namespace PHANHE2_PRJ
{
    partial class MH_DANGNHAP
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
            this.bt_DANGNHAP = new System.Windows.Forms.Button();
            this.P_PASSWORD = new System.Windows.Forms.TextBox();
            this.P_USERNAME = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_DANGNHAP
            // 
            this.bt_DANGNHAP.Location = new System.Drawing.Point(320, 203);
            this.bt_DANGNHAP.Margin = new System.Windows.Forms.Padding(2);
            this.bt_DANGNHAP.Name = "bt_DANGNHAP";
            this.bt_DANGNHAP.Size = new System.Drawing.Size(91, 27);
            this.bt_DANGNHAP.TabIndex = 11;
            this.bt_DANGNHAP.Text = "ĐĂNG NHẬP";
            this.bt_DANGNHAP.UseVisualStyleBackColor = true;
            this.bt_DANGNHAP.Click += new System.EventHandler(this.bt_DANGNHAP_Click);
            // 
            // P_PASSWORD
            // 
            this.P_PASSWORD.Location = new System.Drawing.Point(158, 144);
            this.P_PASSWORD.Margin = new System.Windows.Forms.Padding(2);
            this.P_PASSWORD.Name = "P_PASSWORD";
            this.P_PASSWORD.Size = new System.Drawing.Size(253, 20);
            this.P_PASSWORD.TabIndex = 10;
            this.P_PASSWORD.UseSystemPasswordChar = true;
            // 
            // P_USERNAME
            // 
            this.P_USERNAME.Location = new System.Drawing.Point(158, 97);
            this.P_USERNAME.Margin = new System.Windows.Forms.Padding(2);
            this.P_USERNAME.Name = "P_USERNAME";
            this.P_USERNAME.Size = new System.Drawing.Size(253, 20);
            this.P_USERNAME.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "PASSWORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "USERNAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "THÔNG TIN ĐĂNG NHẬP";
            // 
            // MH_DANGNHAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 261);
            this.Controls.Add(this.bt_DANGNHAP);
            this.Controls.Add(this.P_PASSWORD);
            this.Controls.Add(this.P_USERNAME);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(540, 300);
            this.MinimumSize = new System.Drawing.Size(540, 300);
            this.Name = "MH_DANGNHAP";
            this.Text = "MH_DANGNHAP";
            this.Load += new System.EventHandler(this.MH_DANGNHAP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_DANGNHAP;
        private System.Windows.Forms.TextBox P_PASSWORD;
        private System.Windows.Forms.TextBox P_USERNAME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}