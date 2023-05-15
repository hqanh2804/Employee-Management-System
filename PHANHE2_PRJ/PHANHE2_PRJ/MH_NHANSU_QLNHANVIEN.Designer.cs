namespace PHANHE2_PRJ
{
    partial class MH_NHANSU_QLNHANVIEN
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
            this.dgv_V_NHANVIEN_NHANSU = new System.Windows.Forms.DataGridView();
            this.btnQLNV_Update_Date = new System.Windows.Forms.Button();
            this.btnQLNV_Update_Diachi = new System.Windows.Forms.Button();
            this.btnQLNV_Insert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQLNV_Update_SDT = new System.Windows.Forms.Button();
            this.btnQLNV_Menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_V_NHANVIEN_NHANSU)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.label1.TabIndex = 9;
            this.label1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // dgv_V_NHANVIEN_NHANSU
            // 
            this.dgv_V_NHANVIEN_NHANSU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_V_NHANVIEN_NHANSU.Location = new System.Drawing.Point(12, 29);
            this.dgv_V_NHANVIEN_NHANSU.Name = "dgv_V_NHANVIEN_NHANSU";
            this.dgv_V_NHANVIEN_NHANSU.Size = new System.Drawing.Size(740, 208);
            this.dgv_V_NHANVIEN_NHANSU.TabIndex = 10;
            // 
            // btnQLNV_Update_Date
            // 
            this.btnQLNV_Update_Date.Location = new System.Drawing.Point(223, 32);
            this.btnQLNV_Update_Date.Name = "btnQLNV_Update_Date";
            this.btnQLNV_Update_Date.Size = new System.Drawing.Size(168, 50);
            this.btnQLNV_Update_Date.TabIndex = 2;
            this.btnQLNV_Update_Date.Text = "CẬP NHẬT NGÀY SINH";
            this.btnQLNV_Update_Date.UseVisualStyleBackColor = true;
            this.btnQLNV_Update_Date.Click += new System.EventHandler(this.btnQLNV_Update_Date_Click);
            // 
            // btnQLNV_Update_Diachi
            // 
            this.btnQLNV_Update_Diachi.Location = new System.Drawing.Point(223, 99);
            this.btnQLNV_Update_Diachi.Name = "btnQLNV_Update_Diachi";
            this.btnQLNV_Update_Diachi.Size = new System.Drawing.Size(168, 50);
            this.btnQLNV_Update_Diachi.TabIndex = 1;
            this.btnQLNV_Update_Diachi.Text = "CẬP NHẬT ĐỊA CHỈ";
            this.btnQLNV_Update_Diachi.UseVisualStyleBackColor = true;
            this.btnQLNV_Update_Diachi.Click += new System.EventHandler(this.btnQLNV_Update_Diachi_Click);
            // 
            // btnQLNV_Insert
            // 
            this.btnQLNV_Insert.Location = new System.Drawing.Point(28, 32);
            this.btnQLNV_Insert.Name = "btnQLNV_Insert";
            this.btnQLNV_Insert.Size = new System.Drawing.Size(151, 50);
            this.btnQLNV_Insert.TabIndex = 0;
            this.btnQLNV_Insert.Text = "THÊM NHÂN VIÊN";
            this.btnQLNV_Insert.UseVisualStyleBackColor = true;
            this.btnQLNV_Insert.Click += new System.EventHandler(this.btnQLNV_Insert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnQLNV_Update_SDT);
            this.groupBox1.Controls.Add(this.btnQLNV_Update_Date);
            this.groupBox1.Controls.Add(this.btnQLNV_Update_Diachi);
            this.groupBox1.Controls.Add(this.btnQLNV_Insert);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 165);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các chức năng QLNV của vai trò Nhân sự";
            // 
            // btnQLNV_Update_SDT
            // 
            this.btnQLNV_Update_SDT.Location = new System.Drawing.Point(28, 99);
            this.btnQLNV_Update_SDT.Name = "btnQLNV_Update_SDT";
            this.btnQLNV_Update_SDT.Size = new System.Drawing.Size(151, 50);
            this.btnQLNV_Update_SDT.TabIndex = 3;
            this.btnQLNV_Update_SDT.Text = "CẬP NHẬT SĐT";
            this.btnQLNV_Update_SDT.UseVisualStyleBackColor = true;
            this.btnQLNV_Update_SDT.Click += new System.EventHandler(this.btnQLNV_Update_SDT_Click);
            // 
            // btnQLNV_Menu
            // 
            this.btnQLNV_Menu.BackColor = System.Drawing.Color.Cyan;
            this.btnQLNV_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNV_Menu.Location = new System.Drawing.Point(676, 384);
            this.btnQLNV_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.btnQLNV_Menu.Name = "btnQLNV_Menu";
            this.btnQLNV_Menu.Size = new System.Drawing.Size(76, 45);
            this.btnQLNV_Menu.TabIndex = 12;
            this.btnQLNV_Menu.Text = "MENU";
            this.btnQLNV_Menu.UseVisualStyleBackColor = false;
            this.btnQLNV_Menu.Click += new System.EventHandler(this.btnQLNV_Menu_Click);
            // 
            // MH_NHANSU_QLNHANVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 441);
            this.Controls.Add(this.btnQLNV_Menu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_V_NHANVIEN_NHANSU);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(780, 480);
            this.MinimumSize = new System.Drawing.Size(780, 480);
            this.Name = "MH_NHANSU_QLNHANVIEN";
            this.Text = "MH_NHANSU_QLNHANVIEN";
            this.Load += new System.EventHandler(this.MH_QLNHANVIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_V_NHANVIEN_NHANSU)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_V_NHANVIEN_NHANSU;
        private System.Windows.Forms.Button btnQLNV_Update_Date;
        private System.Windows.Forms.Button btnQLNV_Update_Diachi;
        private System.Windows.Forms.Button btnQLNV_Insert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQLNV_Update_SDT;
        private System.Windows.Forms.Button btnQLNV_Menu;
    }
}