namespace PHANHE1_PRJ
{
    partial class Management_Users
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.P_USERNAME = new System.Windows.Forms.TextBox();
            this.P_PASSWORD = new System.Windows.Forms.TextBox();
            this.btn_CREATEUSER = new System.Windows.Forms.Button();
            this.btn_DROPUSER = new System.Windows.Forms.Button();
            this.btn_ALTERUSER = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGEMENT USER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(240, 352);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(485, 163);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(101, 20);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "USERNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "PASSWORD";
            // 
            // P_USERNAME
            // 
            this.P_USERNAME.Location = new System.Drawing.Point(634, 157);
            this.P_USERNAME.Name = "P_USERNAME";
            this.P_USERNAME.Size = new System.Drawing.Size(187, 26);
            this.P_USERNAME.TabIndex = 4;
            // 
            // P_PASSWORD
            // 
            this.P_PASSWORD.Location = new System.Drawing.Point(634, 225);
            this.P_PASSWORD.Name = "P_PASSWORD";
            this.P_PASSWORD.Size = new System.Drawing.Size(187, 26);
            this.P_PASSWORD.TabIndex = 5;
            // 
            // btn_CREATEUSER
            // 
            this.btn_CREATEUSER.Location = new System.Drawing.Point(634, 298);
            this.btn_CREATEUSER.Name = "btn_CREATEUSER";
            this.btn_CREATEUSER.Size = new System.Drawing.Size(187, 41);
            this.btn_CREATEUSER.TabIndex = 6;
            this.btn_CREATEUSER.Text = "CREATE USER";
            this.btn_CREATEUSER.UseVisualStyleBackColor = true;
            this.btn_CREATEUSER.Click += new System.EventHandler(this.btn_CREATEUSER_Click);
            // 
            // btn_DROPUSER
            // 
            this.btn_DROPUSER.Location = new System.Drawing.Point(634, 366);
            this.btn_DROPUSER.Name = "btn_DROPUSER";
            this.btn_DROPUSER.Size = new System.Drawing.Size(187, 41);
            this.btn_DROPUSER.TabIndex = 7;
            this.btn_DROPUSER.Text = "DROP USER";
            this.btn_DROPUSER.UseVisualStyleBackColor = true;
            this.btn_DROPUSER.Click += new System.EventHandler(this.btn_DROPUSER_Click);
            // 
            // btn_ALTERUSER
            // 
            this.btn_ALTERUSER.Location = new System.Drawing.Point(634, 434);
            this.btn_ALTERUSER.Name = "btn_ALTERUSER";
            this.btn_ALTERUSER.Size = new System.Drawing.Size(187, 41);
            this.btn_ALTERUSER.TabIndex = 8;
            this.btn_ALTERUSER.Text = "ALTER USER";
            this.btn_ALTERUSER.UseVisualStyleBackColor = true;
            this.btn_ALTERUSER.Click += new System.EventHandler(this.btn_ALTERUSER_Click);
            // 
            // Management_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 524);
            this.Controls.Add(this.btn_ALTERUSER);
            this.Controls.Add(this.btn_DROPUSER);
            this.Controls.Add(this.btn_CREATEUSER);
            this.Controls.Add(this.P_PASSWORD);
            this.Controls.Add(this.P_USERNAME);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Management_Users";
            this.Text = "Management_Users";
            this.Load += new System.EventHandler(this.Management_Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox P_USERNAME;
        private System.Windows.Forms.TextBox P_PASSWORD;
        private System.Windows.Forms.Button btn_CREATEUSER;
        private System.Windows.Forms.Button btn_DROPUSER;
        private System.Windows.Forms.Button btn_ALTERUSER;
    }
}