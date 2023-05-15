namespace PHANHE2_PRJ
{
    partial class MH_TRUONGPHONG_THEMPHANCONG
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
            this.INSERT = new System.Windows.Forms.Button();
            this.TIME = new System.Windows.Forms.TextBox();
            this.MADA = new System.Windows.Forms.TextBox();
            this.MANV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // INSERT
            // 
            this.INSERT.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.INSERT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.INSERT.Location = new System.Drawing.Point(263, 313);
            this.INSERT.Name = "INSERT";
            this.INSERT.Size = new System.Drawing.Size(260, 44);
            this.INSERT.TabIndex = 15;
            this.INSERT.Text = "THÊM";
            this.INSERT.UseVisualStyleBackColor = false;
            this.INSERT.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // TIME
            // 
            this.TIME.Location = new System.Drawing.Point(237, 235);
            this.TIME.Name = "TIME";
            this.TIME.Size = new System.Drawing.Size(432, 22);
            this.TIME.TabIndex = 14;
            this.TIME.TextChanged += new System.EventHandler(this.TIME_TextChanged);
            // 
            // MADA
            // 
            this.MADA.Location = new System.Drawing.Point(237, 195);
            this.MADA.Name = "MADA";
            this.MADA.Size = new System.Drawing.Size(432, 22);
            this.MADA.TabIndex = 13;
            this.MADA.TextChanged += new System.EventHandler(this.MADA_TextChanged);
            // 
            // MANV
            // 
            this.MANV.Location = new System.Drawing.Point(237, 154);
            this.MANV.Name = "MANV";
            this.MANV.Size = new System.Drawing.Size(432, 22);
            this.MANV.TabIndex = 12;
            this.MANV.TextChanged += new System.EventHandler(this.MANV_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(118, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "THOIGIAN :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(118, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "MADA :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(118, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "MANV :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(230, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "THÊM PHÂN CÔNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MH_TRUONGPHONG_THEMPHANCONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.INSERT);
            this.Controls.Add(this.TIME);
            this.Controls.Add(this.MADA);
            this.Controls.Add(this.MANV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MH_TRUONGPHONG_THEMPHANCONG";
            this.Text = "MH_TRUONGPHONG_THEMPHANCONG";
            this.Load += new System.EventHandler(this.MH_TRUONGPHONG_THEMPHANCONG_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button INSERT;
        private System.Windows.Forms.TextBox TIME;
        private System.Windows.Forms.TextBox MADA;
        private System.Windows.Forms.TextBox MANV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}