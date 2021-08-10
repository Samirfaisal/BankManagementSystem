
namespace BankManagementSystem.App
{
    partial class Manager
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
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.pnlSubMenuTransaction = new System.Windows.Forms.Panel();
            this.btnTransactionShowAll = new System.Windows.Forms.Button();
            this.btnTransactionHistory = new System.Windows.Forms.Button();
            this.btnTransactionToday = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.pnlSubMenuCus = new System.Windows.Forms.Panel();
            this.btnShowAllCus = new System.Windows.Forms.Button();
            this.btnUpdateCus = new System.Windows.Forms.Button();
            this.btnRemoveCus = new System.Windows.Forms.Button();
            this.btnSearchCus = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.pnlSubMenuEmp = new System.Windows.Forms.Panel();
            this.btnShowAllEmp = new System.Windows.Forms.Button();
            this.btnUpdateEmp = new System.Windows.Forms.Button();
            this.btnRemoveEmp = new System.Windows.Forms.Button();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSideMenu.SuspendLayout();
            this.pnlSubMenuTransaction.SuspendLayout();
            this.pnlSubMenuCus.SuspendLayout();
            this.pnlSubMenuEmp.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.AutoScroll = true;
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.pnlSideMenu.Controls.Add(this.pnlSubMenuTransaction);
            this.pnlSideMenu.Controls.Add(this.btnTransaction);
            this.pnlSideMenu.Controls.Add(this.pnlSubMenuCus);
            this.pnlSideMenu.Controls.Add(this.btnCustomer);
            this.pnlSideMenu.Controls.Add(this.pnlSubMenuEmp);
            this.pnlSideMenu.Controls.Add(this.btnEmployee);
            this.pnlSideMenu.Controls.Add(this.pnlLogo);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(262, 670);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // pnlSubMenuTransaction
            // 
            this.pnlSubMenuTransaction.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSubMenuTransaction.Controls.Add(this.btnTransactionShowAll);
            this.pnlSubMenuTransaction.Controls.Add(this.btnTransactionHistory);
            this.pnlSubMenuTransaction.Controls.Add(this.btnTransactionToday);
            this.pnlSubMenuTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuTransaction.Location = new System.Drawing.Point(0, 733);
            this.pnlSubMenuTransaction.Name = "pnlSubMenuTransaction";
            this.pnlSubMenuTransaction.Size = new System.Drawing.Size(241, 158);
            this.pnlSubMenuTransaction.TabIndex = 6;
            // 
            // btnTransactionShowAll
            // 
            this.btnTransactionShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(176)))), ((int)(((byte)(213)))));
            this.btnTransactionShowAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactionShowAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btnTransactionShowAll.FlatAppearance.BorderSize = 5;
            this.btnTransactionShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionShowAll.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransactionShowAll.Location = new System.Drawing.Point(0, 104);
            this.btnTransactionShowAll.Name = "btnTransactionShowAll";
            this.btnTransactionShowAll.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnTransactionShowAll.Size = new System.Drawing.Size(241, 54);
            this.btnTransactionShowAll.TabIndex = 3;
            this.btnTransactionShowAll.Text = "Show All";
            this.btnTransactionShowAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactionShowAll.UseVisualStyleBackColor = false;
            this.btnTransactionShowAll.Click += new System.EventHandler(this.btnTransactionShowAll_Click);
            // 
            // btnTransactionHistory
            // 
            this.btnTransactionHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(176)))), ((int)(((byte)(213)))));
            this.btnTransactionHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactionHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btnTransactionHistory.FlatAppearance.BorderSize = 5;
            this.btnTransactionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionHistory.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransactionHistory.Location = new System.Drawing.Point(0, 52);
            this.btnTransactionHistory.Name = "btnTransactionHistory";
            this.btnTransactionHistory.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnTransactionHistory.Size = new System.Drawing.Size(241, 52);
            this.btnTransactionHistory.TabIndex = 1;
            this.btnTransactionHistory.Text = "History";
            this.btnTransactionHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactionHistory.UseVisualStyleBackColor = false;
            this.btnTransactionHistory.Click += new System.EventHandler(this.btnTransactionHistory_Click);
            // 
            // btnTransactionToday
            // 
            this.btnTransactionToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(176)))), ((int)(((byte)(213)))));
            this.btnTransactionToday.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactionToday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btnTransactionToday.FlatAppearance.BorderSize = 5;
            this.btnTransactionToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionToday.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransactionToday.Location = new System.Drawing.Point(0, 0);
            this.btnTransactionToday.Name = "btnTransactionToday";
            this.btnTransactionToday.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnTransactionToday.Size = new System.Drawing.Size(241, 52);
            this.btnTransactionToday.TabIndex = 0;
            this.btnTransactionToday.Text = "Today\'s";
            this.btnTransactionToday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactionToday.UseVisualStyleBackColor = false;
            this.btnTransactionToday.Click += new System.EventHandler(this.btnTransactionToday_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btnTransaction.FlatAppearance.BorderSize = 2;
            this.btnTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransaction.ForeColor = System.Drawing.Color.White;
            this.btnTransaction.Location = new System.Drawing.Point(0, 677);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTransaction.Size = new System.Drawing.Size(241, 56);
            this.btnTransaction.TabIndex = 5;
            this.btnTransaction.Text = "Transations";
            this.btnTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // pnlSubMenuCus
            // 
            this.pnlSubMenuCus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSubMenuCus.Controls.Add(this.btnShowAllCus);
            this.pnlSubMenuCus.Controls.Add(this.btnUpdateCus);
            this.pnlSubMenuCus.Controls.Add(this.btnRemoveCus);
            this.pnlSubMenuCus.Controls.Add(this.btnSearchCus);
            this.pnlSubMenuCus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuCus.Location = new System.Drawing.Point(0, 467);
            this.pnlSubMenuCus.Name = "pnlSubMenuCus";
            this.pnlSubMenuCus.Size = new System.Drawing.Size(241, 210);
            this.pnlSubMenuCus.TabIndex = 4;
            // 
            // btnShowAllCus
            // 
            this.btnShowAllCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(176)))), ((int)(((byte)(213)))));
            this.btnShowAllCus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowAllCus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btnShowAllCus.FlatAppearance.BorderSize = 5;
            this.btnShowAllCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllCus.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowAllCus.Location = new System.Drawing.Point(0, 156);
            this.btnShowAllCus.Name = "btnShowAllCus";
            this.btnShowAllCus.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnShowAllCus.Size = new System.Drawing.Size(241, 52);
            this.btnShowAllCus.TabIndex = 3;
            this.btnShowAllCus.Text = "Show All";
            this.btnShowAllCus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAllCus.UseVisualStyleBackColor = false;
            this.btnShowAllCus.Click += new System.EventHandler(this.btnShowAllCus_Click);
            // 
            // btnUpdateCus
            // 
            this.btnUpdateCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(176)))), ((int)(((byte)(213)))));
            this.btnUpdateCus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateCus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btnUpdateCus.FlatAppearance.BorderSize = 5;
            this.btnUpdateCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCus.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateCus.Location = new System.Drawing.Point(0, 104);
            this.btnUpdateCus.Name = "btnUpdateCus";
            this.btnUpdateCus.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnUpdateCus.Size = new System.Drawing.Size(241, 52);
            this.btnUpdateCus.TabIndex = 2;
            this.btnUpdateCus.Text = "Update";
            this.btnUpdateCus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCus.UseVisualStyleBackColor = false;
            this.btnUpdateCus.Click += new System.EventHandler(this.btnUpdateCus_Click);
            // 
            // btnRemoveCus
            // 
            this.btnRemoveCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(176)))), ((int)(((byte)(213)))));
            this.btnRemoveCus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemoveCus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btnRemoveCus.FlatAppearance.BorderSize = 5;
            this.btnRemoveCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCus.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveCus.Location = new System.Drawing.Point(0, 52);
            this.btnRemoveCus.Name = "btnRemoveCus";
            this.btnRemoveCus.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnRemoveCus.Size = new System.Drawing.Size(241, 52);
            this.btnRemoveCus.TabIndex = 1;
            this.btnRemoveCus.Text = "Remove";
            this.btnRemoveCus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveCus.UseVisualStyleBackColor = false;
            this.btnRemoveCus.Click += new System.EventHandler(this.btnRemoveCus_Click);
            // 
            // btnSearchCus
            // 
            this.btnSearchCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(176)))), ((int)(((byte)(213)))));
            this.btnSearchCus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchCus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btnSearchCus.FlatAppearance.BorderSize = 5;
            this.btnSearchCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCus.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchCus.Location = new System.Drawing.Point(0, 0);
            this.btnSearchCus.Name = "btnSearchCus";
            this.btnSearchCus.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSearchCus.Size = new System.Drawing.Size(241, 52);
            this.btnSearchCus.TabIndex = 0;
            this.btnSearchCus.Text = "Search";
            this.btnSearchCus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCus.UseVisualStyleBackColor = false;
            this.btnSearchCus.Click += new System.EventHandler(this.btnSearchCus_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btnCustomer.FlatAppearance.BorderSize = 2;
            this.btnCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Location = new System.Drawing.Point(0, 407);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(241, 60);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // pnlSubMenuEmp
            // 
            this.pnlSubMenuEmp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSubMenuEmp.Controls.Add(this.btnShowAllEmp);
            this.pnlSubMenuEmp.Controls.Add(this.btnUpdateEmp);
            this.pnlSubMenuEmp.Controls.Add(this.btnRemoveEmp);
            this.pnlSubMenuEmp.Controls.Add(this.btnSearchEmp);
            this.pnlSubMenuEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuEmp.Location = new System.Drawing.Point(0, 195);
            this.pnlSubMenuEmp.Name = "pnlSubMenuEmp";
            this.pnlSubMenuEmp.Size = new System.Drawing.Size(241, 212);
            this.pnlSubMenuEmp.TabIndex = 2;
            // 
            // btnShowAllEmp
            // 
            this.btnShowAllEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(176)))), ((int)(((byte)(213)))));
            this.btnShowAllEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowAllEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btnShowAllEmp.FlatAppearance.BorderSize = 5;
            this.btnShowAllEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllEmp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowAllEmp.Location = new System.Drawing.Point(0, 156);
            this.btnShowAllEmp.Name = "btnShowAllEmp";
            this.btnShowAllEmp.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnShowAllEmp.Size = new System.Drawing.Size(241, 52);
            this.btnShowAllEmp.TabIndex = 3;
            this.btnShowAllEmp.Text = "Show All";
            this.btnShowAllEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAllEmp.UseVisualStyleBackColor = false;
            this.btnShowAllEmp.Click += new System.EventHandler(this.btnShowAllEmp_Click);
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(176)))), ((int)(((byte)(213)))));
            this.btnUpdateEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btnUpdateEmp.FlatAppearance.BorderSize = 5;
            this.btnUpdateEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEmp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateEmp.Location = new System.Drawing.Point(0, 104);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnUpdateEmp.Size = new System.Drawing.Size(241, 52);
            this.btnUpdateEmp.TabIndex = 2;
            this.btnUpdateEmp.Text = "Update";
            this.btnUpdateEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateEmp.UseVisualStyleBackColor = false;
            this.btnUpdateEmp.Click += new System.EventHandler(this.btnUpdateEmp_Click);
            // 
            // btnRemoveEmp
            // 
            this.btnRemoveEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(176)))), ((int)(((byte)(213)))));
            this.btnRemoveEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemoveEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btnRemoveEmp.FlatAppearance.BorderSize = 5;
            this.btnRemoveEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveEmp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveEmp.Location = new System.Drawing.Point(0, 52);
            this.btnRemoveEmp.Name = "btnRemoveEmp";
            this.btnRemoveEmp.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnRemoveEmp.Size = new System.Drawing.Size(241, 52);
            this.btnRemoveEmp.TabIndex = 1;
            this.btnRemoveEmp.Text = "Remove";
            this.btnRemoveEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveEmp.UseVisualStyleBackColor = false;
            this.btnRemoveEmp.Click += new System.EventHandler(this.btnRemoveEmp_Click);
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(176)))), ((int)(((byte)(213)))));
            this.btnSearchEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btnSearchEmp.FlatAppearance.BorderSize = 5;
            this.btnSearchEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchEmp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchEmp.ForeColor = System.Drawing.Color.Black;
            this.btnSearchEmp.Location = new System.Drawing.Point(0, 0);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSearchEmp.Size = new System.Drawing.Size(241, 52);
            this.btnSearchEmp.TabIndex = 0;
            this.btnSearchEmp.Text = "Search";
            this.btnSearchEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchEmp.UseVisualStyleBackColor = false;
            this.btnSearchEmp.Click += new System.EventHandler(this.btnSearchEmp_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btnEmployee.FlatAppearance.BorderSize = 2;
            this.btnEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Location = new System.Drawing.Point(0, 134);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(241, 61);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Gray;
            this.pnlLogo.Controls.Add(this.label1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Padding = new System.Windows.Forms.Padding(5);
            this.pnlLogo.Size = new System.Drawing.Size(241, 134);
            this.pnlLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "LoGo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(262, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 67);
            this.panel1.TabIndex = 1;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1295, 670);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSideMenu);
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlSubMenuTransaction.ResumeLayout(false);
            this.pnlSubMenuCus.ResumeLayout(false);
            this.pnlSubMenuEmp.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Panel pnlSubMenuEmp;
        private System.Windows.Forms.Button btnSearchEmp;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnShowAllEmp;
        private System.Windows.Forms.Button btnUpdateEmp;
        private System.Windows.Forms.Button btnRemoveEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSubMenuTransaction;
        private System.Windows.Forms.Button btnTransactionShowAll;
        private System.Windows.Forms.Button btnTransactionHistory;
        private System.Windows.Forms.Button btnTransactionToday;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Panel pnlSubMenuCus;
        private System.Windows.Forms.Button btnShowAllCus;
        private System.Windows.Forms.Button btnUpdateCus;
        private System.Windows.Forms.Button btnRemoveCus;
        private System.Windows.Forms.Button btnSearchCus;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Panel panel1;
    }
}