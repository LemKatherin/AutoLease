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
    public partial class ClientRegistr : Form
    {      

        public ClientRegistr()
        {
            InitializeComponent();
            CreationDateTimePicker.Value = DateTime.Today;
            DriverLicDateTimePicker.Value = DateTime.Today;
        }

        public ClientRegistr(StartMenu menu/*, Form check */)
        {
            InitializeComponent();
            CreationDateTimePicker.Value = DateTime.Today;
            DriverLicDateTimePicker.Value = DateTime.Today;
        }



        public void setNameTextBoxes(string name, string surname, string fathername, string passport)
        {
            NameTextBox.Text = name;
            SurnameTextBox.Text = surname;
            FathernameTextBox.Text = fathername;
            PassportMaskedTextBox.Text = passport;
        }


        private void ReadyButton_Click(object sender, EventArgs e)
        {
         
            if (NameTextBox.TextLength != 0 && SurnameTextBox.TextLength != 0 &&
                FathernameTextBox.TextLength != 0 &&
                (MaleRadioButton.Checked || FemaleRadioButton.Checked) &&
                (18 <= (DateTime.Today.Year - BirthdayDateTimePicker.Value.Year) &&
                (DateTime.Today.Year - BirthdayDateTimePicker.Value.Year) <= 120) && 
                (DriverLicDateTimePicker.Value.Date >= DateTime.Today.Date && 
                DriverLicDateTimePicker.Value.Date <= DateTime.Today.Date.AddYears(10).Date))
            {
                bool sex;
                if (MaleRadioButton.Checked)
                {
                    sex = true;
                }
                else {
                    sex = false;
                }

                Client client = new Client(NameTextBox.Text, SurnameTextBox.Text, FathernameTextBox.Text, sex,
                    BirthdayDateTimePicker.Value.Date, PassportMaskedTextBox.Text, DriverLicDateTimePicker.Value.Date,
                    false, CreationDateTimePicker.Value.Date, ClientListStorage.Clients.Count + 1);
                client.ID = (new ClientService(client)).generateID();
                ClientListService.ClientRegistration(client);               
                MessageBox.Show("Регистрация нового клиента успешно завершена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                
                if (18 > (DateTime.Today.Year - BirthdayDateTimePicker.Value.Year) ||
                (DateTime.Today.Year - BirthdayDateTimePicker.Value.Year) > 120)
                {
                    BirthdayErrorProvider.SetError(BirthdayLabel, "Некорректный возраст");
                }
                if(!MaleRadioButton.Checked && !FemaleRadioButton.Checked)
                {
                    SexErrorProvider.SetError(SexLabel, "Выберете пол");
                }

                if (DriverLicDateTimePicker.Value.Date < DateTime.Today.Date ||
                DriverLicDateTimePicker.Value.Date > DateTime.Today.AddYears(10).Date)
                    DriverLicErrorProvider.SetError(DriverLicDateTimePicker, "Некорректный срок действия прав");

            }        
        }

        private void MaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MaleRadioButton.Checked)
                SexErrorProvider.Clear();
        }

        private void FemaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (FemaleRadioButton.Checked)
                SexErrorProvider.Clear();
        }

        private void BirthdayDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (18 <= (DateTime.Today.Year - BirthdayDateTimePicker.Value.Year) &&
               (DateTime.Today.Year - BirthdayDateTimePicker.Value.Year) <= 120)
            {
                BirthdayErrorProvider.Clear();
            }
        }

        private void ClientRegistr_FormClosed(object sender, FormClosedEventArgs e)
        {
            WorkingClass.WorkingMenu.Show();
        }



        private void DriverLicDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if ((DriverLicDateTimePicker.Value.Date >= DateTime.Today.Date &&
                DriverLicDateTimePicker.Value.Date <= DateTime.Today.AddYears(10).Date))
                DriverLicErrorProvider.Clear();
        }

        private void PassportMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PassportMaskedTextBox.BackColor == Color.IndianRed)
                PassportMaskedTextBox.BackColor = Color.White;
        }
    }
}
