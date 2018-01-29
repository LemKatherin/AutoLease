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
    public partial class ClientCard : Form
    {

        ListClient clientList = new AutoLeaseClassLib.ListClient();
        Form startMenu = new Form();
        bool flagwho = false;
        bool flagCanCount = false;

        public ClientCard()
        {
            InitializeComponent();
        }

        public ClientCard(ListClient list, Form menu, bool flag)
        {
            InitializeComponent();
            startMenu = menu;
            clientList = list;

            flagwho = flag;
            AutoAddButton.Enabled = flag;
            int j = 1;
            foreach (Client i in clientList.Clients)
            {
                if(j==1)
                {
                    NSFTextBox.Text = i.Name + " " + i.Surname + " " + i.SecondName;
                    AgeTextBox.Text = i.Birthday.Date.ToShortDateString();

                    if (i.Sex)
                    {
                        SexTextBox.Text = "Мужской";
                    }
                    else { SexTextBox.Text = "Женский"; }
                    LicenseCheckBox.Checked = i.DriverLicense;
                    CreationDateTextBox.Text = i.RegistrationDate.Date.ToShortDateString();
                    IDTextBox.Text = i.ID;
                    DebtCheckBox.Checked = i.Debt;
                    j++;
                    continue;
                }

                clientListTable.RowCount = ++clientListTable.RowCount;
                clientListTable.Size = new System.Drawing.Size(clientListTable.Width, this.clientListTable.Size.Height + 120);
                clientListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120));

                TextBox NSFTextBoxNew = new TextBox();
                NSFTextBoxNew.Anchor = NSFTextBox.Anchor;
                NSFTextBoxNew.Font = NSFTextBox.Font;
                NSFTextBoxNew.Multiline = NSFTextBox.Multiline;
                NSFTextBoxNew.Size = NSFTextBox.Size;
                NSFTextBoxNew.Enabled = NSFTextBox.Enabled;

                Label AgeLabelNew = new Label();
                AgeLabelNew.Anchor = AgeLabel.Anchor;
                AgeLabelNew.Text = AgeLabel.Text;
                AgeLabelNew.Font = AgeLabel.Font;
                AgeLabelNew.Margin = AgeLabel.Margin;
                AgeLabelNew.AutoSize = AgeLabel.AutoSize;
            
                TextBox AgeTextBoxNew = new TextBox();
                AgeTextBoxNew.Anchor = AgeTextBox.Anchor;
                AgeTextBoxNew.Font = AgeTextBox.Font;
                AgeTextBoxNew.Size = AgeTextBox.Size;
                AgeTextBoxNew.Enabled = AgeTextBox.Enabled;

                Label SexLabelNew = new Label();
                SexLabelNew.Anchor = SexLabel.Anchor;
                SexLabelNew.Text = SexLabel.Text;
                SexLabelNew.Font = SexLabel.Font;
                SexLabelNew.AutoSize = SexLabel.AutoSize;

                TextBox SexTextBoxNew = new TextBox();
                SexTextBoxNew.Anchor = SexTextBox.Anchor;
                SexTextBoxNew.Font = SexTextBox.Font;
                SexTextBoxNew.Size = SexTextBox.Size;
                SexTextBoxNew.Enabled = SexTextBox.Enabled;

                Label LicenseLabelNew = new Label();
                LicenseLabelNew.Anchor = LicenseLabel.Anchor;
                LicenseLabelNew.Text = LicenseLabel.Text;
                LicenseLabelNew.Font = LicenseLabel.Font;
                LicenseLabelNew.AutoSize = LicenseLabel.AutoSize;

                CheckBox LicenseCheckBoxNew = new CheckBox();
                LicenseCheckBoxNew.Anchor = LicenseCheckBox.Anchor;
                LicenseCheckBoxNew.Text = LicenseCheckBox.Text;
                LicenseCheckBoxNew.Enabled = LicenseCheckBox.Enabled;

                Label CreationDateLabelNew = new Label();
                CreationDateLabelNew.Anchor = CreationDateLabel.Anchor;
                CreationDateLabelNew.Text = CreationDateLabel.Text;
                CreationDateLabelNew.Font = CreationDateLabel.Font;
                CreationDateLabelNew.AutoSize = CreationDateLabel.AutoSize;

                TextBox CreationDateTextBoxNew = new TextBox();
                CreationDateTextBoxNew.Anchor = CreationDateTextBox.Anchor;
                CreationDateTextBoxNew.Font = CreationDateTextBox.Font;
                CreationDateTextBoxNew.Size = CreationDateTextBox.Size;
                CreationDateTextBoxNew.Enabled = CreationDateTextBox.Enabled;

                Label IDLabelNew = new Label();
                IDLabelNew.Anchor = IDLabel.Anchor;
                IDLabelNew.Text = IDLabel.Text;
                IDLabelNew.Font = IDLabel.Font;
                IDLabelNew.AutoSize = IDLabel.AutoSize;

                TextBox IDTextBoxNew = new TextBox();
                IDTextBoxNew.Anchor = IDTextBox.Anchor;
                IDTextBoxNew.Font = IDTextBox.Font;
                IDTextBoxNew.Size = IDTextBox.Size;
                IDTextBoxNew.Enabled = IDTextBox.Enabled;

                Label DebtLabelNew = new Label();
                DebtLabelNew.Anchor = DebtLabel.Anchor;
                DebtLabelNew.Text = DebtLabel.Text;
                DebtLabelNew.Font = DebtLabel.Font;
                DebtLabelNew.AutoSize = DebtLabel.AutoSize;

                CheckBox DebtCheckBoxNew = new CheckBox();
                DebtCheckBoxNew.Anchor = DebtCheckBox.Anchor;
                DebtCheckBoxNew.Text = DebtCheckBox.Text;
                DebtCheckBoxNew.Enabled = DebtCheckBox.Enabled;

                Button OpenButtonNew = new Button();
                OpenButtonNew.FlatStyle = OpenButton.FlatStyle;
                OpenButtonNew.Font = OpenButton.Font;
                OpenButtonNew.Text = OpenButton.Text;
                OpenButtonNew.Enabled = OpenButton.Enabled;
                OpenButtonNew.Anchor = OpenButton.Anchor;
                OpenButtonNew.Size = OpenButton.Size;
                OpenButtonNew.BackColor = OpenButton.BackColor;
                OpenButtonNew.FlatAppearance.BorderColor = OpenButton.FlatAppearance.BorderColor;
                OpenButtonNew.FlatAppearance.BorderSize = OpenButton.FlatAppearance.BorderSize;
                OpenButtonNew.Click += OpenButton_Click;
               

                Button AutoAddButtonNew = new Button();
                AutoAddButtonNew.FlatStyle = AutoAddButton.FlatStyle;
                AutoAddButtonNew.Font = AutoAddButton.Font;
                AutoAddButtonNew.Text = AutoAddButton.Text;
                AutoAddButtonNew.Enabled = flagwho;
                AutoAddButtonNew.Anchor = AutoAddButton.Anchor;
                AutoAddButtonNew.Size = AutoAddButton.Size;
                AutoAddButtonNew.BackColor = AutoAddButton.BackColor;
                AutoAddButtonNew.FlatAppearance.BorderColor = AutoAddButton.FlatAppearance.BorderColor;
                AutoAddButtonNew.FlatAppearance.BorderSize = AutoAddButton.FlatAppearance.BorderSize;
                AutoAddButtonNew.Click += AutoAddButton_Click;



                TableLayoutPanel InfoTableNew = new TableLayoutPanel();           
                InfoTableNew.Size = InfoTable.Size;
                InfoTableNew.Anchor = InfoTable.Anchor;
                InfoTableNew.RowCount = InfoTable.RowCount;
                InfoTableNew.ColumnCount = InfoTable.ColumnCount;
                InfoTableNew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
                InfoTableNew.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
                InfoTableNew.Controls.Add(AgeLabelNew, 0, 0);
                InfoTableNew.Controls.Add(SexLabelNew, 0, 1);
                InfoTableNew.Controls.Add(LicenseLabelNew, 0, 2);
                InfoTableNew.Controls.Add(AgeTextBoxNew, 1, 0);
                InfoTableNew.Controls.Add(SexTextBoxNew, 1, 1);
                InfoTableNew.Controls.Add(LicenseCheckBoxNew, 1, 2);
                InfoTableNew.Controls.Add(CreationDateLabelNew, 2, 0);
                InfoTableNew.Controls.Add(IDLabelNew, 2, 1);
                InfoTableNew.Controls.Add(DebtLabelNew, 2, 2);
                InfoTableNew.Controls.Add(CreationDateTextBoxNew, 3, 0);
                InfoTableNew.Controls.Add(IDTextBoxNew, 3, 1);
                InfoTableNew.Controls.Add(DebtCheckBoxNew, 3, 2);

                TableLayoutPanel ButtonsTableNew = new TableLayoutPanel();
                ButtonsTableNew.Anchor = ButtonsTable.Anchor;
                ButtonsTableNew.Size = ButtonsTable.Size;
                ButtonsTableNew.RowCount = ButtonsTable.RowCount;
                ButtonsTableNew.ColumnCount = ButtonsTable.ColumnCount;
                ButtonsTableNew.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
                ButtonsTableNew.Controls.Add(OpenButtonNew, 0, 0);
                ButtonsTableNew.Controls.Add(AutoAddButtonNew, 0, 1);


                NSFTextBoxNew.Text = i.Name + " " + i.Surname + " " + i.SecondName;
                AgeTextBoxNew.Text = i.Birthday.Date.ToShortDateString();
               
                if (i.Sex)
                {
                    SexTextBoxNew.Text = "Мужской";
                }
                else { SexTextBoxNew.Text = "Женский"; }

                LicenseCheckBoxNew.Checked = i.DriverLicense;
                CreationDateTextBoxNew.Text = i.RegistrationDate.Date.ToShortDateString();
                IDTextBoxNew.Text = i.ID;
                DebtCheckBoxNew.Checked = i.Debt;

                clientListTable.Controls.Add(NSFTextBoxNew, 0, j-1);
                clientListTable.Controls.Add(InfoTableNew, 1, j-1);
                clientListTable.Controls.Add(ButtonsTableNew, 2, j-1);
                j++;
            }

        }

        public void setflag(bool flag)
        {
            flagwho = flag;
        }

        public void setflagCanCount(bool flag)
        {
            flagCanCount = flag;
        }
    
        private void OpenButton_Click(object sender, EventArgs e)
        {
            ClientCardInfo infocard = new ClientCardInfo();
            infocard.setEnabledSum(flagCanCount);
            infocard.Show();
        }

        private void ClientCard_FormClosed(object sender, FormClosedEventArgs e)
        {
            //StartMenu startmenu = new StartMenu();
            if (!flagwho)
                startMenu.Show();
        }

        private void AutoAddButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автомобиль успешно добавлен клиенту","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //MessageBox.Show("У клиента слишком много автомобилей!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                MessageBox.Show("Введите данные для поиска", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
