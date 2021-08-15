
namespace BankManagementSystem.App
{
    partial class GeneralOfficer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchOfficer = new System.Windows.Forms.Button();
            this.btnDeleteOfficer = new System.Windows.Forms.Button();
            this.btnUpdateOfficer = new System.Windows.Forms.Button();
            this.btnInsertOfficer = new System.Windows.Forms.Button();
            this.panelGrideView = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 135);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(547, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "General Officer";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btnSearchOfficer);
            this.panel2.Controls.Add(this.btnDeleteOfficer);
            this.panel2.Controls.Add(this.btnUpdateOfficer);
            this.panel2.Controls.Add(this.btnInsertOfficer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 525);
            this.panel2.TabIndex = 1;
            // 
            // btnSearchOfficer
            // 
            this.btnSearchOfficer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSearchOfficer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchOfficer.Location = new System.Drawing.Point(0, 349);
            this.btnSearchOfficer.Name = "btnSearchOfficer";
            this.btnSearchOfficer.Padding = new System.Windows.Forms.Padding(20, 8, 10, 10);
            this.btnSearchOfficer.Size = new System.Drawing.Size(262, 69);
            this.btnSearchOfficer.TabIndex = 0;
            this.btnSearchOfficer.Text = "Search";
            this.btnSearchOfficer.UseVisualStyleBackColor = false;
            this.btnSearchOfficer.Click += new System.EventHandler(this.btnSearchOfficer_Click);
            // 
            // btnDeleteOfficer
            // 
            this.btnDeleteOfficer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDeleteOfficer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteOfficer.Location = new System.Drawing.Point(0, 262);
            this.btnDeleteOfficer.Name = "btnDeleteOfficer";
            this.btnDeleteOfficer.Padding = new System.Windows.Forms.Padding(20, 8, 10, 10);
            this.btnDeleteOfficer.Size = new System.Drawing.Size(262, 69);
            this.btnDeleteOfficer.TabIndex = 0;
            this.btnDeleteOfficer.Text = "Remove";
            this.btnDeleteOfficer.UseVisualStyleBackColor = false;
            // 
            // btnUpdateOfficer
            // 
            this.btnUpdateOfficer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUpdateOfficer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateOfficer.Location = new System.Drawing.Point(0, 174);
            this.btnUpdateOfficer.Name = "btnUpdateOfficer";
            this.btnUpdateOfficer.Padding = new System.Windows.Forms.Padding(20, 8, 10, 10);
            this.btnUpdateOfficer.Size = new System.Drawing.Size(262, 69);
            this.btnUpdateOfficer.TabIndex = 0;
            this.btnUpdateOfficer.Text = "Update";
            this.btnUpdateOfficer.UseVisualStyleBackColor = false;
            this.btnUpdateOfficer.Click += new System.EventHandler(this.btnUpdateOfficer_Click);
            // 
            // btnInsertOfficer
            // 
            this.btnInsertOfficer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnInsertOfficer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInsertOfficer.Location = new System.Drawing.Point(0, 85);
            this.btnInsertOfficer.Name = "btnInsertOfficer";
            this.btnInsertOfficer.Padding = new System.Windows.Forms.Padding(20, 8, 10, 10);
            this.btnInsertOfficer.Size = new System.Drawing.Size(262, 69);
            this.btnInsertOfficer.TabIndex = 0;
            this.btnInsertOfficer.Text = "Insert";
            this.btnInsertOfficer.UseVisualStyleBackColor = false;
            this.btnInsertOfficer.Click += new System.EventHandler(this.btnInsertOfficer_Click);
            // 
            // panelGrideView
            // 
            this.panelGrideView.Location = new System.Drawing.Point(262, 134);
            this.panelGrideView.Name = "panelGrideView";
            this.panelGrideView.Size = new System.Drawing.Size(1071, 526);
            this.panelGrideView.TabIndex = 2;
            // 
            // GeneralOfficer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 660);
            this.Controls.Add(this.panelGrideView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GeneralOfficer";
            this.Text = "GeneralOfficer";
            this.Load += new System.EventHandler(this.GeneralOfficer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelGrideView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertOfficer;
        private System.Windows.Forms.Button btnSearchOfficer;
        private System.Windows.Forms.Button btnDeleteOfficer;
        private System.Windows.Forms.Button btnUpdateOfficer;
    }
}