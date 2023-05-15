namespace PHANHE1_PRJ
{
    partial class QUANTRI_CONSOLE
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
            this.btn_MngUsers = new System.Windows.Forms.Button();
            this.btn_MngRoles = new System.Windows.Forms.Button();
            this.btn_GrantRoletoUser = new System.Windows.Forms.Button();
            this.btn_MngUserPrivs = new System.Windows.Forms.Button();
            this.btn_MngRolePrivs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAC QUYEN CUA QUAN TRI";
            // 
            // btn_MngUsers
            // 
            this.btn_MngUsers.Location = new System.Drawing.Point(108, 106);
            this.btn_MngUsers.Name = "btn_MngUsers";
            this.btn_MngUsers.Size = new System.Drawing.Size(196, 80);
            this.btn_MngUsers.TabIndex = 5;
            this.btn_MngUsers.Text = "MANAGEMNET USERS";
            this.btn_MngUsers.UseVisualStyleBackColor = true;
            this.btn_MngUsers.Click += new System.EventHandler(this.btn_MngUsers_Click);
            // 
            // btn_MngRoles
            // 
            this.btn_MngRoles.Location = new System.Drawing.Point(511, 106);
            this.btn_MngRoles.Name = "btn_MngRoles";
            this.btn_MngRoles.Size = new System.Drawing.Size(196, 80);
            this.btn_MngRoles.TabIndex = 6;
            this.btn_MngRoles.Text = "MANAGEMNET ROLES";
            this.btn_MngRoles.UseVisualStyleBackColor = true;
            this.btn_MngRoles.Click += new System.EventHandler(this.btn_MngRoles_Click);
            // 
            // btn_GrantRoletoUser
            // 
            this.btn_GrantRoletoUser.Location = new System.Drawing.Point(313, 346);
            this.btn_GrantRoletoUser.Name = "btn_GrantRoletoUser";
            this.btn_GrantRoletoUser.Size = new System.Drawing.Size(196, 80);
            this.btn_GrantRoletoUser.TabIndex = 9;
            this.btn_GrantRoletoUser.Text = "GRANT ROLE TO USER";
            this.btn_GrantRoletoUser.UseVisualStyleBackColor = true;
            this.btn_GrantRoletoUser.Click += new System.EventHandler(this.btn_GrantRoletoUser_Click);
            // 
            // btn_MngUserPrivs
            // 
            this.btn_MngUserPrivs.Location = new System.Drawing.Point(108, 230);
            this.btn_MngUserPrivs.Name = "btn_MngUserPrivs";
            this.btn_MngUserPrivs.Size = new System.Drawing.Size(196, 80);
            this.btn_MngUserPrivs.TabIndex = 10;
            this.btn_MngUserPrivs.Text = "MANAGEMNET USER PRIVS";
            this.btn_MngUserPrivs.UseVisualStyleBackColor = true;
            this.btn_MngUserPrivs.Click += new System.EventHandler(this.btn_MngUserPrivs_Click);
            // 
            // btn_MngRolePrivs
            // 
            this.btn_MngRolePrivs.Location = new System.Drawing.Point(511, 230);
            this.btn_MngRolePrivs.Name = "btn_MngRolePrivs";
            this.btn_MngRolePrivs.Size = new System.Drawing.Size(196, 80);
            this.btn_MngRolePrivs.TabIndex = 11;
            this.btn_MngRolePrivs.Text = "MANAGEMNET ROLE PRIVS";
            this.btn_MngRolePrivs.UseVisualStyleBackColor = true;
            this.btn_MngRolePrivs.Click += new System.EventHandler(this.btn_MngRolePrivs_Click);
            // 
            // QUANTRI_CONSOLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_MngRolePrivs);
            this.Controls.Add(this.btn_MngUserPrivs);
            this.Controls.Add(this.btn_GrantRoletoUser);
            this.Controls.Add(this.btn_MngRoles);
            this.Controls.Add(this.btn_MngUsers);
            this.Controls.Add(this.label1);
            this.Name = "QUANTRI_CONSOLE";
            this.Text = "QUANTRI_CONSOLE";
            this.Load += new System.EventHandler(this.QUANTRI_CONSOLE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_MngUsers;
        private System.Windows.Forms.Button btn_MngRoles;
        private System.Windows.Forms.Button btn_GrantRoletoUser;
        private System.Windows.Forms.Button btn_MngUserPrivs;
        private System.Windows.Forms.Button btn_MngRolePrivs;
    }
}