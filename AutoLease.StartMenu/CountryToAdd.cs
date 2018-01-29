using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoLeaseClass;
using AutoLeaseServeces;
using AutoLeaseStorage;

namespace AutoLease.StartMenu
{
    public partial class CountryToAdd : Form
    {
        public CountryToAdd()
        {
            InitializeComponent();
        }


        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (CountryTextBox.TextLength == 0)
                CountryTextBox.BackColor = Color.IndianRed;
            else if(AutoModelsListService.CheckCountry(CountryTextBox.Text))
            {
                MessageBox.Show("Такая страна уже есть в списке", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AutoListStorage.countryList.Add(CountryTextBox.Text);
                this.Close();
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CountryTextBox.BackColor == Color.IndianRed)
                CountryTextBox.BackColor = Color.White;
        }

        private void CountryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((CountryTextBox.TextLength == 0 && ((char.IsLower(e.KeyChar) && char.IsLetter(e.KeyChar)) || (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)))) ||
               (CountryTextBox.TextLength != 0 && !e.KeyChar.Equals('-') && !e.KeyChar.Equals(' ') && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)))
                e.Handled = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CountryToAdd_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
