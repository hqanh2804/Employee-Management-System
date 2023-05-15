namespace PHANHE2_PRJ
{
    partial class MH_QLTRUCTIEP
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
            this.dtg_DSNVQLTRUCTIEP = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dtg_PHANCONG = new System.Windows.Forms.DataGridView();
            this.btn_GIAODIEN_NV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DSNVQLTRUCTIEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_PHANCONG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH CÁC NHÂN VIÊN TRỰC THUỘC QUẢN LÍ";
            // 
            // dtg_DSNVQLTRUCTIEP
            // 
            this.dtg_DSNVQLTRUCTIEP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DSNVQLTRUCTIEP.Location = new System.Drawing.Point(9, 36);
            this.dtg_DSNVQLTRUCTIEP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtg_DSNVQLTRUCTIEP.Name = "dtg_DSNVQLTRUCTIEP";
            this.dtg_DSNVQLTRUCTIEP.RowHeadersWidth = 62;
            this.dtg_DSNVQLTRUCTIEP.RowTemplate.Height = 28;
            this.dtg_DSNVQLTRUCTIEP.Size = new System.Drawing.Size(671, 198);
            this.dtg_DSNVQLTRUCTIEP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(580, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "THÔNG TIN PHÂN CÔNG CỦA CHÍNH MÌNH VÀ CÁC NHÂN VIÊN MÌNH QUẢN LÍ";
            // 
            // dtg_PHANCONG
            // 
            this.dtg_PHANCONG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_PHANCONG.Location = new System.Drawing.Point(9, 281);
            this.dtg_PHANCONG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtg_PHANCONG.Name = "dtg_PHANCONG";
            this.dtg_PHANCONG.RowHeadersWidth = 62;
            this.dtg_PHANCONG.RowTemplate.Height = 28;
            this.dtg_PHANCONG.Size = new System.Drawing.Size(369, 141);
            this.dtg_PHANCONG.TabIndex = 4;
            // 
            // btn_GIAODIEN_NV
            // 
            this.btn_GIAODIEN_NV.BackColor = System.Drawing.Color.Cyan;
            this.btn_GIAODIEN_NV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GIAODIEN_NV.Location = new System.Drawing.Point(466, 437);
            this.btn_GIAODIEN_NV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_GIAODIEN_NV.Name = "btn_GIAODIEN_NV";
            this.btn_GIAODIEN_NV.Size = new System.Drawing.Size(214, 45);
            this.btn_GIAODIEN_NV.TabIndex = 5;
            this.btn_GIAODIEN_NV.Text = "CHUYỂN SANG GIAO DIỆN NHÂN VIÊN";
            this.btn_GIAODIEN_NV.UseVisualStyleBackColor = false;
            this.btn_GIAODIEN_NV.Click += new System.EventHandler(this.btn_GIAODIEN_NV_Click);
            // 
            // MH_QLTRUCTIEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 491);
            this.Controls.Add(this.btn_GIAODIEN_NV);
            this.Controls.Add(this.dtg_PHANCONG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtg_DSNVQLTRUCTIEP);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(725, 530);
            this.MinimumSize = new System.Drawing.Size(725, 530);
            this.Name = "MH_QLTRUCTIEP";
            this.Text = "MH_QLTRUCTIEP";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DSNVQLTRUCTIEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_PHANCONG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtg_DSNVQLTRUCTIEP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtg_PHANCONG;
        private System.Windows.Forms.Button btn_GIAODIEN_NV;
    }
}