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
    public partial class ClientList : Form
    {

        bool flagwho = false;
        bool flagCanChange = false;
        Auto Automobile = new Auto();


        public ClientList()
        {
            InitializeComponent();
        }

        public ClientList(bool flag): this()
        {      
            flagwho = flag;
            AutoAddButton.Enabled = flag;
            ShowList(ClientListStorage.Clients);

        }

        public ClientList(bool flag, Auto automobile) : this()
        {      
            flagwho = flag;
            AutoAddButton.Enabled = flag;
            ShowList(ClientListStorage.Clients);
            Automobile = automobile;
        }

        public void ShowList(List<Client> list)
        {
            int j = 1;
            try
            {
                foreach (Client i in list)
                {
                    if (j == 1)
                    {
                        NSFTextBox.Text = i.Surname + " " + i.Name + " " + i.SecondName;
                        AgeTextBox.Text = i.Birthday.Date.ToShortDateString();

                        if (i.Sex)
                        {
                            SexTextBox.Text = "Мужской";
                        }
                        else { SexTextBox.Text = "Женский"; }
                        CreationDateTextBox.Text = i.RegistrationDate.Date.ToShortDateString();
                        IDTextBox.Text = i.ID;
                        LicenseTextBox.Text = i.DriverLicenseTime.Date.ToShortDateString();
                        DebtCheckBox.Checked = i.Debt;
                        OpenButton.Name = i.ID;
                        AutoAddButton.Name = i.ID + "ADD";
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
                    AgeLabelNew.Dock = AgeLabel.Dock;

                    TextBox AgeTextBoxNew = new TextBox();
                    AgeTextBoxNew.Anchor = AgeTextBox.Anchor;
                    AgeTextBoxNew.Font = AgeTextBox.Font;
                    AgeTextBoxNew.Size = AgeTextBox.Size;
                    AgeTextBoxNew.Enabled = AgeTextBox.Enabled;
                    AgeTextBoxNew.Margin = AgeTextBox.Margin;
                    AgeTextBoxNew.AutoSize = AgeTextBox.AutoSize;
                    AgeTextBoxNew.Dock = AgeTextBox.Dock;

                    Label SexLabelNew = new Label();
                    SexLabelNew.Anchor = SexLabel.Anchor;
                    SexLabelNew.Text = SexLabel.Text;
                    SexLabelNew.Font = SexLabel.Font;
                    SexLabelNew.Margin = SexLabel.Margin;
                    SexLabelNew.AutoSize = SexLabel.AutoSize;
                    SexLabelNew.Dock = SexLabel.Dock;

                    TextBox SexTextBoxNew = new TextBox();
                    SexTextBoxNew.Anchor = SexTextBox.Anchor;
                    SexTextBoxNew.Font = SexTextBox.Font;
                    SexTextBoxNew.Size = SexTextBox.Size;
                    SexTextBoxNew.Enabled = SexTextBox.Enabled;
                    SexTextBoxNew.Margin = SexTextBox.Margin;
                    SexTextBoxNew.AutoSize = SexTextBox.AutoSize;
                    SexTextBoxNew.Dock = SexTextBox.Dock;

                    Label LicenseLabelNew = new Label();
                    LicenseLabelNew.Anchor = LicenseLabel.Anchor;
                    LicenseLabelNew.Text = LicenseLabel.Text;
                    LicenseLabelNew.Font = LicenseLabel.Font;
                    LicenseLabelNew.AutoSize = LicenseLabel.AutoSize;
                    LicenseLabelNew.Margin = LicenseLabel.Margin;
                    LicenseLabelNew.AutoSize = LicenseLabel.AutoSize;
                    LicenseLabelNew.Dock = LicenseLabel.Dock;

                    TextBox LicenseTextBoxNew = new TextBox();
                    LicenseTextBoxNew.Anchor = LicenseTextBox.Anchor;
                    LicenseTextBoxNew.Font = LicenseTextBox.Font;
                    LicenseTextBoxNew.Size = LicenseTextBox.Size;
                    LicenseTextBoxNew.Enabled = LicenseTextBox.Enabled;
                    LicenseTextBoxNew.Margin = LicenseTextBox.Margin;
                    LicenseTextBoxNew.AutoSize = LicenseTextBox.AutoSize;
                    LicenseTextBoxNew.Dock = LicenseTextBox.Dock;

                    Label CreationDateLabelNew = new Label();
                    CreationDateLabelNew.Anchor = CreationDateLabel.Anchor;
                    CreationDateLabelNew.Text = CreationDateLabel.Text;
                    CreationDateLabelNew.Font = CreationDateLabel.Font;
                    CreationDateLabelNew.Margin = CreationDateLabel.Margin;
                    CreationDateLabelNew.AutoSize = CreationDateLabel.AutoSize;
                    CreationDateLabelNew.Dock = CreationDateLabel.Dock;

                    TextBox CreationDateTextBoxNew = new TextBox();
                    CreationDateTextBoxNew.Anchor = CreationDateTextBox.Anchor;
                    CreationDateTextBoxNew.Font = CreationDateTextBox.Font;
                    CreationDateTextBoxNew.Size = CreationDateTextBox.Size;
                    CreationDateTextBoxNew.Enabled = CreationDateTextBox.Enabled;
                    CreationDateTextBoxNew.Margin = CreationDateTextBox.Margin;
                    CreationDateTextBoxNew.AutoSize = CreationDateTextBox.AutoSize;
                    CreationDateTextBoxNew.Dock = CreationDateTextBox.Dock;

                    Label IDLabelNew = new Label();
                    IDLabelNew.Anchor = IDLabel.Anchor;
                    IDLabelNew.Text = IDLabel.Text;
                    IDLabelNew.Font = IDLabel.Font;
                    IDLabelNew.Margin = IDLabel.Margin;
                    IDLabelNew.AutoSize = IDLabel.AutoSize;
                    IDLabelNew.Dock = IDLabel.Dock;

                    TextBox IDTextBoxNew = new TextBox();
                    IDTextBoxNew.Anchor = IDTextBox.Anchor;
                    IDTextBoxNew.Font = IDTextBox.Font;
                    IDTextBoxNew.Size = IDTextBox.Size;
                    IDTextBoxNew.Enabled = IDTextBox.Enabled;
                    IDTextBoxNew.Margin = IDTextBox.Margin;
                    IDTextBoxNew.AutoSize = IDTextBox.AutoSize;
                    IDTextBoxNew.Dock = IDTextBox.Dock;

                    Label DebtLabelNew = new Label();
                    DebtLabelNew.Anchor = DebtLabel.Anchor;
                    DebtLabelNew.Text = DebtLabel.Text;
                    DebtLabelNew.Font = DebtLabel.Font;
                    DebtLabelNew.Margin = DebtLabel.Margin;
                    DebtLabelNew.AutoSize = DebtLabel.AutoSize;
                    DebtLabelNew.Dock = DebtLabel.Dock;

                    CheckBox DebtCheckBoxNew = new CheckBox();
                    DebtCheckBoxNew.Anchor = DebtCheckBox.Anchor;
                    DebtCheckBoxNew.Text = DebtCheckBox.Text;
                    DebtCheckBoxNew.Enabled = DebtCheckBox.Enabled;
                    DebtCheckBoxNew.Margin = DebtCheckBox.Margin;
                    DebtCheckBoxNew.AutoSize = DebtCheckBox.AutoSize;
                    DebtCheckBoxNew.Dock = DebtCheckBox.Dock;

                    Button OpenButtonNew = new Button();
                    OpenButtonNew.Name = i.ID;
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
                    AutoAddButtonNew.Name = i.ID + "ADD";
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
                    InfoTableNew.Margin = InfoTable.Margin;
                    InfoTableNew.AutoSize = InfoTable.AutoSize;
                    InfoTableNew.Dock = InfoTable.Dock;
                    InfoTableNew.RowCount = InfoTable.RowCount;
                    InfoTableNew.ColumnCount = InfoTable.ColumnCount;
                    InfoTableNew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
                    InfoTableNew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
                    InfoTableNew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
                    InfoTableNew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
                    InfoTableNew.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
                    InfoTableNew.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
                    InfoTableNew.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
                    InfoTableNew.Controls.Add(AgeLabelNew, 0, 0);
                    InfoTableNew.Controls.Add(SexLabelNew, 0, 1);
                    InfoTableNew.Controls.Add(LicenseLabelNew, 0, 2);
                    InfoTableNew.Controls.Add(AgeTextBoxNew, 1, 0);
                    InfoTableNew.Controls.Add(SexTextBoxNew, 1, 1);
                    InfoTableNew.Controls.Add(LicenseTextBoxNew, 1, 2);
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


                    NSFTextBoxNew.Text = i.Surname + " " + i.Name + " " + i.SecondName;
                    AgeTextBoxNew.Text = i.Birthday.Date.ToShortDateString();

                    if (i.Sex)
                    {
                        SexTextBoxNew.Text = "Мужской";
                    }
                    else { SexTextBoxNew.Text = "Женский"; }

                    CreationDateTextBoxNew.Text = i.RegistrationDate.Date.ToShortDateString();
                    IDTextBoxNew.Text = i.ID;
                    LicenseTextBoxNew.Text = i.DriverLicenseTime.Date.ToShortDateString();
                    DebtCheckBoxNew.Checked = i.Debt;

                    clientListTable.Controls.Add(NSFTextBoxNew, 0, j - 1);
                    clientListTable.Controls.Add(InfoTableNew, 1, j - 1);
                    clientListTable.Controls.Add(ButtonsTableNew, 2, j - 1);
                    j++;
                }
            }
            catch(NullReferenceException) { }
        }

        public void setflagCanCount(bool flag)
        {
            flagCanChange = flag;
        }
    
        private void OpenButton_Click(object sender, EventArgs e)
        {
            Control btn = (Control)sender;
           
            Client openClient = new Client();
            openClient = ClientListService.ClientSearch(btn.Name);

            if (openClient != null)
            {

                ClientCardInfo infocard = new ClientCardInfo(flagCanChange, openClient);
                infocard.Show();
            }
            else
            {
                ClientCardInfo infocard = new ClientCardInfo(flagCanChange);
                infocard.Show();
            }
        }

        private void ClientCard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!flagwho)
                WorkingClass.WorkingMenu.Show();
        }

        private void AutoAddButton_Click(object sender, EventArgs e)
        {
            Control btn = (Control)sender;          

            Client openClient = new Client();
            openClient = ClientListService.ClientSearch(btn.Name.Remove(3));
            try
            {
                if (openClient.leaseList.Count < 7)
                {
                    Automobile.Enable = false;
                    Lease lease = new Lease(Automobile, DateTime.Today);

                    FrmDateForUse numDays = new FrmDateForUse(lease, openClient);
                    numDays.ShowDialog();
                
                    this.Close();
                                   
                }
                else
                    MessageBox.Show("У клиента слишком много автомобилей.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Вы пытаетесь добавить несуществующему клиенту автомобиль.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void repaint()
        {
            while (clientListTable.RowCount > 1)
            {
                int row = clientListTable.RowCount - 1;
                for (int i = 0; i < clientListTable.ColumnCount; i++)
                {
                    Control c = clientListTable.GetControlFromPosition(i, row);
                    clientListTable.Controls.Remove(c);
                    c.Dispose();
                }

                clientListTable.RowStyles.RemoveAt(row);
                clientListTable.RowCount--;
                clientListTable.Height -= 120;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                MessageBox.Show("Введите данные для поиска", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                List<Client> searchedClients = new List<Client>();

                if (SurnameRadioButton.Checked)
                    searchedClients = ClientListService.ClientSearch(1, SearchTextBox.Text).ToList();
                else if (NameRadioButton.Checked)
                    searchedClients = ClientListService.ClientSearch(2, SearchTextBox.Text).ToList();
                else if (IDRadioButton.Checked)
                    searchedClients = ClientListService.ClientSearch(3, SearchTextBox.Text).ToList();

                clientListTable.Hide();
                repaint();

                if (searchedClients.Count == 0)
                {
                    MessageBox.Show("Такие клиенты не найдены.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowList(ClientListStorage.Clients);
                }
                else
                    ShowList(searchedClients);
                clientListTable.Show();
            }
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
            else if(IDRadioButton.Checked)
            {
                if ((!char.IsControl(e.KeyChar) && char.IsLower(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar)))
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

        private void Timer_Tick(object sender, EventArgs e)
        {
            ClientsToolStripTextBox.Text = ClientListStorage.Clients.Count.ToString();
            int sum = 0;
            foreach (AutoForStorage auto in AutoListStorage.Cars)
            {
                sum += auto.Automobiles.Count;
            }
            AutoToolStripTextBox.Text = sum.ToString();
            DateToolStripTextBox.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.TextLength == 0)
            {
                clientListTable.Hide();
                repaint();
                ShowList(ClientListStorage.Clients);
                clientListTable.Show();
            }
        }

        private void AutoListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AutoModelList autoList = new AutoModelList(true);
            autoList.Show();
        }

        private void ClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckClient clientRegistr = new CheckClient();
            clientRegistr.ShowDialog();      
        }

        private void AutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckAutoModel autoRegistr = new CheckAutoModel();
            autoRegistr.ShowDialog();
        }

        private void CategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckCategory autoRegistr = new CheckCategory(false);
            autoRegistr.ShowDialog();
        }

        private void LeaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoModelList autoLease = new AutoModelList(false);
            autoLease.Show();
        }

        private void ClientList_Activated(object sender, EventArgs e)
        {
            clientListTable.Hide();
            repaint();
            ShowList(ClientListStorage.Clients);
            clientListTable.Show();
        }
    }
}
