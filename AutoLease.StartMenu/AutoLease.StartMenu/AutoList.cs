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
    public partial class AutoList : Form
    {
        public AutoList()
        {
            InitializeComponent();
        }

        bool flagCanAdd = false;

        public void setFlagCanAdd(bool flag)
        {
            flagCanAdd = flag;
        }

        private void AutoList_FormClosed(object sender, FormClosedEventArgs e)
        {
            StartMenu startmenu = new StartMenu();
            startmenu.Show();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            AutoCard autocard = new AutoCard();
           autocard.Show();
        }

        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!CategoryRadioButton.Checked && !IDRadioButton.Checked && !ModelRadioButton.Checked)
                e.Handled = true;
           else if(CategoryRadioButton.Checked)
            {
                if ((!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) ||
               (SearchTextBox.TextLength > 0 && char.IsUpper(e.KeyChar)))
                    e.Handled = true;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.TextLength == 0)
                MessageBox.Show("Введите данные для поиска", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void OpenAllButton_Click(object sender, EventArgs e)
        {
            CopyList copylist = new CopyList();
            copylist.Show();
        }
    }
}
