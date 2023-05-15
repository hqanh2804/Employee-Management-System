namespace PHANHE2_PRJ
{
    partial class MH_TRUONGPHONG
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
            this.PHANCONGTRUONGPHONG = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.DANHSACHNHANVIENTRUONGPHONG = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_GIAODIEN_NV = new System.Windows.Forms.Button();
            this.INSERT = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PHANCONGTRUONGPHONG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DANHSACHNHANVIENTRUONGPHONG)).BeginInit();
            this.SuspendLayout();
            // 
            // PHANCONGTRUONGPHONG
            // 
            this.PHANCONGTRUONGPHONG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PHANCONGTRUONGPHONG.Location = new System.Drawing.Point(26, 384);
            this.PHANCONGTRUONGPHONG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PHANCONGTRUONGPHONG.Name = "PHANCONGTRUONGPHONG";
            this.PHANCONGTRUONGPHONG.RowHeadersWidth = 62;
            this.PHANCONGTRUONGPHONG.RowTemplate.Height = 28;
            this.PHANCONGTRUONGPHONG.Size = new System.Drawing.Size(492, 174);
            this.PHANCONGTRUONGPHONG.TabIndex = 8;
            this.PHANCONGTRUONGPHONG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PHANCONGTRUONGPHONG_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(822, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "THÔNG TIN PHÂN CÔNG CỦA CHÍNH MÌNH VÀ CÁC NHÂN VIÊN THUỘC PHÒNG CỦA MÌNH :";
            // 
            // DANHSACHNHANVIENTRUONGPHONG
            // 
            this.DANHSACHNHANVIENTRUONGPHONG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DANHSACHNHANVIENTRUONGPHONG.Location = new System.Drawing.Point(26, 83);
            this.DANHSACHNHANVIENTRUONGPHONG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DANHSACHNHANVIENTRUONGPHONG.Name = "DANHSACHNHANVIENTRUONGPHONG";
            this.DANHSACHNHANVIENTRUONGPHONG.RowHeadersWidth = 62;
            this.DANHSACHNHANVIENTRUONGPHONG.RowTemplate.Height = 28;
            this.DANHSACHNHANVIENTRUONGPHONG.Size = new System.Drawing.Size(895, 243);
            this.DANHSACHNHANVIENTRUONGPHONG.TabIndex = 6;
            this.DANHSACHNHANVIENTRUONGPHONG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DANHSACHNHANVIENTRUONGPHONG_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "DANH SÁCH CÁC NHÂN VIÊN THUỘC PHÒNG TRƯỞNG PHÒNG :";
            // 
            // btn_GIAODIEN_NV
            // 
            this.btn_GIAODIEN_NV.BackColor = System.Drawing.Color.Cyan;
            this.btn_GIAODIEN_NV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GIAODIEN_NV.Location = new System.Drawing.Point(650, 503);
            this.btn_GIAODIEN_NV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GIAODIEN_NV.Name = "btn_GIAODIEN_NV";
            this.btn_GIAODIEN_NV.Size = new System.Drawing.Size(285, 55);
            this.btn_GIAODIEN_NV.TabIndex = 9;
            this.btn_GIAODIEN_NV.Text = "CHUYỂN SANG GIAO DIỆN NHÂN VIÊN";
            this.btn_GIAODIEN_NV.UseVisualStyleBackColor = false;
            this.btn_GIAODIEN_NV.Click += new System.EventHandler(this.btn_GIAODIEN_NV_Click);
            // 
            // INSERT
            // 
            this.INSERT.BackColor = System.Drawing.Color.Aquamarine;
            this.INSERT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INSERT.Location = new System.Drawing.Point(650, 379);
            this.INSERT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.INSERT.Name = "INSERT";
            this.INSERT.Size = new System.Drawing.Size(285, 33);
            this.INSERT.TabIndex = 10;
            this.INSERT.Text = "THÊM PHÂN CÔNG";
            this.INSERT.UseVisualStyleBackColor = false;
            this.INSERT.Click += new System.EventHandler(this.INSERT_Click);
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.Color.Aquamarine;
            this.DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETE.Location = new System.Drawing.Point(650, 425);
            this.DELETE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(285, 30);
            this.DELETE.TabIndex = 11;
            this.DELETE.Text = "XÓA PHÂN CÔNG";
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.BackColor = System.Drawing.Color.Aquamarine;
            this.UPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATE.Location = new System.Drawing.Point(650, 469);
            this.UPDATE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(285, 30);
            this.UPDATE.TabIndex = 12;
            this.UPDATE.Text = "CẬP NHẬT PHÂN CÔNG";
            this.UPDATE.UseVisualStyleBackColor = false;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // MH_TRUONGPHONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 602);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.INSERT);
            this.Controls.Add(this.btn_GIAODIEN_NV);
            this.Controls.Add(this.PHANCONGTRUONGPHONG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DANHSACHNHANVIENTRUONGPHONG);
            this.Controls.Add(this.label1);
            this.Name = "MH_TRUONGPHONG";
            this.Text = "MH_TRUONGPHONG";
            this.Load += new System.EventHandler(this.MH_TRUONGPHONG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PHANCONGTRUONGPHONG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DANHSACHNHANVIENTRUONGPHONG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PHANCONGTRUONGPHONG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DANHSACHNHANVIENTRUONGPHONG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_GIAODIEN_NV;
        private System.Windows.Forms.Button INSERT;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button UPDATE;
    }
}