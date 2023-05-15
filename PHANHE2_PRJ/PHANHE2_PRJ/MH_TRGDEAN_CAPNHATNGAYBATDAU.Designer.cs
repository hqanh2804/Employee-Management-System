namespace PHANHE2_PRJ
{
    partial class MH_TRGDEAN_CAPNHATNGAYBATDAU
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
            this.txt_MADA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDA_UpdateDate = new System.Windows.Forms.Button();
            this.txt_Ngay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_MADA
            // 
            this.txt_MADA.Location = new System.Drawing.Point(178, 91);
            this.txt_MADA.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MADA.Name = "txt_MADA";
            this.txt_MADA.Size = new System.Drawing.Size(322, 20);
            this.txt_MADA.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "MÃ ĐỀ ÁN";
            // 
            // btnDA_UpdateDate
            // 
            this.btnDA_UpdateDate.BackColor = System.Drawing.Color.Cyan;
            this.btnDA_UpdateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDA_UpdateDate.Location = new System.Drawing.Point(366, 196);
            this.btnDA_UpdateDate.Margin = new System.Windows.Forms.Padding(2);
            this.btnDA_UpdateDate.Name = "btnDA_UpdateDate";
            this.btnDA_UpdateDate.Size = new System.Drawing.Size(136, 47);
            this.btnDA_UpdateDate.TabIndex = 23;
            this.btnDA_UpdateDate.Text = "CẬP NHẬT";
            this.btnDA_UpdateDate.UseVisualStyleBackColor = false;
            this.btnDA_UpdateDate.Click += new System.EventHandler(this.btnDA_UpdateDate_Click);
            // 
            // txt_Ngay
            // 
            this.txt_Ngay.Location = new System.Drawing.Point(178, 149);
            this.txt_Ngay.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Ngay.Name = "txt_Ngay";
            this.txt_Ngay.Size = new System.Drawing.Size(322, 20);
            this.txt_Ngay.TabIndex = 22;
            this.txt_Ngay.Text = "Ex: DD/MM/YYYY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "NGÀY BẮT ĐẦU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "CẬP NHẬT NGÀY BẮT ĐẦU ĐỀ ÁN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MH_CAPNHATNGAYBATDAUDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 271);
            this.Controls.Add(this.txt_MADA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDA_UpdateDate);
            this.Controls.Add(this.txt_Ngay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(555, 310);
            this.MinimumSize = new System.Drawing.Size(555, 310);
            this.Name = "MH_CAPNHATNGAYBATDAUDA";
            this.Text = "MH_CAPNHATNGAYBATDAUDA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MADA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDA_UpdateDate;
        private System.Windows.Forms.TextBox txt_Ngay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}