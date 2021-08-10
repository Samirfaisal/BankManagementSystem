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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            pnlSubMenuCus.Visible = false;
            pnlSubMenuEmp.Visible = false;
            pnlSubMenuTransaction.Visible = false;
        }

        private void hideSubMenu()
        {
            if (pnlSubMenuCus.Visible == true)
                pnlSubMenuCus.Visible = false;
            if (pnlSubMenuEmp.Visible == true)
                pnlSubMenuEmp.Visible = false;
            if (pnlSubMenuTransaction.Visible == true)
                pnlSubMenuTransaction.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuEmp);
        }

        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            //codes..

            hideSubMenu();
        }

        private void btnRemoveEmp_Click(object sender, EventArgs e)
        {
            //codes..

            hideSubMenu();

        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            //codes..

            hideSubMenu();
        }

        private void btnShowAllEmp_Click(object sender, EventArgs e)
        {
            //codes..

            hideSubMenu();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuCus);
        }

        private void btnSearchCus_Click(object sender, EventArgs e)
        {
            //codes..

            hideSubMenu();
        }

        private void btnRemoveCus_Click(object sender, EventArgs e)
        {
            //codes..

            hideSubMenu();
        }

        private void btnUpdateCus_Click(object sender, EventArgs e)
        {
            //codes..

            hideSubMenu();
        }

        private void btnShowAllCus_Click(object sender, EventArgs e)
        {
            //codes..

            hideSubMenu();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuTransaction);
        }

        private void btnTransactionToday_Click(object sender, EventArgs e)
        {
            //codes..

            hideSubMenu();
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            //codes..

            hideSubMenu();
        }

        private void btnTransactionShowAll_Click(object sender, EventArgs e)
        {
            //codes..

            hideSubMenu();
        }
    }
}