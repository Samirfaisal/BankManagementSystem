
namespace BankManagementSystem.App
{
    partial class UserControlCustomer
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
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.Cus_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cus_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cus_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cus_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cus_PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 241);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvCustomer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1137, 383);
            this.panel2.TabIndex = 1;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cus_Id,
            this.Cus_Password,
            this.Account_No,
            this.Account_Name,
            this.AccountCreateDate,
            this.Cus_Address,
            this.Cus_Email,
            this.Cus_PhoneNo,
            this.Balance,
            this.Role});
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 29;
            this.dgvCustomer.Size = new System.Drawing.Size(1137, 383);
            this.dgvCustomer.TabIndex = 0;
            // 
            // Cus_Id
            // 
            this.Cus_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cus_Id.DataPropertyName = "Cus_Id";
            this.Cus_Id.HeaderText = "Id";
            this.Cus_Id.MinimumWidth = 6;
            this.Cus_Id.Name = "Cus_Id";
            this.Cus_Id.ReadOnly = true;
            // 
            // Cus_Password
            // 
            this.Cus_Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cus_Password.DataPropertyName = "Cus_Password";
            this.Cus_Password.HeaderText = "Password";
            this.Cus_Password.MinimumWidth = 6;
            this.Cus_Password.Name = "Cus_Password";
            this.Cus_Password.ReadOnly = true;
            // 
            // Account_No
            // 
            this.Account_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Account_No.DataPropertyName = "Account_No";
            this.Account_No.HeaderText = "Account No";
            this.Account_No.MinimumWidth = 6;
            this.Account_No.Name = "Account_No";
            this.Account_No.ReadOnly = true;
            // 
            // Account_Name
            // 
            this.Account_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Account_Name.DataPropertyName = "Account_Name";
            this.Account_Name.HeaderText = "Account Name";
            this.Account_Name.MinimumWidth = 6;
            this.Account_Name.Name = "Account_Name";
            this.Account_Name.ReadOnly = true;
            // 
            // AccountCreateDate
            // 
            this.AccountCreateDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AccountCreateDate.DataPropertyName = "AccountCreateDate";
            this.AccountCreateDate.HeaderText = "Create Date";
            this.AccountCreateDate.MinimumWidth = 6;
            this.AccountCreateDate.Name = "AccountCreateDate";
            this.AccountCreateDate.ReadOnly = true;
            // 
            // Cus_Address
            // 
            this.Cus_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cus_Address.DataPropertyName = "Cus_Address";
            this.Cus_Address.HeaderText = "Address";
            this.Cus_Address.MinimumWidth = 6;
            this.Cus_Address.Name = "Cus_Address";
            this.Cus_Address.ReadOnly = true;
            // 
            // Cus_Email
            // 
            this.Cus_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cus_Email.DataPropertyName = "Cus_Email";
            this.Cus_Email.HeaderText = "Email";
            this.Cus_Email.MinimumWidth = 6;
            this.Cus_Email.Name = "Cus_Email";
            this.Cus_Email.ReadOnly = true;
            // 
            // Cus_PhoneNo
            // 
            this.Cus_PhoneNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cus_PhoneNo.DataPropertyName = "Cus_PhoneNo";
            this.Cus_PhoneNo.HeaderText = "Phone No";
            this.Cus_PhoneNo.MinimumWidth = 6;
            this.Cus_PhoneNo.Name = "Cus_PhoneNo";
            this.Cus_PhoneNo.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Balance.DataPropertyName = "Balance";
            this.Balance.HeaderText = "Balance";
            this.Balance.MinimumWidth = 6;
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
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
            // UserControlCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlCustomer";
            this.Size = new System.Drawing.Size(1137, 624);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cus_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cus_Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cus_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cus_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cus_PhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
    }
}
