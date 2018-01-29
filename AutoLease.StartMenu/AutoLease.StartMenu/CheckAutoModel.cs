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
    public partial class CheckAutoModel : Form
    {
        public CheckAutoModel()
        {
            InitializeComponent();
        }

        AutoRegistr autoregistrwin = new AutoRegistr();

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (NameComboBox.Text.Length !=0 && NameTextBox.TextLength != 0)
            {
                autoregistrwin.setNameTextBox1(NameComboBox);
                autoregistrwin.setNameTextBox2(NameTextBox);
                autoregistrwin.setCheckAutoModelWin(this);
                autoregistrwin.Show();
                this.Hide();

            }
            //else if (NameComboBox.Text.Length == 1 && NameTextBox.TextLength == 1)
            //{
            //    MessageBox.Show("Такая модель уже зарегестрирована", "Ошибка!");
            //    this.Close();
            //}

            if (NameComboBox.Text.Length == 0)
                NameComboBox.BackColor = Color.IndianRed;
            if (NameTextBox.TextLength == 0)
                NameTextBox.BackColor = Color.IndianRed;
        }

        private void AddModelProductButton_Click(object sender, EventArgs e)
        {
            ModelProductToAdd modelproducttoaddwin = new ModelProductToAdd();
            modelproducttoaddwin.Show();
        }

        private void NameComboBox_TextChanged(object sender, EventArgs e)
        {
            if(NameComboBox.BackColor == Color.IndianRed)
                NameComboBox.BackColor = Color.White;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NameTextBox.BackColor == Color.IndianRed)
                NameTextBox.BackColor = Color.White;
        }

        private void NameComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) ||
               (NameComboBox.Text.Length == 0 && char.IsLower(e.KeyChar)))
                e.Handled = true;
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
                !char.IsNumber(e.KeyChar)))
                e.Handled = true;
        }


        private void CheckAutoModel_FormClosed(object sender, FormClosedEventArgs e)
        {
            StartMenu startmenu = new StartMenu();
            startmenu.Show();
        }
    }
}
