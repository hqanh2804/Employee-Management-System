namespace PHANHE1_PRJ
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.P_USERNAME = new System.Windows.Forms.TextBox();
            this.P_PASSWORD = new System.Windows.Forms.TextBox();
            this.bt_DANGNHAP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "THONG TIN DANG NHAP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "USERNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD";
            // 
            // P_USERNAME
            // 
            this.P_USERNAME.Location = new System.Drawing.Point(254, 132);
            this.P_USERNAME.Name = "P_USERNAME";
            this.P_USERNAME.Size = new System.Drawing.Size(377, 26);
            this.P_USERNAME.TabIndex = 3;
            this.P_USERNAME.TextChanged += new System.EventHandler(this.P_USERNAME_TextChanged);
            // 
            // P_PASSWORD
            // 
            this.P_PASSWORD.Location = new System.Drawing.Point(254, 205);
            this.P_PASSWORD.Name = "P_PASSWORD";
            this.P_PASSWORD.Size = new System.Drawing.Size(377, 26);
            this.P_PASSWORD.TabIndex = 4;
            this.P_PASSWORD.UseSystemPasswordChar = true;
            // 
            // bt_DANGNHAP
            // 
            this.bt_DANGNHAP.Location = new System.Drawing.Point(494, 271);
            this.bt_DANGNHAP.Name = "bt_DANGNHAP";
            this.bt_DANGNHAP.Size = new System.Drawing.Size(137, 42);
            this.bt_DANGNHAP.TabIndex = 5;
            this.bt_DANGNHAP.Text = "LOGIN";
            this.bt_DANGNHAP.UseVisualStyleBackColor = true;
            this.bt_DANGNHAP.Click += new System.EventHandler(this.bt_DANGNHAP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_DANGNHAP);
            this.Controls.Add(this.P_PASSWORD);
            this.Controls.Add(this.P_USERNAME);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox P_USERNAME;
        private System.Windows.Forms.TextBox P_PASSWORD;
        private System.Windows.Forms.Button bt_DANGNHAP;
    }
}

