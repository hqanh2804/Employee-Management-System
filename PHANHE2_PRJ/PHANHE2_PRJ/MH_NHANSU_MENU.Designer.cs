namespace PHANHE2_PRJ
{
    partial class MH_NHANSU_MENU
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
            this.btnMenu_QLPB = new System.Windows.Forms.Button();
            this.btnMenu_QLNV = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenu_QLPB
            // 
            this.btnMenu_QLPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu_QLPB.Location = new System.Drawing.Point(39, 209);
            this.btnMenu_QLPB.Name = "btnMenu_QLPB";
            this.btnMenu_QLPB.Size = new System.Drawing.Size(146, 74);
            this.btnMenu_QLPB.TabIndex = 4;
            this.btnMenu_QLPB.Text = "QUẢN LÝ PHÒNG BAN";
            this.btnMenu_QLPB.UseVisualStyleBackColor = true;
            this.btnMenu_QLPB.Click += new System.EventHandler(this.btnMenu_QLPB_Click);
            // 
            // btnMenu_QLNV
            // 
            this.btnMenu_QLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu_QLNV.Location = new System.Drawing.Point(39, 67);
            this.btnMenu_QLNV.Name = "btnMenu_QLNV";
            this.btnMenu_QLNV.Size = new System.Drawing.Size(146, 77);
            this.btnMenu_QLNV.TabIndex = 3;
            this.btnMenu_QLNV.Text = "QUẢN LÝ NHÂN VIÊN";
            this.btnMenu_QLNV.UseVisualStyleBackColor = true;
            this.btnMenu_QLNV.Click += new System.EventHandler(this.btnMenu_QLNV_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(102, 342);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(121, 38);
            this.btn_Logout.TabIndex = 8;
            this.btn_Logout.Text = "ĐĂNG XUẤT";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // MH_NHANSU_MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 391);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btnMenu_QLPB);
            this.Controls.Add(this.btnMenu_QLNV);
            this.MaximumSize = new System.Drawing.Size(250, 430);
            this.MinimumSize = new System.Drawing.Size(250, 430);
            this.Name = "MH_NHANSU_MENU";
            this.Text = "MH_NHANSU_MENU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenu_QLPB;
        private System.Windows.Forms.Button btnMenu_QLNV;
        private System.Windows.Forms.Button btn_Logout;
    }
}