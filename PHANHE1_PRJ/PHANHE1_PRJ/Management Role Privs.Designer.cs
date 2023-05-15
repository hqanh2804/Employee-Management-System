namespace PHANHE1_PRJ
{
    partial class Management_Role_Privs
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
            this.btn_Revoke = new System.Windows.Forms.Button();
            this.btn_Grant = new System.Windows.Forms.Button();
            this.P_OBJECTNAME = new System.Windows.Forms.TextBox();
            this.P_PRIVSNAME = new System.Windows.Forms.TextBox();
            this.P_ROLENAME = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgtv_RolePrivs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_VIEW = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgtv_RolePrivs)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Revoke
            // 
            this.btn_Revoke.Location = new System.Drawing.Point(658, 407);
            this.btn_Revoke.Name = "btn_Revoke";
            this.btn_Revoke.Size = new System.Drawing.Size(115, 40);
            this.btn_Revoke.TabIndex = 23;
            this.btn_Revoke.Text = "REVOKE";
            this.btn_Revoke.UseVisualStyleBackColor = true;
            this.btn_Revoke.Click += new System.EventHandler(this.btn_Revoke_Click);
            // 
            // btn_Grant
            // 
            this.btn_Grant.Location = new System.Drawing.Point(658, 344);
            this.btn_Grant.Name = "btn_Grant";
            this.btn_Grant.Size = new System.Drawing.Size(115, 40);
            this.btn_Grant.TabIndex = 22;
            this.btn_Grant.Text = "GRANT";
            this.btn_Grant.UseVisualStyleBackColor = true;
            this.btn_Grant.Click += new System.EventHandler(this.btn_Grant_Click);
            // 
            // P_OBJECTNAME
            // 
            this.P_OBJECTNAME.Location = new System.Drawing.Point(211, 452);
            this.P_OBJECTNAME.Name = "P_OBJECTNAME";
            this.P_OBJECTNAME.Size = new System.Drawing.Size(316, 26);
            this.P_OBJECTNAME.TabIndex = 21;
            // 
            // P_PRIVSNAME
            // 
            this.P_PRIVSNAME.Location = new System.Drawing.Point(211, 406);
            this.P_PRIVSNAME.Name = "P_PRIVSNAME";
            this.P_PRIVSNAME.Size = new System.Drawing.Size(316, 26);
            this.P_PRIVSNAME.TabIndex = 20;
            // 
            // P_ROLENAME
            // 
            this.P_ROLENAME.Location = new System.Drawing.Point(211, 358);
            this.P_ROLENAME.Name = "P_ROLENAME";
            this.P_ROLENAME.Size = new System.Drawing.Size(316, 26);
            this.P_ROLENAME.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "OBJECTNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "PRIVSNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "ROLENAME";
            // 
            // dgtv_RolePrivs
            // 
            this.dgtv_RolePrivs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtv_RolePrivs.Location = new System.Drawing.Point(1, 83);
            this.dgtv_RolePrivs.Name = "dgtv_RolePrivs";
            this.dgtv_RolePrivs.RowHeadersWidth = 62;
            this.dgtv_RolePrivs.RowTemplate.Height = 28;
            this.dgtv_RolePrivs.Size = new System.Drawing.Size(877, 210);
            this.dgtv_RolePrivs.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "MANANGEMENT ROLE PRIVS";
            // 
            // btn_VIEW
            // 
            this.btn_VIEW.Location = new System.Drawing.Point(658, 473);
            this.btn_VIEW.Name = "btn_VIEW";
            this.btn_VIEW.Size = new System.Drawing.Size(115, 40);
            this.btn_VIEW.TabIndex = 24;
            this.btn_VIEW.Text = "VIEW PRIVS";
            this.btn_VIEW.UseVisualStyleBackColor = true;
            this.btn_VIEW.Click += new System.EventHandler(this.btn_VIEW_Click);
            // 
            // Management_Role_Privs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 543);
            this.Controls.Add(this.btn_VIEW);
            this.Controls.Add(this.btn_Revoke);
            this.Controls.Add(this.btn_Grant);
            this.Controls.Add(this.P_OBJECTNAME);
            this.Controls.Add(this.P_PRIVSNAME);
            this.Controls.Add(this.P_ROLENAME);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgtv_RolePrivs);
            this.Controls.Add(this.label1);
            this.Name = "Management_Role_Privs";
            this.Text = "Management_Role_Privs";
            ((System.ComponentModel.ISupportInitialize)(this.dgtv_RolePrivs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Revoke;
        private System.Windows.Forms.Button btn_Grant;
        private System.Windows.Forms.TextBox P_OBJECTNAME;
        private System.Windows.Forms.TextBox P_PRIVSNAME;
        private System.Windows.Forms.TextBox P_ROLENAME;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgtv_RolePrivs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_VIEW;
    }
}