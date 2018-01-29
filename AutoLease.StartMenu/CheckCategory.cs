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
    public partial class CheckCategory : Form
    { 
        bool flagwho = false;

        public CheckCategory()
        {
            InitializeComponent();
        }

        public CheckCategory(bool flag)
        {
            InitializeComponent();  
            flagwho = flag;
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.TextLength != 0)
            {
                if (AutoCategoryListService.Check(NameTextBox.Text))
                {
                    MessageBox.Show("Такая категория уже зарегестрировна", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
                else
                {
                    AutoCategoryRegistr autocategoryregistr = new AutoCategoryRegistr(this);
                    autocategoryregistr.setNameTextBox(NameTextBox);
                    autocategoryregistr.setflag(flagwho);
                    autocategoryregistr.ShowDialog();
                    this.Hide();
                }      
            }
            if (NameTextBox.TextLength == 0)
                NameTextBox.BackColor = Color.IndianRed;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NameTextBox.BackColor == Color.IndianRed)
                NameTextBox.BackColor = Color.White;
            ErrorProvider.Clear();
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((NameTextBox.TextLength == 0 && ((char.IsLower(e.KeyChar) && char.IsLetter(e.KeyChar)) || (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)))) ||
               (NameTextBox.TextLength != 0  && ((!e.KeyChar.Equals('-') && !e.KeyChar.Equals(' ') && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) || 
               (char.IsLetter(e.KeyChar) && char.IsUpper(e.KeyChar)))))
            {
                e.Handled = true;
                ErrorProvider.SetError(NameTextBox, "введен недопустимый символ");
            }
        }

        private void CheckCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (flagwho)
                WorkingClass.WorkingMenu.Show();
        }
    }
}
