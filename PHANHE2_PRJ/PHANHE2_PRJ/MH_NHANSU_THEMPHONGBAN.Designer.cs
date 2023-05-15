namespace PHANHE2_PRJ
{
    partial class MH_NHANSU_THEMPHONGBAN
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
            this.txt_TRPHG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MAPB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPB_Insert = new System.Windows.Forms.Button();
            this.txt_TenPB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_TRPHG
            // 
            this.txt_TRPHG.Location = new System.Drawing.Point(179, 207);
            this.txt_TRPHG.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TRPHG.Name = "txt_TRPHG";
            this.txt_TRPHG.Size = new System.Drawing.Size(322, 20);
            this.txt_TRPHG.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "TRƯỞNG PHÒNG";
            // 
            // txt_MAPB
            // 
            this.txt_MAPB.Location = new System.Drawing.Point(179, 89);
            this.txt_MAPB.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MAPB.Name = "txt_MAPB";
            this.txt_MAPB.Size = new System.Drawing.Size(322, 20);
            this.txt_MAPB.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "MÃ PHÒNG BAN";
            // 
            // btnPB_Insert
            // 
            this.btnPB_Insert.BackColor = System.Drawing.Color.Cyan;
            this.btnPB_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPB_Insert.Location = new System.Drawing.Point(365, 267);
            this.btnPB_Insert.Margin = new System.Windows.Forms.Padding(2);
            this.btnPB_Insert.Name = "btnPB_Insert";
            this.btnPB_Insert.Size = new System.Drawing.Size(136, 47);
            this.btnPB_Insert.TabIndex = 33;
            this.btnPB_Insert.Text = "THÊM";
            this.btnPB_Insert.UseVisualStyleBackColor = false;
            this.btnPB_Insert.Click += new System.EventHandler(this.btnPB_Insert_Click);
            // 
            // txt_TenPB
            // 
            this.txt_TenPB.Location = new System.Drawing.Point(179, 147);
            this.txt_TenPB.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TenPB.Name = "txt_TenPB";
            this.txt_TenPB.Size = new System.Drawing.Size(322, 20);
            this.txt_TenPB.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "TÊN PHÒNG BAN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "THÊM PHÒNG BAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MH_THEMPHONGBAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 331);
            this.Controls.Add(this.txt_TRPHG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_MAPB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPB_Insert);
            this.Controls.Add(this.txt_TenPB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(555, 370);
            this.MinimumSize = new System.Drawing.Size(555, 370);
            this.Name = "MH_THEMPHONGBAN";
            this.Text = "MH_THEMPHONGBAN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TRPHG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MAPB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPB_Insert;
        private System.Windows.Forms.TextBox txt_TenPB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}