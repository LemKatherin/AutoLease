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
    public partial class ClientCard : Form
    {
        public ClientCard()
        {
            InitializeComponent();
        }

        bool flagwho = false;

        public void setflag(bool temp)
        {
            flagwho = temp;
            AutoAddButton.Enabled = temp;
        }

        bool flagCanCount = false;

        public void setflagCanCount(bool flag)
        {
            flagCanCount = flag;
        }

        private void Поиск_Click(object sender, EventArgs e)
        {

        }


        private void OpenButton_Click(object sender, EventArgs e)
        {
            ClientCardInfo infocard = new ClientCardInfo();
            infocard.setEnabledSum(flagCanCount);
            if (OpenCheckBox.Checked)
                infocard.Show();
        }

        private void ClientCard_FormClosed(object sender, FormClosedEventArgs e)
        {
            StartMenu startmenu = new StartMenu();
            if (!flagwho)
                startmenu.Show();
        }

        private void AutoAddButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Автомобиль успешно добавлен клиенту","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //MessageBox.Show("У клиента слишком много автомобилей!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //MessageBox.Show("У клиента истек срок действия прав!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //MessageBox.Show("У клиента нет прав!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.TextLength == 0)
                    MessageBox.Show("Введите данные для поиска", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!SurnameRadioButton.Checked && !IDRadioButton.Checked && !NameRadioButton.Checked)
                e.Handled = true;
            else if (SurnameRadioButton.Checked || NameRadioButton.Checked)
            {
                if ((!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) ||
                               (SearchTextBox.TextLength == 0 && char.IsLower(e.KeyChar)) ||
                               (SearchTextBox.TextLength > 0 && char.IsUpper(e.KeyChar)))               
                    e.Handled = true;
                
            }
        }

        private void SurnameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SurnameRadioButton.Checked)
                SearchTextBox.Clear();
        }

        private void IDRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            if (IDRadioButton.Checked)
                SearchTextBox.Clear();
        }


        private void NameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NameRadioButton.Checked)
                SearchTextBox.Clear();
        }
    }
}
