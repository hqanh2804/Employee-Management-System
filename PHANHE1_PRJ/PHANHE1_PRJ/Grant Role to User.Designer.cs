namespace PHANHE1_PRJ
{
    partial class Grant_Role_to_User
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
            this.P_ROLENAME = new System.Windows.Forms.TextBox();
            this.P_USERNAME = new System.Windows.Forms.TextBox();
            this.btn_GrantRoletoUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "GRANT ROLE TO USER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ROLENAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "USERNAME";
            // 
            // P_ROLENAME
            // 
            this.P_ROLENAME.Location = new System.Drawing.Point(223, 142);
            this.P_ROLENAME.Name = "P_ROLENAME";
            this.P_ROLENAME.Size = new System.Drawing.Size(276, 26);
            this.P_ROLENAME.TabIndex = 3;
            // 
            // P_USERNAME
            // 
            this.P_USERNAME.Location = new System.Drawing.Point(223, 198);
            this.P_USERNAME.Name = "P_USERNAME";
            this.P_USERNAME.Size = new System.Drawing.Size(276, 26);
            this.P_USERNAME.TabIndex = 4;
            // 
            // btn_GrantRoletoUser
            // 
            this.btn_GrantRoletoUser.Location = new System.Drawing.Point(397, 273);
            this.btn_GrantRoletoUser.Name = "btn_GrantRoletoUser";
            this.btn_GrantRoletoUser.Size = new System.Drawing.Size(102, 40);
            this.btn_GrantRoletoUser.TabIndex = 5;
            this.btn_GrantRoletoUser.Text = "GRANT";
            this.btn_GrantRoletoUser.UseVisualStyleBackColor = true;
            this.btn_GrantRoletoUser.Click += new System.EventHandler(this.btn_GrantRoletoUser_Click);
            // 
            // Grant_Role_to_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_GrantRoletoUser);
            this.Controls.Add(this.P_USERNAME);
            this.Controls.Add(this.P_ROLENAME);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Grant_Role_to_User";
            this.Text = "Grant_Role_to_User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox P_ROLENAME;
        private System.Windows.Forms.TextBox P_USERNAME;
        private System.Windows.Forms.Button btn_GrantRoletoUser;
    }
}