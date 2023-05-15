namespace PHANHE2_PRJ
{
    partial class MH_NHANVIEN_XEMDEAN
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
            this.dtg_XEMDEAN = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_XEMDEAN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "DANH SÁCH ĐỀ ÁN CỦA CÔNG TY";
            // 
            // dtg_XEMDEAN
            // 
            this.dtg_XEMDEAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_XEMDEAN.Location = new System.Drawing.Point(9, 78);
            this.dtg_XEMDEAN.Margin = new System.Windows.Forms.Padding(2);
            this.dtg_XEMDEAN.Name = "dtg_XEMDEAN";
            this.dtg_XEMDEAN.RowHeadersWidth = 62;
            this.dtg_XEMDEAN.RowTemplate.Height = 28;
            this.dtg_XEMDEAN.Size = new System.Drawing.Size(630, 270);
            this.dtg_XEMDEAN.TabIndex = 10;
            // 
            // MH_NHANVIEN_XEMDEAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 361);
            this.Controls.Add(this.dtg_XEMDEAN);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(665, 400);
            this.MinimumSize = new System.Drawing.Size(665, 400);
            this.Name = "MH_NHANVIEN_XEMDEAN";
            this.Text = "MH_NHANVIEN_XEMDEAN";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_XEMDEAN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtg_XEMDEAN;
    }
}