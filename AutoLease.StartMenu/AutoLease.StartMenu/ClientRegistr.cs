using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoLeaseClassLib;

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

        public ClientRegistr(ListClient list, Form menu/*, Form check */)
        {
            InitializeComponent();
            CreationDateTimePicker.Value = DateTime.Today;
            DriverLicDateTimePicker.Value = DateTime.Today;
            clientList = list;
            startmenu = menu;
            //checkClient = check;
        }

        ListClient clientList = new ListClient();
        Form startmenu = new Form();
        //Form checkClient = new Form();


        public void setNameTextBox(MaskedTextBox name)
        {
            NameTextBox.Text = name.Text;
        }
        public void setSurnameTextBox(MaskedTextBox surname)
        {
            SurnameTextBox.Text = surname.Text;
        }
        public void setFathernameTextBox(MaskedTextBox fathername)
        {
            FathernameTextBox.Text = fathername.Text;
        }


        private void ReadyButton_Click(object sender, EventArgs e)
        {

            
            if (NameTextBox.TextLength != 0 && SurnameTextBox.TextLength != 0 &&
                FathernameTextBox.TextLength != 0 &&
                (MaleRadioButton.Checked || FemaleRadioButton.Checked) &&
                (18 <= (DateTime.Today.Year - BirthdayDateTimePicker.Value.Year) &&
                (DateTime.Today.Year - BirthdayDateTimePicker.Value.Year) <= 100))
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
                    BirthdayDateTimePicker.Value.Date, DriverLicCheckBox.Checked, DriverLicDateTimePicker.Value.Date,
                    false, CreationDateTimePicker.Value.Date);
                if (clientList.ClientRegistration(client))
                {
                    MessageBox.Show("Регистрация нового клиента успешно завершена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
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
                if (18 > (DateTime.Today.Year - BirthdayDateTimePicker.Value.Year) ||
                (DateTime.Today.Year - BirthdayDateTimePicker.Value.Year) > 100)
                {
                    BirthdayErrorProvider.SetError(BirthdayLabel, "Некорректный возраст");
                }
                if(!MaleRadioButton.Checked && !FemaleRadioButton.Checked)
                {
                    SexErrorProvider.SetError(SexLabel, "Выберете пол");
                }
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
               (DateTime.Today.Year - BirthdayDateTimePicker.Value.Year) <= 100)
            {
                BirthdayErrorProvider.Clear();
            }
        }

        private void ClientRegistr_FormClosed(object sender, FormClosedEventArgs e)
        {
            //StartMenu startmenu = new StartMenu();
           // checkClient.Close();
            startmenu.Show();
        }

        private void DriverLicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DriverLicCheckBox.Checked)
                DriverLicDateTimePicker.Enabled = true;
            else
                DriverLicDateTimePicker.Enabled = false;
        }
    }
}
