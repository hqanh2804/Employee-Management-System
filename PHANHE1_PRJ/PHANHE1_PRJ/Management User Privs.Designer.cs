namespace PHANHE1_PRJ
{
    partial class Management_User_Privs
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
            this.dgtv_UserPrivs = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.P_USERNAME = new System.Windows.Forms.TextBox();
            this.P_PRIVSNAME = new System.Windows.Forms.TextBox();
            this.P_OBJECTNAME = new System.Windows.Forms.TextBox();
            this.btn_Grant = new System.Windows.Forms.Button();
            this.btn_Revoke = new System.Windows.Forms.Button();
            this.GRANT_OPTION = new System.Windows.Forms.TextBox();
            this.btn_VIEW = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgtv_UserPrivs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANANGEMENT USER PRIVS";
            // 
            // dgtv_UserPrivs
            // 
            this.dgtv_UserPrivs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtv_UserPrivs.Location = new System.Drawing.Point(13, 73);
            this.dgtv_UserPrivs.Name = "dgtv_UserPrivs";
            this.dgtv_UserPrivs.RowHeadersWidth = 62;
            this.dgtv_UserPrivs.RowTemplate.Height = 28;
            this.dgtv_UserPrivs.Size = new System.Drawing.Size(798, 141);
            this.dgtv_UserPrivs.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "USERNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "PRIVSNAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "OBJECTNAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "GRANT OPTION";
            // 
            // P_USERNAME
            // 
            this.P_USERNAME.Location = new System.Drawing.Point(184, 242);
            this.P_USERNAME.Name = "P_USERNAME";
            this.P_USERNAME.Size = new System.Drawing.Size(316, 26);
            this.P_USERNAME.TabIndex = 7;
            // 
            // P_PRIVSNAME
            // 
            this.P_PRIVSNAME.Location = new System.Drawing.Point(184, 290);
            this.P_PRIVSNAME.Name = "P_PRIVSNAME";
            this.P_PRIVSNAME.Size = new System.Drawing.Size(316, 26);
            this.P_PRIVSNAME.TabIndex = 8;
            // 
            // P_OBJECTNAME
            // 
            this.P_OBJECTNAME.Location = new System.Drawing.Point(184, 336);
            this.P_OBJECTNAME.Name = "P_OBJECTNAME";
            this.P_OBJECTNAME.Size = new System.Drawing.Size(316, 26);
            this.P_OBJECTNAME.TabIndex = 9;
            // 
            // btn_Grant
            // 
            this.btn_Grant.Location = new System.Drawing.Point(628, 259);
            this.btn_Grant.Name = "btn_Grant";
            this.btn_Grant.Size = new System.Drawing.Size(115, 40);
            this.btn_Grant.TabIndex = 10;
            this.btn_Grant.Text = "GRANT";
            this.btn_Grant.UseVisualStyleBackColor = true;
            this.btn_Grant.Click += new System.EventHandler(this.btn_Grant_Click);
            // 
            // btn_Revoke
            // 
            this.btn_Revoke.Location = new System.Drawing.Point(628, 322);
            this.btn_Revoke.Name = "btn_Revoke";
            this.btn_Revoke.Size = new System.Drawing.Size(115, 40);
            this.btn_Revoke.TabIndex = 11;
            this.btn_Revoke.Text = "REVOKE";
            this.btn_Revoke.UseVisualStyleBackColor = true;
            this.btn_Revoke.Click += new System.EventHandler(this.btn_Revoke_Click);
            // 
            // GRANT_OPTION
            // 
            this.GRANT_OPTION.Location = new System.Drawing.Point(183, 386);
            this.GRANT_OPTION.Name = "GRANT_OPTION";
            this.GRANT_OPTION.Size = new System.Drawing.Size(316, 26);
            this.GRANT_OPTION.TabIndex = 12;
            // 
            // btn_VIEW
            // 
            this.btn_VIEW.Location = new System.Drawing.Point(628, 386);
            this.btn_VIEW.Name = "btn_VIEW";
            this.btn_VIEW.Size = new System.Drawing.Size(115, 40);
            this.btn_VIEW.TabIndex = 13;
            this.btn_VIEW.Text = "VIEW PRIVS";
            this.btn_VIEW.UseVisualStyleBackColor = true;
            this.btn_VIEW.Click += new System.EventHandler(this.btn_VIEW_Click);
            // 
            // Management_User_Privs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 454);
            this.Controls.Add(this.btn_VIEW);
            this.Controls.Add(this.GRANT_OPTION);
            this.Controls.Add(this.btn_Revoke);
            this.Controls.Add(this.btn_Grant);
            this.Controls.Add(this.P_OBJECTNAME);
            this.Controls.Add(this.P_PRIVSNAME);
            this.Controls.Add(this.P_USERNAME);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgtv_UserPrivs);
            this.Controls.Add(this.label1);
            this.Name = "Management_User_Privs";
            this.Text = "Management_User_Privs";
            ((System.ComponentModel.ISupportInitialize)(this.dgtv_UserPrivs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgtv_UserPrivs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox P_USERNAME;
        private System.Windows.Forms.TextBox P_PRIVSNAME;
        private System.Windows.Forms.TextBox P_OBJECTNAME;
        private System.Windows.Forms.Button btn_Grant;
        private System.Windows.Forms.Button btn_Revoke;
        private System.Windows.Forms.TextBox GRANT_OPTION;
        private System.Windows.Forms.Button btn_VIEW;
    }
}