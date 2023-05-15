namespace PHANHE2_PRJ
{
    partial class MH_NHANSU_QLPHONGBAN
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
            this.btnQLPB_Menu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQLPB_Update_Ten = new System.Windows.Forms.Button();
            this.btnQLNV_Update_TRPHG = new System.Windows.Forms.Button();
            this.btnQLPB_Insert = new System.Windows.Forms.Button();
            this.dgv_V_PHONG_NHANSU = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_V_PHONG_NHANSU)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQLPB_Menu
            // 
            this.btnQLPB_Menu.BackColor = System.Drawing.Color.Cyan;
            this.btnQLPB_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLPB_Menu.Location = new System.Drawing.Point(593, 290);
            this.btnQLPB_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.btnQLPB_Menu.Name = "btnQLPB_Menu";
            this.btnQLPB_Menu.Size = new System.Drawing.Size(76, 45);
            this.btnQLPB_Menu.TabIndex = 16;
            this.btnQLPB_Menu.Text = "MENU";
            this.btnQLPB_Menu.UseVisualStyleBackColor = false;
            this.btnQLPB_Menu.Click += new System.EventHandler(this.btnQLPB_Menu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnQLPB_Update_Ten);
            this.groupBox1.Controls.Add(this.btnQLNV_Update_TRPHG);
            this.groupBox1.Controls.Add(this.btnQLPB_Insert);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(385, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 233);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các chức năng QLPB của vai trò Nhân sự";
            // 
            // btnQLPB_Update_Ten
            // 
            this.btnQLPB_Update_Ten.Location = new System.Drawing.Point(56, 101);
            this.btnQLPB_Update_Ten.Name = "btnQLPB_Update_Ten";
            this.btnQLPB_Update_Ten.Size = new System.Drawing.Size(168, 50);
            this.btnQLPB_Update_Ten.TabIndex = 2;
            this.btnQLPB_Update_Ten.Text = "CẬP NHẬT\r\nTÊN PHÒNG BAN";
            this.btnQLPB_Update_Ten.UseVisualStyleBackColor = true;
            this.btnQLPB_Update_Ten.Click += new System.EventHandler(this.btnQLPB_Update_Ten_Click);
            // 
            // btnQLNV_Update_TRPHG
            // 
            this.btnQLNV_Update_TRPHG.Location = new System.Drawing.Point(56, 171);
            this.btnQLNV_Update_TRPHG.Name = "btnQLNV_Update_TRPHG";
            this.btnQLNV_Update_TRPHG.Size = new System.Drawing.Size(168, 50);
            this.btnQLNV_Update_TRPHG.TabIndex = 1;
            this.btnQLNV_Update_TRPHG.Text = "CẬP NHẬT\r\nTRƯỞNG PHÒNG";
            this.btnQLNV_Update_TRPHG.UseVisualStyleBackColor = true;
            this.btnQLNV_Update_TRPHG.Click += new System.EventHandler(this.btnQLNV_Update_TRPHG_Click);
            // 
            // btnQLPB_Insert
            // 
            this.btnQLPB_Insert.Location = new System.Drawing.Point(56, 33);
            this.btnQLPB_Insert.Name = "btnQLPB_Insert";
            this.btnQLPB_Insert.Size = new System.Drawing.Size(168, 50);
            this.btnQLPB_Insert.TabIndex = 0;
            this.btnQLPB_Insert.Text = "THÊM PHÒNG BAN";
            this.btnQLPB_Insert.UseVisualStyleBackColor = true;
            this.btnQLPB_Insert.Click += new System.EventHandler(this.btnQLPB_Insert_Click);
            // 
            // dgv_V_PHONG_NHANSU
            // 
            this.dgv_V_PHONG_NHANSU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_V_PHONG_NHANSU.Location = new System.Drawing.Point(13, 30);
            this.dgv_V_PHONG_NHANSU.Name = "dgv_V_PHONG_NHANSU";
            this.dgv_V_PHONG_NHANSU.Size = new System.Drawing.Size(341, 305);
            this.dgv_V_PHONG_NHANSU.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "THÔNG TIN PHÒNG BAN";
            // 
            // MH_NHANSU_QLPHONGBAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 351);
            this.Controls.Add(this.btnQLPB_Menu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_V_PHONG_NHANSU);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(700, 390);
            this.MinimumSize = new System.Drawing.Size(700, 390);
            this.Name = "MH_NHANSU_QLPHONGBAN";
            this.Text = "MH_NHANSU_QLPHONGBAN";
            this.Load += new System.EventHandler(this.MH_QLPHONGBAN_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_V_PHONG_NHANSU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQLPB_Menu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQLPB_Update_Ten;
        private System.Windows.Forms.Button btnQLNV_Update_TRPHG;
        private System.Windows.Forms.Button btnQLPB_Insert;
        private System.Windows.Forms.DataGridView dgv_V_PHONG_NHANSU;
        private System.Windows.Forms.Label label1;
    }
}