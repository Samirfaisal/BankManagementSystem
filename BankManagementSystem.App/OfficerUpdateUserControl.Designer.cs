
namespace BankManagementSystem.App
{
    partial class OfficerUpdateUserControl
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
            this.dgvUpdateOfficer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchForUpdateOfficer = new System.Windows.Forms.TextBox();
            this.dtpUpdateOfficer = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdateOfficerPhoneNo = new System.Windows.Forms.TextBox();
            this.txtUpdateOfficerAccountNo = new System.Windows.Forms.TextBox();
            this.txtUpdateOfficerRole = new System.Windows.Forms.TextBox();
            this.txtUpdateOfficerAddress = new System.Windows.Forms.TextBox();
            this.txtUpdateOfficerAccountName = new System.Windows.Forms.TextBox();
            this.txtUpdateOfficerPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUpdateOfficerId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOfficerUpdate = new System.Windows.Forms.DataGridView();
            this.O_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.O_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUpdateOfficer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfficerUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUpdateOfficer
            // 
            this.dgvUpdateOfficer.Controls.Add(this.dgvOfficerUpdate);
            this.dgvUpdateOfficer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUpdateOfficer.Location = new System.Drawing.Point(0, 245);
            this.dgvUpdateOfficer.Name = "dgvUpdateOfficer";
            this.dgvUpdateOfficer.Size = new System.Drawing.Size(1071, 281);
            this.dgvUpdateOfficer.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtSearchForUpdateOfficer);
            this.panel2.Controls.Add(this.dtpUpdateOfficer);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.txtUpdateOfficerPhoneNo);
            this.panel2.Controls.Add(this.txtUpdateOfficerAccountNo);
            this.panel2.Controls.Add(this.txtUpdateOfficerRole);
            this.panel2.Controls.Add(this.txtUpdateOfficerAddress);
            this.panel2.Controls.Add(this.txtUpdateOfficerAccountName);
            this.panel2.Controls.Add(this.txtUpdateOfficerPassword);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtUpdateOfficerId);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 245);
            this.panel2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(492, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Search by Account No";
            // 
            // txtSearchForUpdateOfficer
            // 
            this.txtSearchForUpdateOfficer.Location = new System.Drawing.Point(342, 208);
            this.txtSearchForUpdateOfficer.Name = "txtSearchForUpdateOfficer";
            this.txtSearchForUpdateOfficer.Size = new System.Drawing.Size(125, 27);
            this.txtSearchForUpdateOfficer.TabIndex = 21;
            // 
            // dtpUpdateOfficer
            // 
            this.dtpUpdateOfficer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUpdateOfficer.Location = new System.Drawing.Point(533, 81);
            this.dtpUpdateOfficer.Name = "dtpUpdateOfficer";
            this.dtpUpdateOfficer.Size = new System.Drawing.Size(125, 27);
            this.dtpUpdateOfficer.TabIndex = 20;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(858, 148);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 46);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdateOfficerPhoneNo
            // 
            this.txtUpdateOfficerPhoneNo.Location = new System.Drawing.Point(533, 151);
            this.txtUpdateOfficerPhoneNo.Name = "txtUpdateOfficerPhoneNo";
            this.txtUpdateOfficerPhoneNo.Size = new System.Drawing.Size(125, 27);
            this.txtUpdateOfficerPhoneNo.TabIndex = 17;
            // 
            // txtUpdateOfficerAccountNo
            // 
            this.txtUpdateOfficerAccountNo.Location = new System.Drawing.Point(224, 151);
            this.txtUpdateOfficerAccountNo.Name = "txtUpdateOfficerAccountNo";
            this.txtUpdateOfficerAccountNo.Size = new System.Drawing.Size(125, 27);
            this.txtUpdateOfficerAccountNo.TabIndex = 16;
            // 
            // txtUpdateOfficerRole
            // 
            this.txtUpdateOfficerRole.Location = new System.Drawing.Point(858, 89);
            this.txtUpdateOfficerRole.Name = "txtUpdateOfficerRole";
            this.txtUpdateOfficerRole.Size = new System.Drawing.Size(125, 27);
            this.txtUpdateOfficerRole.TabIndex = 15;
            // 
            // txtUpdateOfficerAddress
            // 
            this.txtUpdateOfficerAddress.Location = new System.Drawing.Point(858, 26);
            this.txtUpdateOfficerAddress.Name = "txtUpdateOfficerAddress";
            this.txtUpdateOfficerAddress.Size = new System.Drawing.Size(125, 27);
            this.txtUpdateOfficerAddress.TabIndex = 13;
            // 
            // txtUpdateOfficerAccountName
            // 
            this.txtUpdateOfficerAccountName.Location = new System.Drawing.Point(533, 23);
            this.txtUpdateOfficerAccountName.Name = "txtUpdateOfficerAccountName";
            this.txtUpdateOfficerAccountName.Size = new System.Drawing.Size(125, 27);
            this.txtUpdateOfficerAccountName.TabIndex = 12;
            // 
            // txtUpdateOfficerPassword
            // 
            this.txtUpdateOfficerPassword.Location = new System.Drawing.Point(224, 86);
            this.txtUpdateOfficerPassword.Name = "txtUpdateOfficerPassword";
            this.txtUpdateOfficerPassword.Size = new System.Drawing.Size(125, 27);
            this.txtUpdateOfficerPassword.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Phone No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(800, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Role";
            // 
            // txtUpdateOfficerId
            // 
            this.txtUpdateOfficerId.Location = new System.Drawing.Point(224, 23);
            this.txtUpdateOfficerId.Name = "txtUpdateOfficerId";
            this.txtUpdateOfficerId.Size = new System.Drawing.Size(125, 27);
            this.txtUpdateOfficerId.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Create Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(777, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Account No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Account Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "O_Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "O_Id";
            // 
            // dgvOfficerUpdate
            // 
            this.dgvOfficerUpdate.AllowUserToAddRows = false;
            this.dgvOfficerUpdate.AllowUserToDeleteRows = false;
            this.dgvOfficerUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOfficerUpdate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.O_Id,
            this.O_Password,
            this.Account_No,
            this.Account_Name,
            this.AccountCreateDate,
            this.C_PhoneNo,
            this.C_Address,
            this.Role});
            this.dgvOfficerUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOfficerUpdate.Location = new System.Drawing.Point(0, 0);
            this.dgvOfficerUpdate.Name = "dgvOfficerUpdate";
            this.dgvOfficerUpdate.ReadOnly = true;
            this.dgvOfficerUpdate.RowHeadersWidth = 51;
            this.dgvOfficerUpdate.RowTemplate.Height = 29;
            this.dgvOfficerUpdate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOfficerUpdate.Size = new System.Drawing.Size(1071, 281);
            this.dgvOfficerUpdate.TabIndex = 0;
            this.dgvOfficerUpdate.DoubleClick += new System.EventHandler(this.dgvOfficerUpdate_DoubleClick);
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
            this.Account_Name.DataPropertyName = "Account_Name)";
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
            // OfficerUpdateUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvUpdateOfficer);
            this.Name = "OfficerUpdateUserControl";
            this.Size = new System.Drawing.Size(1071, 526);
            this.dgvUpdateOfficer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfficerUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dgvUpdateOfficer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchForUpdateOfficer;
        private System.Windows.Forms.DateTimePicker dtpUpdateOfficer;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdateOfficerPhoneNo;
        private System.Windows.Forms.TextBox txtUpdateOfficerAccountNo;
        private System.Windows.Forms.TextBox txtUpdateOfficerRole;
        private System.Windows.Forms.TextBox txtUpdateOfficerAddress;
        private System.Windows.Forms.TextBox txtUpdateOfficerAccountName;
        private System.Windows.Forms.TextBox txtUpdateOfficerPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUpdateOfficerId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOfficerUpdate;
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
