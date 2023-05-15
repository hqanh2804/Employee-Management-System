namespace PHANHE2_PRJ
{
    partial class MH_TRUONGPHONG_XOAPHANCONG
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
            this.DELETE = new System.Windows.Forms.Button();
            this.MADA = new System.Windows.Forms.TextBox();
            this.MANV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.DELETE.Location = new System.Drawing.Point(270, 328);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(260, 44);
            this.DELETE.TabIndex = 23;
            this.DELETE.Text = "XÓA";
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // MADA
            // 
            this.MADA.Location = new System.Drawing.Point(244, 237);
            this.MADA.Name = "MADA";
            this.MADA.Size = new System.Drawing.Size(432, 22);
            this.MADA.TabIndex = 21;
            // 
            // MANV
            // 
            this.MANV.Location = new System.Drawing.Point(244, 169);
            this.MANV.Name = "MANV";
            this.MANV.Size = new System.Drawing.Size(432, 22);
            this.MANV.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(125, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "MADA :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(125, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "MANV :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(263, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "XÓA PHÂN CÔNG";
            // 
            // MH_TRUONGPHONG_XOAPHANCONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.MADA);
            this.Controls.Add(this.MANV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MH_TRUONGPHONG_XOAPHANCONG";
            this.Text = "MH_TRUONGPHONG_XOAPHANCONG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.TextBox MADA;
        private System.Windows.Forms.TextBox MANV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}