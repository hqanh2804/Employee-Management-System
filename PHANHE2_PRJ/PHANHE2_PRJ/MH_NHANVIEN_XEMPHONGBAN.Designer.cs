namespace PHANHE2_PRJ
{
    partial class MH_NHANVIEN_XEMPHONGBAN
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
            this.dtg_PHONGBAN = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_PHONGBAN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "DANH SÁCH PHÒNG BAN CỦA CÔNG TY";
            // 
            // dtg_PHONGBAN
            // 
            this.dtg_PHONGBAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_PHONGBAN.Location = new System.Drawing.Point(77, 62);
            this.dtg_PHONGBAN.Margin = new System.Windows.Forms.Padding(2);
            this.dtg_PHONGBAN.Name = "dtg_PHONGBAN";
            this.dtg_PHONGBAN.RowHeadersWidth = 62;
            this.dtg_PHONGBAN.RowTemplate.Height = 28;
            this.dtg_PHONGBAN.Size = new System.Drawing.Size(425, 317);
            this.dtg_PHONGBAN.TabIndex = 9;
            // 
            // MH_NHANVIEN_XEMPHONGBAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 401);
            this.Controls.Add(this.dtg_PHONGBAN);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(610, 440);
            this.MinimumSize = new System.Drawing.Size(610, 440);
            this.Name = "MH_NHANVIEN_XEMPHONGBAN";
            this.Text = "MH_NHANVIEN_XEMPHONGBAN";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_PHONGBAN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtg_PHONGBAN;
    }
}