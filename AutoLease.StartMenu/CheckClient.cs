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
    public partial class CheckClient : Form
    { 

        public CheckClient()
        {
            InitializeComponent();
            NameToolTip.SetToolTip(NameTextBox, "Поле может содержать только буквы, первая буква должна быть заглавной.");
            SurnameToolTip.SetToolTip(SurnameTextBox, "Поле может содержать только буквы, первая буква должна быть заглавной.");
            FathernameToolTip.SetToolTip(FathernameTextBox, "Поле может содержать только буквы, первая буква должна быть заглавной.");
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            ClientRegistr clientregistr = new ClientRegistr();
            Client searchedClient = new Client();

            if (NameTextBox.TextLength != 0 && SurnameTextBox.TextLength != 0 &&
               FathernameTextBox.TextLength != 0 && PassportMaskedTextBox.MaskFull)
            {
                searchedClient = ClientListService.ClientSearchCheck(PassportMaskedTextBox.Text);
                if (searchedClient == null)
                {
                    clientregistr.setNameTextBoxes(NameTextBox.Text, SurnameTextBox.Text,FathernameTextBox.Text, PassportMaskedTextBox.Text);
                    clientregistr.Show();
                }
                else
                {
                    MessageBox.Show("Такой клиент уже зарегестрирован." , "",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    this.Close();
                }
                this.Hide();
            }
            else
            {
                if (!PassportMaskedTextBox.MaskFull)
                    PassportMaskedTextBox.BackColor = Color.IndianRed;
                if (NameTextBox.TextLength == 0)
                    NameTextBox.BackColor = Color.IndianRed;
                if (SurnameTextBox.TextLength == 0)
                    SurnameTextBox.BackColor = Color.IndianRed;
                if (FathernameTextBox.TextLength == 0)
                    FathernameTextBox.BackColor = Color.IndianRed;                
            }
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) ||
                (NameTextBox.TextLength == 0 && char.IsLower(e.KeyChar)) ||
                (NameTextBox.TextLength > 0 && char.IsUpper(e.KeyChar)))
            {
                e.Handled = true;
                NameErrorProvider.SetError(NameTextBox, "введен недопустимый символ");
            }
            else
            {
                NameErrorProvider.Clear();
                if (NameTextBox.BackColor == Color.IndianRed)
                    NameTextBox.BackColor = Color.White;
            }
        }

        private void SurnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) ||
              (SurnameTextBox.TextLength == 0 && char.IsLower(e.KeyChar)) ||
              (SurnameTextBox.TextLength > 0 && char.IsUpper(e.KeyChar)))
            {
                e.Handled = true;
                SurnameErrorProvider.SetError(SurnameTextBox, "введен недопустимый символ");
            }
            else
            {
                SurnameErrorProvider.Clear();
                if (SurnameTextBox.BackColor == Color.IndianRed)
                    SurnameTextBox.BackColor = Color.White;
            }
        }

        private void FathernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) ||
               (FathernameTextBox.TextLength == 0 && char.IsLower(e.KeyChar)) ||
               (FathernameTextBox.TextLength > 0 && char.IsUpper(e.KeyChar)))
            {
                e.Handled = true;
                FathernameErrorProvider.SetError(FathernameTextBox, "введен недопустимый символ");
            }
            else
            {
                FathernameErrorProvider.Clear();
                if (FathernameTextBox.BackColor == Color.IndianRed)
                    FathernameTextBox.BackColor = Color.White;
            }
        }


        private void CheckClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            WorkingClass.WorkingMenu.Show();
        }

        private void PassportMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PassportMaskedTextBox.BackColor == Color.IndianRed)
                PassportMaskedTextBox.BackColor = Color.White;
        }

        private void SurnameTextBox_Leave(object sender, EventArgs e)
        {
            FathernameErrorProvider.Clear();
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            NameErrorProvider.Clear();
        }

        private void FathernameTextBox_Leave(object sender, EventArgs e)
        {
            FathernameErrorProvider.Clear();
        }
    }
}
