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
    public partial class CheckCategory : Form
    {
        public CheckCategory()
        {
            InitializeComponent();
        }

        AutoCategoryRegistr autocategoryregistr = new AutoCategoryRegistr();
        bool flagwho = false;

        public void setflag(bool temp)
        {
            flagwho = temp;
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.TextLength != 0)
            {
                autocategoryregistr.setNameTextBox(NameTextBox);
                autocategoryregistr.setCheckCategoryWin(this);
                autocategoryregistr.setflag(flagwho);
                autocategoryregistr.Show();
                this.Hide();   
      
            }
            //else if (NameTextBox.TextLength == 1)
            //{
            //    MessageBox.Show("Такая категория уже зарегестрирована", "Ошибка!");
            //    this.Close();
            //}
            if (NameTextBox.TextLength == 0)
                NameTextBox.BackColor = Color.IndianRed;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NameTextBox.BackColor == Color.IndianRed)
                NameTextBox.BackColor = Color.White;
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) ||
               (NameTextBox.TextLength > 0 && char.IsUpper(e.KeyChar)))
                e.Handled = true;
        }

        private void CheckCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            StartMenu startmenu = new StartMenu();
            if (flagwho)
                startmenu.Show();
        }
    }
}
