namespace PHANHE2_PRJ
{
    partial class MH_NHANSU_CAPNHATNGAYSINHNV
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
            this.txt_MANV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQLNV_UpdateDate = new System.Windows.Forms.Button();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_MANV
            // 
            this.txt_MANV.Location = new System.Drawing.Point(178, 89);
            this.txt_MANV.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MANV.Name = "txt_MANV";
            this.txt_MANV.Size = new System.Drawing.Size(322, 20);
            this.txt_MANV.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "MÃ NHÂN VIÊN";
            // 
            // btnQLNV_UpdateDate
            // 
            this.btnQLNV_UpdateDate.BackColor = System.Drawing.Color.Cyan;
            this.btnQLNV_UpdateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNV_UpdateDate.Location = new System.Drawing.Point(366, 194);
            this.btnQLNV_UpdateDate.Margin = new System.Windows.Forms.Padding(2);
            this.btnQLNV_UpdateDate.Name = "btnQLNV_UpdateDate";
            this.btnQLNV_UpdateDate.Size = new System.Drawing.Size(136, 47);
            this.btnQLNV_UpdateDate.TabIndex = 29;
            this.btnQLNV_UpdateDate.Text = "CẬP NHẬT";
            this.btnQLNV_UpdateDate.UseVisualStyleBackColor = false;
            this.btnQLNV_UpdateDate.Click += new System.EventHandler(this.btnQLNV_UpdateDate_Click);
            // 
            // txt_Date
            // 
            this.txt_Date.Location = new System.Drawing.Point(178, 147);
            this.txt_Date.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(322, 20);
            this.txt_Date.TabIndex = 28;
            this.txt_Date.Text = "Ex: DD/MM/YYYY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "NGÀY SINH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "CẬP NHẬT NGÀY SINH NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MH_NHANSU_CAPNHATNGAYSINHNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 271);
            this.Controls.Add(this.txt_MANV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQLNV_UpdateDate);
            this.Controls.Add(this.txt_Date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(555, 310);
            this.MinimumSize = new System.Drawing.Size(555, 310);
            this.Name = "MH_NHANSU_CAPNHATNGAYSINHNV";
            this.Text = "MH_NHANSU_CAPNHATNGAYSINHNV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MANV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQLNV_UpdateDate;
        private System.Windows.Forms.TextBox txt_Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}