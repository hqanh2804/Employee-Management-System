namespace PHANHE2_PRJ
{
    partial class MH_TRUONGPHONG_CAPNHATPHANCONG
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MANV = new System.Windows.Forms.TextBox();
            this.MADA = new System.Windows.Forms.TextBox();
            this.TIME = new System.Windows.Forms.TextBox();
            this.UPDATE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(114, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT THỜI GIAN PHÂN CÔNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(129, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "MANV :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(129, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "MADA :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(129, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "THOIGIAN :";
            // 
            // MANV
            // 
            this.MANV.Location = new System.Drawing.Point(248, 153);
            this.MANV.Name = "MANV";
            this.MANV.Size = new System.Drawing.Size(432, 22);
            this.MANV.TabIndex = 4;
            this.MANV.TextChanged += new System.EventHandler(this.MANV_TextChanged);
            // 
            // MADA
            // 
            this.MADA.Location = new System.Drawing.Point(248, 194);
            this.MADA.Name = "MADA";
            this.MADA.Size = new System.Drawing.Size(432, 22);
            this.MADA.TabIndex = 5;
            this.MADA.TextChanged += new System.EventHandler(this.MADA_TextChanged);
            // 
            // TIME
            // 
            this.TIME.Location = new System.Drawing.Point(248, 234);
            this.TIME.Name = "TIME";
            this.TIME.Size = new System.Drawing.Size(432, 22);
            this.TIME.TabIndex = 6;
            this.TIME.TextChanged += new System.EventHandler(this.TIME_TextChanged);
            // 
            // UPDATE
            // 
            this.UPDATE.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.UPDATE.Location = new System.Drawing.Point(260, 308);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(260, 44);
            this.UPDATE.TabIndex = 7;
            this.UPDATE.Text = "CẬP NHẬT";
            this.UPDATE.UseVisualStyleBackColor = false;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // MH_TRUONGPHONG_CAPNHATPHANCONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.TIME);
            this.Controls.Add(this.MADA);
            this.Controls.Add(this.MANV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MH_TRUONGPHONG_CAPNHATPHANCONG";
            this.Text = "MH_TRUONGPHONG_CAPNHATPHANCONG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MANV;
        private System.Windows.Forms.TextBox MADA;
        private System.Windows.Forms.TextBox TIME;
        private System.Windows.Forms.Button UPDATE;
    }
}