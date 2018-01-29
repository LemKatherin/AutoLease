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
    public partial class ChangeClient : Form
    {
 
        Client client = new Client();

        public ChangeClient()
        {
            InitializeComponent();
            NameToolTip.SetToolTip(NameTextBox, "Поле может содержать только буквы, первая буква должна быть заглавной.");
            SurnameToolTip.SetToolTip(SurnameTextBox, "Поле может содержать только буквы, первая буква должна быть заглавной.");
            FathernameToolTip.SetToolTip(FathernameTextBox, "Поле может содержать только буквы, первая буква должна быть заглавной.");
        }

        public ChangeClient(Client cl)
        {
            client = cl;
            InitializeComponent();
            NameToolTip.SetToolTip(NameTextBox, "Поле может содержать только буквы, первая буква должна быть заглавной.");
            SurnameToolTip.SetToolTip(SurnameTextBox, "Поле может содержать только буквы, первая буква должна быть заглавной.");
            FathernameToolTip.SetToolTip(FathernameTextBox, "Поле может содержать только буквы, первая буква должна быть заглавной.");
        }


        private void OKbutton_Click(object sender, EventArgs e)
        {       

            if (NameTextBox.TextLength != 0 && SurnameTextBox.TextLength != 0 &&
               FathernameTextBox.TextLength != 0)
            {
                client.Name = NameTextBox.Text;
                client.Surname = SurnameTextBox.Text;
                client.SecondName = FathernameTextBox.Text;
                ClientService service = new ClientService(client);
                client.ID = service.generateID();
                this.Close();           
            }
            else
            {
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


    }
}
