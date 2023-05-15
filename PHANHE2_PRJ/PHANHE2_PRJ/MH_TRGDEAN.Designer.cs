namespace PHANHE2_PRJ
{
    partial class MH_TRGDEAN
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
            this.btnTDA_Thoat = new System.Windows.Forms.Button();
            this.btnTDA_NV = new System.Windows.Forms.Button();
            this.dgv_V_DEAN_TRUONGDEAN = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTDA_Update_PB = new System.Windows.Forms.Button();
            this.btnTDA_Insert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTDA_Update_Date = new System.Windows.Forms.Button();
            this.btnTDA_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_V_DEAN_TRUONGDEAN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTDA_Thoat
            // 
            this.btnTDA_Thoat.Location = new System.Drawing.Point(496, 387);
            this.btnTDA_Thoat.Name = "btnTDA_Thoat";
            this.btnTDA_Thoat.Size = new System.Drawing.Size(80, 30);
            this.btnTDA_Thoat.TabIndex = 12;
            this.btnTDA_Thoat.Text = "Thoát";
            this.btnTDA_Thoat.UseVisualStyleBackColor = true;
            this.btnTDA_Thoat.Click += new System.EventHandler(this.btnTDA_Thoat_Click);
            // 
            // btnTDA_NV
            // 
            this.btnTDA_NV.BackColor = System.Drawing.Color.Cyan;
            this.btnTDA_NV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTDA_NV.Location = new System.Drawing.Point(372, 294);
            this.btnTDA_NV.Margin = new System.Windows.Forms.Padding(2);
            this.btnTDA_NV.Name = "btnTDA_NV";
            this.btnTDA_NV.Size = new System.Drawing.Size(204, 45);
            this.btnTDA_NV.TabIndex = 11;
            this.btnTDA_NV.Text = "VỀ MÀN HÌNH NHÂN VIÊN";
            this.btnTDA_NV.UseVisualStyleBackColor = false;
            this.btnTDA_NV.Click += new System.EventHandler(this.btnTDA_NV_Click);
            // 
            // dgv_V_DEAN_TRUONGDEAN
            // 
            this.dgv_V_DEAN_TRUONGDEAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_V_DEAN_TRUONGDEAN.Location = new System.Drawing.Point(12, 28);
            this.dgv_V_DEAN_TRUONGDEAN.Name = "dgv_V_DEAN_TRUONGDEAN";
            this.dgv_V_DEAN_TRUONGDEAN.Size = new System.Drawing.Size(564, 208);
            this.dgv_V_DEAN_TRUONGDEAN.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "THÔNG TIN ĐỀ ÁN";
            // 
            // btnTDA_Update_PB
            // 
            this.btnTDA_Update_PB.Location = new System.Drawing.Point(170, 32);
            this.btnTDA_Update_PB.Name = "btnTDA_Update_PB";
            this.btnTDA_Update_PB.Size = new System.Drawing.Size(157, 50);
            this.btnTDA_Update_PB.TabIndex = 1;
            this.btnTDA_Update_PB.Text = "CẬP NHẬT PHÒNG BAN PHỤ TRÁCH";
            this.btnTDA_Update_PB.UseVisualStyleBackColor = true;
            this.btnTDA_Update_PB.Click += new System.EventHandler(this.btnTDA_Update_PB_Click);
            // 
            // btnTDA_Insert
            // 
            this.btnTDA_Insert.Location = new System.Drawing.Point(28, 32);
            this.btnTDA_Insert.Name = "btnTDA_Insert";
            this.btnTDA_Insert.Size = new System.Drawing.Size(108, 50);
            this.btnTDA_Insert.TabIndex = 0;
            this.btnTDA_Insert.Text = "THÊM ĐỀ ÁN";
            this.btnTDA_Insert.UseVisualStyleBackColor = true;
            this.btnTDA_Insert.Click += new System.EventHandler(this.btnTDA_Insert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnTDA_Update_Date);
            this.groupBox1.Controls.Add(this.btnTDA_Delete);
            this.groupBox1.Controls.Add(this.btnTDA_Update_PB);
            this.groupBox1.Controls.Add(this.btnTDA_Insert);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 166);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các chức năng của vai trò Trưởng đề án";
            // 
            // btnTDA_Update_Date
            // 
            this.btnTDA_Update_Date.Location = new System.Drawing.Point(170, 105);
            this.btnTDA_Update_Date.Name = "btnTDA_Update_Date";
            this.btnTDA_Update_Date.Size = new System.Drawing.Size(157, 50);
            this.btnTDA_Update_Date.TabIndex = 3;
            this.btnTDA_Update_Date.Text = "CẬP NHẬT NGÀY BẮT ĐẦU ĐỀ ÁN";
            this.btnTDA_Update_Date.UseVisualStyleBackColor = true;
            this.btnTDA_Update_Date.Click += new System.EventHandler(this.btnTDA_Update_Date_Click);
            // 
            // btnTDA_Delete
            // 
            this.btnTDA_Delete.Location = new System.Drawing.Point(28, 105);
            this.btnTDA_Delete.Name = "btnTDA_Delete";
            this.btnTDA_Delete.Size = new System.Drawing.Size(107, 50);
            this.btnTDA_Delete.TabIndex = 2;
            this.btnTDA_Delete.Text = "XOÁ ĐỀ ÁN";
            this.btnTDA_Delete.UseVisualStyleBackColor = true;
            this.btnTDA_Delete.Click += new System.EventHandler(this.btnTDA_Delete_Click);
            // 
            // MH_TRUONGDEAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 441);
            this.Controls.Add(this.btnTDA_Thoat);
            this.Controls.Add(this.btnTDA_NV);
            this.Controls.Add(this.dgv_V_DEAN_TRUONGDEAN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(605, 480);
            this.MinimumSize = new System.Drawing.Size(605, 480);
            this.Name = "MH_TRUONGDEAN";
            this.Text = "MH_TRUONGDEAN";
            this.Load += new System.EventHandler(this.MH_TRUONGDEAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_V_DEAN_TRUONGDEAN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTDA_Thoat;
        private System.Windows.Forms.Button btnTDA_NV;
        private System.Windows.Forms.DataGridView dgv_V_DEAN_TRUONGDEAN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTDA_Update_PB;
        private System.Windows.Forms.Button btnTDA_Insert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTDA_Delete;
        private System.Windows.Forms.Button btnTDA_Update_Date;
    }
}