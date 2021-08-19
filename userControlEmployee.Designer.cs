
namespace BankManagementSystem.App
{
    partial class userControlEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Manager_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manager_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manager_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manager_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerJoiningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manager_PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manager_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1271, 241);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1271, 434);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Manager_Id,
            this.Manager_Password,
            this.Manager_Name,
            this.Salary,
            this.Manager_Address,
            this.ManagerJoiningDate,
            this.Manager_PhoneNo,
            this.Manager_Email,
            this.Role});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1271, 434);
            this.dataGridView1.TabIndex = 0;
            // 
            // Manager_Id
            // 
            this.Manager_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manager_Id.DataPropertyName = "Manager_Id";
            this.Manager_Id.HeaderText = "Id";
            this.Manager_Id.MinimumWidth = 6;
            this.Manager_Id.Name = "Manager_Id";
            this.Manager_Id.ReadOnly = true;
            // 
            // Manager_Password
            // 
            this.Manager_Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manager_Password.DataPropertyName = "Manager_Password";
            this.Manager_Password.HeaderText = "Password";
            this.Manager_Password.MinimumWidth = 6;
            this.Manager_Password.Name = "Manager_Password";
            this.Manager_Password.ReadOnly = true;
            // 
            // Manager_Name
            // 
            this.Manager_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manager_Name.DataPropertyName = "Manager_Name";
            this.Manager_Name.HeaderText = "Name";
            this.Manager_Name.MinimumWidth = 6;
            this.Manager_Name.Name = "Manager_Name";
            this.Manager_Name.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.MinimumWidth = 6;
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // Manager_Address
            // 
            this.Manager_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manager_Address.DataPropertyName = "Manager_Address";
            this.Manager_Address.HeaderText = "Address";
            this.Manager_Address.MinimumWidth = 6;
            this.Manager_Address.Name = "Manager_Address";
            this.Manager_Address.ReadOnly = true;
            // 
            // ManagerJoiningDate
            // 
            this.ManagerJoiningDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ManagerJoiningDate.DataPropertyName = "ManagerJoiningDate";
            this.ManagerJoiningDate.HeaderText = "Joining Date";
            this.ManagerJoiningDate.MinimumWidth = 6;
            this.ManagerJoiningDate.Name = "ManagerJoiningDate";
            this.ManagerJoiningDate.ReadOnly = true;
            // 
            // Manager_PhoneNo
            // 
            this.Manager_PhoneNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manager_PhoneNo.DataPropertyName = "Manager_PhoneNo";
            this.Manager_PhoneNo.HeaderText = "Phone No";
            this.Manager_PhoneNo.MinimumWidth = 6;
            this.Manager_PhoneNo.Name = "Manager_PhoneNo";
            this.Manager_PhoneNo.ReadOnly = true;
            // 
            // Manager_Email
            // 
            this.Manager_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manager_Email.DataPropertyName = "Manager_Email";
            this.Manager_Email.HeaderText = "Email";
            this.Manager_Email.MinimumWidth = 6;
            this.Manager_Email.Name = "Manager_Email";
            this.Manager_Email.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // userControlEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "userControlEmployee";
            this.Size = new System.Drawing.Size(1271, 675);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager_Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerJoiningDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager_PhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
    }
}
