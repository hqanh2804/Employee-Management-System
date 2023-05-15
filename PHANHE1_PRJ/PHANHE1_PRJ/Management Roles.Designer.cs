namespace PHANHE1_PRJ
{
    partial class Management_Roles
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
            this.dtgv_ROLE = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.P_ROLENAME = new System.Windows.Forms.TextBox();
            this.P_PASSWORD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_CreateRole = new System.Windows.Forms.Button();
            this.btn_DropRole = new System.Windows.Forms.Button();
            this.btn_AlterRole = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ROLE)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_ROLE
            // 
            this.dtgv_ROLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ROLE.Location = new System.Drawing.Point(64, 67);
            this.dtgv_ROLE.Name = "dtgv_ROLE";
            this.dtgv_ROLE.RowHeadersWidth = 62;
            this.dtgv_ROLE.RowTemplate.Height = 28;
            this.dtgv_ROLE.Size = new System.Drawing.Size(240, 373);
            this.dtgv_ROLE.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "P_ROLENAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "P_PASSWORD";
            // 
            // P_ROLENAME
            // 
            this.P_ROLENAME.Location = new System.Drawing.Point(526, 87);
            this.P_ROLENAME.Name = "P_ROLENAME";
            this.P_ROLENAME.Size = new System.Drawing.Size(222, 26);
            this.P_ROLENAME.TabIndex = 3;
            // 
            // P_PASSWORD
            // 
            this.P_PASSWORD.Location = new System.Drawing.Point(526, 149);
            this.P_PASSWORD.Name = "P_PASSWORD";
            this.P_PASSWORD.Size = new System.Drawing.Size(222, 26);
            this.P_PASSWORD.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cyan;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "MANAGEMENT ROLE";
            // 
            // btn_CreateRole
            // 
            this.btn_CreateRole.Location = new System.Drawing.Point(526, 217);
            this.btn_CreateRole.Name = "btn_CreateRole";
            this.btn_CreateRole.Size = new System.Drawing.Size(222, 50);
            this.btn_CreateRole.TabIndex = 6;
            this.btn_CreateRole.Text = "CREATE ROLE";
            this.btn_CreateRole.UseVisualStyleBackColor = true;
            this.btn_CreateRole.Click += new System.EventHandler(this.btn_CreateRole_Click);
            // 
            // btn_DropRole
            // 
            this.btn_DropRole.Location = new System.Drawing.Point(526, 305);
            this.btn_DropRole.Name = "btn_DropRole";
            this.btn_DropRole.Size = new System.Drawing.Size(222, 50);
            this.btn_DropRole.TabIndex = 7;
            this.btn_DropRole.Text = "DROP ROLE";
            this.btn_DropRole.UseVisualStyleBackColor = true;
            this.btn_DropRole.Click += new System.EventHandler(this.btn_DropRole_Click);
            // 
            // btn_AlterRole
            // 
            this.btn_AlterRole.Location = new System.Drawing.Point(526, 379);
            this.btn_AlterRole.Name = "btn_AlterRole";
            this.btn_AlterRole.Size = new System.Drawing.Size(222, 50);
            this.btn_AlterRole.TabIndex = 8;
            this.btn_AlterRole.Text = "ALTER ROLE";
            this.btn_AlterRole.UseVisualStyleBackColor = true;
            this.btn_AlterRole.Click += new System.EventHandler(this.btn_AlterRole_Click);
            // 
            // Management_Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 452);
            this.Controls.Add(this.btn_AlterRole);
            this.Controls.Add(this.btn_DropRole);
            this.Controls.Add(this.btn_CreateRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.P_PASSWORD);
            this.Controls.Add(this.P_ROLENAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv_ROLE);
            this.Name = "Management_Roles";
            this.Text = "Management_Roles";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ROLE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_ROLE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox P_ROLENAME;
        private System.Windows.Forms.TextBox P_PASSWORD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_CreateRole;
        private System.Windows.Forms.Button btn_DropRole;
        private System.Windows.Forms.Button btn_AlterRole;
    }
}