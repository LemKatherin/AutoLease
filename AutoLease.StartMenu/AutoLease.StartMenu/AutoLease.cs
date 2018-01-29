using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLease.StartMenu
{
    public partial class AutoLease : Form
    {
        public AutoLease()
        {
            InitializeComponent();
        }
        bool flagCanAdd = false;

        public void setFlagCanAdd(bool flag)
        {
            flagCanAdd = flag;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                MessageBox.Show("Введите данные для поиска", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ShowPrevious(object sender, FormClosedEventArgs e)
        {
            StartMenu startMenu = new StartMenu();
            startMenu.Show();
        }


        private void txtBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!CategoryRadioButton.Checked && !IDRadioButton.Checked && !ModelRadioButton.Checked)
                e.Handled = true;
            else if (CategoryRadioButton.Checked)
            {
                if ((!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) ||
               (SearchTextBox.TextLength > 0 && char.IsUpper(e.KeyChar)))
                    e.Handled = true;
            }
        }

        private void ModelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ModelRadioButton.Checked)
                SearchTextBox.Clear();
        }

        private void CategoryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CategoryRadioButton.Checked)
                SearchTextBox.Clear();
        }

        private void IDRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (IDRadioButton.Checked)
                SearchTextBox.Clear();
        }

        private void OpenInfoButton_Click(object sender, EventArgs e)
        {
            AutoCard autocard = new AutoCard();
            //autocard.setFlagCanAdd(flagCanAdd);
            autocard.Show();
        }

        private void OpenAllButton_Click(object sender, EventArgs e)
        {
            CopyList copylist = new CopyList();
            copylist.setEnabledAddButton(flagCanAdd);
            copylist.setflag(flagCanAdd);
            copylist.Show();
        }
    }
}
