
namespace BankManagementSystem.App
{
    partial class OfficerSearchUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchOfficer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSearchOfficer = new System.Windows.Forms.DataGridView();
            this.O_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.O_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchOfficer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSearchOfficer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 144);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSearchOfficer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 382);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by Account No";
            // 
            // txtSearchOfficer
            // 
            this.txtSearchOfficer.Location = new System.Drawing.Point(411, 94);
            this.txtSearchOfficer.Name = "txtSearchOfficer";
            this.txtSearchOfficer.Size = new System.Drawing.Size(107, 27);
            this.txtSearchOfficer.TabIndex = 1;
            this.txtSearchOfficer.TextChanged += new System.EventHandler(this.txtSearchOfficer_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(522, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search ";
            // 
            // dgvSearchOfficer
            // 
            this.dgvSearchOfficer.AllowUserToAddRows = false;
            this.dgvSearchOfficer.AllowUserToDeleteRows = false;
            this.dgvSearchOfficer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchOfficer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.O_Id,
            this.O_Password,
            this.Account_No,
            this.Account_Name,
            this.AccountCreateDate,
            this.C_PhoneNo,
            this.C_Address,
            this.Role});
            this.dgvSearchOfficer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSearchOfficer.Location = new System.Drawing.Point(0, 0);
            this.dgvSearchOfficer.Name = "dgvSearchOfficer";
            this.dgvSearchOfficer.ReadOnly = true;
            this.dgvSearchOfficer.RowHeadersWidth = 51;
            this.dgvSearchOfficer.RowTemplate.Height = 29;
            this.dgvSearchOfficer.Size = new System.Drawing.Size(1071, 382);
            this.dgvSearchOfficer.TabIndex = 0;
            // 
            // O_Id
            // 
            this.O_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.O_Id.DataPropertyName = "O_Id";
            this.O_Id.HeaderText = "Id";
            this.O_Id.MinimumWidth = 6;
            this.O_Id.Name = "O_Id";
            this.O_Id.ReadOnly = true;
            // 
            // O_Password
            // 
            this.O_Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.O_Password.DataPropertyName = "O_Password";
            this.O_Password.HeaderText = "Password";
            this.O_Password.MinimumWidth = 6;
            this.O_Password.Name = "O_Password";
            this.O_Password.ReadOnly = true;
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
            this.AccountCreateDate.DataPropertyName = "AccountCreateDate)";
            this.AccountCreateDate.HeaderText = "Create Date";
            this.AccountCreateDate.MinimumWidth = 6;
            this.AccountCreateDate.Name = "AccountCreateDate";
            this.AccountCreateDate.ReadOnly = true;
            // 
            // C_PhoneNo
            // 
            this.C_PhoneNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C_PhoneNo.DataPropertyName = "C_PhoneNo";
            this.C_PhoneNo.HeaderText = "Phone No";
            this.C_PhoneNo.MinimumWidth = 6;
            this.C_PhoneNo.Name = "C_PhoneNo";
            this.C_PhoneNo.ReadOnly = true;
            // 
            // C_Address
            // 
            this.C_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C_Address.DataPropertyName = "C_Address";
            this.C_Address.HeaderText = "Address";
            this.C_Address.MinimumWidth = 6;
            this.C_Address.Name = "C_Address";
            this.C_Address.ReadOnly = true;
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
            // OfficerSearchUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "OfficerSearchUserControl";
            this.Size = new System.Drawing.Size(1071, 526);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchOfficer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchOfficer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSearchOfficer;
        private System.Windows.Forms.DataGridViewTextBoxColumn O_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn O_Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_PhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
    }
}
