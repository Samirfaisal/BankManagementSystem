using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem.App
{
    public partial class GeneralOfficer : Form
    {
        
        public GeneralOfficer()
        {
            InitializeComponent();
        }

        private void btnInsertOfficer_Click(object sender, EventArgs e)
        {
            OfficerInsertUserControl oiuc = new OfficerInsertUserControl();
            this.panelGrideView.Controls.Clear();
            this.panelGrideView.Controls.Add(oiuc);
        }

        private void GeneralOfficer_Load(object sender, EventArgs e)
        {
            MessageBox.Show("App Closed");
            Application.Exit();
        }

        private void btnUpdateOfficer_Click(object sender, EventArgs e)
        {
            OfficerUpdateUserControl ouuc = new OfficerUpdateUserControl();
            this.panelGrideView.Controls.Clear();
            this.panelGrideView.Controls.Add(ouuc);
        }

        private void btnSearchOfficer_Click(object sender, EventArgs e)
        {
            OfficerSearchUserControl uc1 = new OfficerSearchUserControl();
            this.panelGrideView.Controls.Clear();
            this.panelGrideView.Controls.Add(uc1);
        }
    }
}
