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
    public partial class AutoReturn : Form
    {
        public AutoReturn()
        {
            InitializeComponent();
        }

        private void ShowPrevious(object sender, FormClosedEventArgs e)
        {
            StartMenu startMenu = new StartMenu();
            startMenu.Show();
        }


        private void OpenButton_Click(object sender, EventArgs e)
        {
            ClientCardInfo clientcard = new ClientCardInfo();
            clientcard.setEnabledSum(true);
            clientcard.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (txtBoxSearch.Text == "")
            {
                MessageBox.Show("Введите данные для поиска", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!SurnameRadioButton.Checked && !IDRadioButton.Checked && !NameRadioButton.Checked)
                e.Handled = true;
            else if (SurnameRadioButton.Checked || NameRadioButton.Checked)
            {
                if ((!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) ||
                               (txtBoxSearch.TextLength == 0 && char.IsLower(e.KeyChar)) ||
                               (txtBoxSearch.TextLength > 0 && char.IsUpper(e.KeyChar)))
                    e.Handled = true;

            }
        }

        private void SurnameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SurnameRadioButton.Checked)
                txtBoxSearch.Clear();
        }

        private void IDRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            if (IDRadioButton.Checked)
                txtBoxSearch.Clear();
        }


        private void NameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NameRadioButton.Checked)
                txtBoxSearch.Clear();
        }
    }
}
