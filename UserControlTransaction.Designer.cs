
namespace BankManagementSystem.App
{
    partial class UserControlTransaction
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
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.Account_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deposite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Withdraw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaction_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 241);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvTransaction);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1139, 437);
            this.panel2.TabIndex = 2;
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.AllowUserToAddRows = false;
            this.dgvTransaction.AllowUserToDeleteRows = false;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Account_No,
            this.Deposite,
            this.Withdraw,
            this.Transaction_Time});
            this.dgvTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransaction.Location = new System.Drawing.Point(0, 0);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.ReadOnly = true;
            this.dgvTransaction.RowHeadersWidth = 51;
            this.dgvTransaction.RowTemplate.Height = 29;
            this.dgvTransaction.Size = new System.Drawing.Size(1139, 437);
            this.dgvTransaction.TabIndex = 0;
            // 
            // Account_No
            // 
            this.Account_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Account_No.DataPropertyName = "Account_No";
            this.Account_No.HeaderText = "Account No ";
            this.Account_No.MinimumWidth = 6;
            this.Account_No.Name = "Account_No";
            this.Account_No.ReadOnly = true;
            // 
            // Deposite
            // 
            this.Deposite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Deposite.DataPropertyName = "Deposite";
            this.Deposite.HeaderText = "Deposite";
            this.Deposite.MinimumWidth = 6;
            this.Deposite.Name = "Deposite";
            this.Deposite.ReadOnly = true;
            // 
            // Withdraw
            // 
            this.Withdraw.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Withdraw.DataPropertyName = "Withdraw";
            this.Withdraw.HeaderText = "Withdraw";
            this.Withdraw.MinimumWidth = 6;
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.ReadOnly = true;
            // 
            // Transaction_Time
            // 
            this.Transaction_Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Transaction_Time.DataPropertyName = "Transaction_Time";
            this.Transaction_Time.HeaderText = "Transaction Time";
            this.Transaction_Time.MinimumWidth = 6;
            this.Transaction_Time.Name = "Transaction_Time";
            this.Transaction_Time.ReadOnly = true;
            // 
            // UserControlTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlTransaction";
            this.Size = new System.Drawing.Size(1139, 678);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deposite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Withdraw;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_Time;
    }
}
