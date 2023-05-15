namespace PHANHE2_PRJ
{
    partial class MH_TAICHINH
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
            this.dgv_V_NHANVIEN_TAICHINH = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTaiChinh_PhuCap = new System.Windows.Forms.Button();
            this.btnTaiChinh_Luong = new System.Windows.Forms.Button();
            this.btnTaiChinh_NV = new System.Windows.Forms.Button();
            this.btnTaiChinh_Thoat = new System.Windows.Forms.Button();
            this.dgv_V_PHANCONG_TAICHINH = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_V_NHANVIEN_TAICHINH)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_V_PHANCONG_TAICHINH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN NHÂN VIÊN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv_V_NHANVIEN_TAICHINH
            // 
            this.dgv_V_NHANVIEN_TAICHINH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_V_NHANVIEN_TAICHINH.Location = new System.Drawing.Point(12, 29);
            this.dgv_V_NHANVIEN_TAICHINH.Name = "dgv_V_NHANVIEN_TAICHINH";
            this.dgv_V_NHANVIEN_TAICHINH.Size = new System.Drawing.Size(850, 208);
            this.dgv_V_NHANVIEN_TAICHINH.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnTaiChinh_PhuCap);
            this.groupBox1.Controls.Add(this.btnTaiChinh_Luong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(359, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 97);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các chức năng của vai trò Tài chính";
            // 
            // btnTaiChinh_PhuCap
            // 
            this.btnTaiChinh_PhuCap.Location = new System.Drawing.Point(255, 32);
            this.btnTaiChinh_PhuCap.Name = "btnTaiChinh_PhuCap";
            this.btnTaiChinh_PhuCap.Size = new System.Drawing.Size(242, 50);
            this.btnTaiChinh_PhuCap.TabIndex = 1;
            this.btnTaiChinh_PhuCap.Text = "CẬP NHẬT PHỤ CẤP NHÂN VIÊN";
            this.btnTaiChinh_PhuCap.UseVisualStyleBackColor = true;
            this.btnTaiChinh_PhuCap.Click += new System.EventHandler(this.btnTaiChinh_PhuCap_Click);
            // 
            // btnTaiChinh_Luong
            // 
            this.btnTaiChinh_Luong.Location = new System.Drawing.Point(7, 32);
            this.btnTaiChinh_Luong.Name = "btnTaiChinh_Luong";
            this.btnTaiChinh_Luong.Size = new System.Drawing.Size(242, 50);
            this.btnTaiChinh_Luong.TabIndex = 0;
            this.btnTaiChinh_Luong.Text = "CẬP NHẬT LƯƠNG NHÂN VIÊN";
            this.btnTaiChinh_Luong.UseVisualStyleBackColor = true;
            this.btnTaiChinh_Luong.Click += new System.EventHandler(this.btnTaiChinh_Luong_Click);
            // 
            // btnTaiChinh_NV
            // 
            this.btnTaiChinh_NV.BackColor = System.Drawing.Color.Cyan;
            this.btnTaiChinh_NV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiChinh_NV.Location = new System.Drawing.Point(514, 402);
            this.btnTaiChinh_NV.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaiChinh_NV.Name = "btnTaiChinh_NV";
            this.btnTaiChinh_NV.Size = new System.Drawing.Size(214, 45);
            this.btnTaiChinh_NV.TabIndex = 6;
            this.btnTaiChinh_NV.Text = "VỀ MÀN HÌNH NHÂN VIÊN";
            this.btnTaiChinh_NV.UseVisualStyleBackColor = false;
            this.btnTaiChinh_NV.Click += new System.EventHandler(this.btnTaiChinh_NV_Click);
            // 
            // btnTaiChinh_Thoat
            // 
            this.btnTaiChinh_Thoat.Location = new System.Drawing.Point(754, 489);
            this.btnTaiChinh_Thoat.Name = "btnTaiChinh_Thoat";
            this.btnTaiChinh_Thoat.Size = new System.Drawing.Size(80, 30);
            this.btnTaiChinh_Thoat.TabIndex = 7;
            this.btnTaiChinh_Thoat.Text = "Thoát";
            this.btnTaiChinh_Thoat.UseVisualStyleBackColor = true;
            this.btnTaiChinh_Thoat.Click += new System.EventHandler(this.btnTaiChinh_Thoat_Click);
            // 
            // dgv_V_PHANCONG_TAICHINH
            // 
            this.dgv_V_PHANCONG_TAICHINH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_V_PHANCONG_TAICHINH.Location = new System.Drawing.Point(12, 290);
            this.dgv_V_PHANCONG_TAICHINH.Name = "dgv_V_PHANCONG_TAICHINH";
            this.dgv_V_PHANCONG_TAICHINH.Size = new System.Drawing.Size(341, 229);
            this.dgv_V_PHANCONG_TAICHINH.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "THÔNG TIN PHÂN CÔNG";
            // 
            // MH_TAICHINH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 531);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_V_PHANCONG_TAICHINH);
            this.Controls.Add(this.btnTaiChinh_Thoat);
            this.Controls.Add(this.btnTaiChinh_NV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_V_NHANVIEN_TAICHINH);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(890, 570);
            this.MinimumSize = new System.Drawing.Size(890, 570);
            this.Name = "MH_TAICHINH";
            this.Text = "MH_TAICHINH";
            this.Load += new System.EventHandler(this.MH_TAICHINH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_V_NHANVIEN_TAICHINH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_V_PHANCONG_TAICHINH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_V_NHANVIEN_TAICHINH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTaiChinh_PhuCap;
        private System.Windows.Forms.Button btnTaiChinh_Luong;
        private System.Windows.Forms.Button btnTaiChinh_NV;
        private System.Windows.Forms.Button btnTaiChinh_Thoat;
        private System.Windows.Forms.DataGridView dgv_V_PHANCONG_TAICHINH;
        private System.Windows.Forms.Label label2;
    }
}