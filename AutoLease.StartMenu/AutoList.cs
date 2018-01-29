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
    public partial class AutoList : Form
    {
      
        AutoForStorage Model = new AutoForStorage();

        public AutoList()
        {
            InitializeComponent();
        }

        public AutoList(bool CanAdd, AutoForStorage model) : this()
        {
            AddButton.Enabled = !CanAdd;
            AddNewButton.Enabled = CanAdd;          
            Model = model;
            ShowList();

        }
        public AutoList(bool CanAdd) : this()
        {
            AddButton.Enabled = !CanAdd;
            AddNewButton.Enabled = CanAdd;
        }

        public void ShowList()   
        {
            int j = 1;
            try
            {
                foreach (Auto i in Model.Automobiles)
                {
                    if (j == 1)
                    {
                        PhotoPictureBox.Image = i.Photo;
                        YearTextBox.Text = i.Year.ToString();
                        ColorTextBox.Text = i.Color;
                        EnableCheckBox.Checked = i.Enable;
                        MileageTextBox.Text = i.Mileage.ToString();
                        IDTextBox.Text = i.ID;
                        if (i.Transmission.Equals("механическая"))
                            MechTrRadioButton.Checked = true;
                        else if (i.Transmission.Equals("вариативная"))
                            VarTrRadioButton.Checked = true;
                        else if (i.Transmission.Equals("автоматическая"))
                            AutTrRadioButton.Checked = true;
                        else
                            RobTrRadioButton.Checked = true;
                        DescriptionTextBox.Text = i.Description;
                        if(!i.Enable)
                            EnableDateTextBox.Text = i.DateReturn.Date.ToShortDateString();
                        AddButton.Name = i.ID;
                        j++;
                        continue;
                    }

                    automobileListTable.RowCount = ++automobileListTable.RowCount;
                    automobileListTable.Size = new System.Drawing.Size(automobileListTable.Width, this.automobileListTable.Size.Height + 284);
                    automobileListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 284));

                    PictureBox PhotoBoxNew = new PictureBox();
                    PhotoBoxNew.Size = PhotoPictureBox.Size;
                    PhotoBoxNew.Anchor = PhotoPictureBox.Anchor;
                    PhotoBoxNew.Location = PhotoPictureBox.Location;
                    PhotoBoxNew.SizeMode = PhotoPictureBox.SizeMode;
                    PhotoBoxNew.BorderStyle = PhotoPictureBox.BorderStyle;
                    PhotoBoxNew.Enabled = PhotoPictureBox.Enabled;
                    PhotoBoxNew.Visible = true;

                    Label YearLabelNew = new Label();
                    YearLabelNew.Anchor = YearLabel.Anchor;
                    YearLabelNew.Text = YearLabel.Text;
                    YearLabelNew.Font = YearLabel.Font;
                    YearLabelNew.AutoSize = YearLabel.AutoSize;
                    YearLabelNew.Margin = YearLabel.Margin;
                    YearLabelNew.Dock = YearLabel.Dock;

                    TextBox YearTextBoxNew = new TextBox();
                    YearTextBoxNew.Anchor = YearTextBox.Anchor;
                    YearTextBoxNew.Font = YearTextBox.Font;
                    YearTextBoxNew.Size = YearTextBox.Size;
                    YearTextBoxNew.Enabled = YearTextBox.Enabled;
                    YearTextBoxNew.AutoSize = YearTextBox.AutoSize;
                    YearTextBoxNew.Margin = YearTextBox.Margin;
                    YearTextBoxNew.Dock = YearTextBox.Dock;

                    Label ColorLabelNew = new Label();
                    ColorLabelNew.Anchor = ColorLabel.Anchor;
                    ColorLabelNew.Text = ColorLabel.Text;
                    ColorLabelNew.Font = ColorLabel.Font;
                    ColorLabelNew.AutoSize = ColorLabel.AutoSize;
                    ColorLabelNew.Margin = ColorLabel.Margin;
                    ColorLabelNew.Dock = ColorLabel.Dock;

                    TextBox ColorTextBoxNew = new TextBox();
                    ColorTextBoxNew.Anchor = ColorTextBox.Anchor;
                    ColorTextBoxNew.Font = ColorTextBox.Font;
                    ColorTextBoxNew.Size = ColorTextBox.Size;
                    ColorTextBoxNew.Enabled = ColorTextBox.Enabled;
                    ColorTextBoxNew.AutoSize = ColorTextBox.AutoSize;
                    ColorTextBoxNew.Margin = ColorTextBox.Margin;
                    ColorTextBoxNew.Dock = ColorTextBox.Dock;

                    Label EnableLabelNew = new Label();
                    EnableLabelNew.Anchor = EnableLabel.Anchor;
                    EnableLabelNew.Text = EnableLabel.Text;
                    EnableLabelNew.Font = EnableLabel.Font;
                    EnableLabelNew.AutoSize = EnableLabel.AutoSize;
                    EnableLabelNew.Margin = EnableLabel.Margin;
                    EnableLabelNew.Dock = EnableLabel.Dock;

                    CheckBox EnableCheckBoxNew = new CheckBox();
                    EnableCheckBoxNew.Anchor = EnableCheckBox.Anchor;
                    EnableCheckBoxNew.Text = EnableCheckBox.Text;
                    EnableCheckBoxNew.Enabled = EnableCheckBox.Enabled;
                    EnableCheckBoxNew.AutoSize = EnableCheckBox.AutoSize;
                    EnableCheckBoxNew.Margin = EnableCheckBox.Margin;
                    EnableCheckBoxNew.Dock = EnableCheckBox.Dock;

                    Label EnableDateLabelNew = new Label();
                    EnableDateLabelNew.Anchor = EnableDateLabel.Anchor;
                    EnableDateLabelNew.Text = EnableDateLabel.Text;
                    EnableDateLabelNew.Font = EnableDateLabel.Font;
                    EnableDateLabelNew.AutoSize = EnableDateLabel.AutoSize;
                    EnableDateLabelNew.Margin = EnableDateLabel.Margin;
                    EnableDateLabelNew.Dock = EnableDateLabel.Dock;

                    TextBox EnableDateTextBoxNew = new TextBox();
                    EnableDateTextBoxNew.Anchor = EnableDateTextBox.Anchor;
                    EnableDateTextBoxNew.Font = EnableDateTextBox.Font;
                    EnableDateTextBoxNew.Size = EnableDateTextBox.Size;
                    EnableDateTextBoxNew.Enabled = EnableDateTextBox.Enabled;
                    EnableDateTextBoxNew.AutoSize = EnableDateTextBox.AutoSize;
                    EnableDateTextBoxNew.Margin = EnableDateTextBox.Margin;
                    EnableDateTextBoxNew.Dock = EnableDateTextBox.Dock;

                    Label MileageLabelNew = new Label();
                    MileageLabelNew.Anchor = MileageLabel.Anchor;
                    MileageLabelNew.Text = MileageLabel.Text;
                    MileageLabelNew.Font = MileageLabel.Font;
                    MileageLabelNew.AutoSize = MileageLabel.AutoSize;
                    MileageLabelNew.Margin = MileageLabel.Margin;
                    MileageLabelNew.Dock = MileageLabel.Dock;


                    TextBox MileageTextBoxNew = new TextBox();
                    MileageTextBoxNew.Anchor = MileageTextBox.Anchor;
                    MileageTextBoxNew.Font = MileageTextBox.Font;
                    MileageTextBoxNew.Size = MileageTextBox.Size;
                    MileageTextBoxNew.Enabled = MileageTextBox.Enabled;
                    MileageTextBoxNew.AutoSize = MileageTextBox.AutoSize;
                    MileageTextBoxNew.Margin = MileageTextBox.Margin;
                    MileageTextBoxNew.Dock = MileageTextBox.Dock;

                    Label IDLabelNew = new Label();
                    IDLabelNew.Anchor = IDLabel.Anchor;
                    IDLabelNew.Text = IDLabel.Text;
                    IDLabelNew.Font = IDLabel.Font;
                    IDLabelNew.AutoSize = IDLabel.AutoSize;
                    IDLabelNew.Margin = IDLabel.Margin;
                    IDLabelNew.Dock = IDLabel.Dock;

                    TextBox IDTextBoxNew = new TextBox();
                    IDTextBoxNew.Anchor = IDTextBox.Anchor;
                    IDTextBoxNew.Font = IDTextBox.Font;
                    IDTextBoxNew.Size = IDTextBox.Size;
                    IDTextBoxNew.Enabled = IDTextBox.Enabled;
                    IDTextBoxNew.AutoSize = IDTextBox.AutoSize;
                    IDTextBoxNew.Margin = IDTextBox.Margin;
                    IDTextBoxNew.Dock = IDTextBox.Dock;

                    Label TransmissionLabelNew = new Label();
                    TransmissionLabelNew.Anchor = TransmissionLabel.Anchor;
                    TransmissionLabelNew.Text = TransmissionLabel.Text;
                    TransmissionLabelNew.Font = TransmissionLabel.Font;
                    TransmissionLabelNew.AutoSize = TransmissionLabel.AutoSize;
                    TransmissionLabelNew.Margin = TransmissionLabel.Margin;
                    TransmissionLabelNew.Dock = TransmissionLabel.Dock;

                    Label DescriptionLabelNew = new Label();
                    DescriptionLabelNew.Anchor = DescriptionLabel.Anchor;
                    DescriptionLabelNew.Text = DescriptionLabel.Text;
                    DescriptionLabelNew.Font = DescriptionLabel.Font;
                    DescriptionLabelNew.AutoSize = DescriptionLabel.AutoSize;
                    DescriptionLabelNew.Margin = DescriptionLabel.Margin;
                    DescriptionLabelNew.Dock = DescriptionLabel.Dock;

                    TextBox DescriptionTextBoxNew = new TextBox();
                    DescriptionTextBoxNew.Anchor = DescriptionTextBox.Anchor;
                    DescriptionTextBoxNew.Font = DescriptionTextBox.Font;
                    DescriptionTextBoxNew.Size = DescriptionTextBox.Size;
                    DescriptionTextBoxNew.Enabled = DescriptionTextBox.Enabled;
                    DescriptionTextBoxNew.Multiline = DescriptionTextBox.Multiline;
                    DescriptionTextBoxNew.AutoSize = DescriptionTextBox.AutoSize;
                    DescriptionTextBoxNew.Margin = DescriptionTextBox.Margin;
                    DescriptionTextBoxNew.Dock = DescriptionTextBox.Dock;
                   

                    Button AddButtonNew = new Button();
                    AddButtonNew.Name = i.ID;
                    AddButtonNew.FlatStyle = AddButton.FlatStyle;
                    AddButtonNew.Font = AddButton.Font;
                    AddButtonNew.Text = AddButton.Text;
                    AddButtonNew.Enabled = AddButton.Enabled;
                    AddButtonNew.Anchor = AddButton.Anchor;
                    AddButtonNew.Size = AddButton.Size;
                    AddButtonNew.BackColor = AddButton.BackColor;
                    AddButtonNew.FlatAppearance.BorderColor = AddButton.FlatAppearance.BorderColor;
                    AddButtonNew.FlatAppearance.BorderSize = AddButton.FlatAppearance.BorderSize;
                    AddButtonNew.Click += AddButton_Click;

                    RadioButton AutTrRadioButtonNew = new RadioButton();
                    AutTrRadioButtonNew.AutoSize = AutTrRadioButton.AutoSize;
                    AutTrRadioButtonNew.Text = AutTrRadioButton.Text;
                    AutTrRadioButtonNew.Anchor = AutTrRadioButton.Anchor;
                    AutTrRadioButtonNew.Enabled = AutTrRadioButton.Enabled;
                    AutTrRadioButtonNew.Font = AutTrRadioButton.Font;
                    AutTrRadioButtonNew.Margin = AutTrRadioButton.Margin;
                    AutTrRadioButtonNew.Dock = AutTrRadioButton.Dock;

                    RadioButton RobTrRadioButtonNew = new RadioButton();
                    RobTrRadioButtonNew.AutoSize = AutTrRadioButton.AutoSize;
                    RobTrRadioButtonNew.Text = RobTrRadioButton.Text;
                    RobTrRadioButtonNew.Anchor = RobTrRadioButton.Anchor;
                    RobTrRadioButtonNew.Enabled = RobTrRadioButton.Enabled;
                    RobTrRadioButtonNew.Font = RobTrRadioButton.Font;
                    RobTrRadioButtonNew.Margin = RobTrRadioButton.Margin;
                    RobTrRadioButtonNew.Dock = RobTrRadioButton.Dock;

                    RadioButton VarTrRadioButtonNew = new RadioButton();
                    VarTrRadioButtonNew.AutoSize = AutTrRadioButton.AutoSize;
                    VarTrRadioButtonNew.Text = VarTrRadioButton.Text;
                    VarTrRadioButtonNew.Anchor = VarTrRadioButton.Anchor;
                    VarTrRadioButtonNew.Enabled = VarTrRadioButton.Enabled;
                    VarTrRadioButtonNew.Font = VarTrRadioButton.Font;
                    VarTrRadioButtonNew.Margin = VarTrRadioButton.Margin;
                    VarTrRadioButtonNew.Dock = VarTrRadioButton.Dock;

                    RadioButton MechTrRadioButtonNew = new RadioButton();
                    MechTrRadioButtonNew.AutoSize = AutTrRadioButton.AutoSize;
                    MechTrRadioButtonNew.Text = MechTrRadioButton.Text;
                    MechTrRadioButtonNew.Anchor = MechTrRadioButton.Anchor;
                    MechTrRadioButtonNew.Enabled = MechTrRadioButton.Enabled;
                    MechTrRadioButtonNew.Font = MechTrRadioButton.Font;
                    MechTrRadioButtonNew.Margin = MechTrRadioButton.Margin;
                    MechTrRadioButtonNew.Dock = MechTrRadioButton.Dock;

                    TableLayoutPanel TransmissionTableNew = new TableLayoutPanel();
                    TransmissionTableNew.Size = TransmissionTableLayoutPanel.Size;
                    TransmissionTableNew.Anchor = TransmissionTableLayoutPanel.Anchor;
                    TransmissionTableNew.Margin = TransmissionTableLayoutPanel.Margin;
                    TransmissionTableNew.AutoSize = TransmissionTableLayoutPanel.AutoSize;
                    TransmissionTableNew.Dock = TransmissionTableLayoutPanel.Dock;
                    TransmissionTableNew.RowCount = TransmissionTableLayoutPanel.RowCount;
                    TransmissionTableNew.ColumnCount = TransmissionTableLayoutPanel.ColumnCount;
                    TransmissionTableNew.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
                    TransmissionTableNew.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
                    TransmissionTableNew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                    TransmissionTableNew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                    TransmissionTableNew.Controls.Add(MechTrRadioButtonNew, 0, 0);
                    TransmissionTableNew.Controls.Add(AutTrRadioButtonNew, 0, 1);
                    TransmissionTableNew.Controls.Add(VarTrRadioButtonNew, 1, 0);
                    TransmissionTableNew.Controls.Add(RobTrRadioButtonNew, 1, 1);

                    TableLayoutPanel automobileInfoTableNew = new TableLayoutPanel();
                    automobileInfoTableNew.Size = automobileInfoTable.Size;
                    automobileInfoTableNew.Anchor = automobileInfoTable.Anchor;
                    automobileInfoTableNew.Margin = automobileInfoTable.Margin;
                    automobileInfoTableNew.AutoSize = automobileInfoTable.AutoSize;
                    automobileInfoTableNew.Dock = automobileInfoTable.Dock;
                    automobileInfoTableNew.RowCount = automobileInfoTable.RowCount;
                    automobileInfoTableNew.ColumnCount = automobileInfoTable.ColumnCount;
                    automobileInfoTableNew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
                    automobileInfoTableNew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29F));
                    automobileInfoTableNew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
                    automobileInfoTableNew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
                    automobileInfoTableNew.Controls.Add(YearLabelNew, 0, 0);
                    automobileInfoTableNew.Controls.Add(ColorLabelNew, 0, 1);
                    automobileInfoTableNew.Controls.Add(MileageLabelNew, 0, 2);
                    automobileInfoTableNew.Controls.Add(EnableLabelNew, 2, 0);
                    automobileInfoTableNew.Controls.Add(EnableDateLabelNew, 2, 1);
                    automobileInfoTableNew.Controls.Add(IDLabelNew, 2, 2);
                    automobileInfoTableNew.Controls.Add(TransmissionLabelNew, 0, 3);
                    automobileInfoTableNew.Controls.Add(DescriptionLabelNew, 0, 4);
                    automobileInfoTableNew.Controls.Add(YearTextBoxNew, 1, 0);
                    automobileInfoTableNew.Controls.Add(ColorTextBoxNew, 1, 1);
                    automobileInfoTableNew.Controls.Add(MileageTextBoxNew, 1, 2);
                    automobileInfoTableNew.Controls.Add(EnableCheckBoxNew, 3, 0);
                    automobileInfoTableNew.Controls.Add(EnableDateTextBoxNew, 3, 1);
                    automobileInfoTableNew.Controls.Add(IDTextBoxNew, 3, 2);
                    automobileInfoTableNew.Controls.Add(TransmissionTableNew, 1, 3);
                    automobileInfoTableNew.Controls.Add(DescriptionTextBoxNew, 1, 4);
                    automobileInfoTableNew.SetColumnSpan(DescriptionTextBoxNew, 3);
                    automobileInfoTableNew.SetColumnSpan(TransmissionTableLayoutPanel, 3);

                    PhotoBoxNew.Image = i.Photo;
                    YearTextBoxNew.Text = i.Year.ToString();
                    ColorTextBoxNew.Text = i.Color;
                    EnableCheckBoxNew.Checked = i.Enable;
                    if (!i.Enable)
                        EnableDateTextBoxNew.Text = i.DateReturn.Date.ToShortDateString();
                    MileageTextBoxNew.Text = i.Mileage.ToString();
                    IDTextBoxNew.Text = i.ID;
                    if (i.Transmission.Equals("механическая"))
                        MechTrRadioButtonNew.Checked = true;
                    else if (i.Transmission.Equals("вариативная"))
                        VarTrRadioButtonNew.Checked = true;
                    else if (i.Transmission.Equals("автоматическая"))
                        AutTrRadioButtonNew.Checked = true;
                    else
                        RobTrRadioButtonNew.Checked = true;

                    automobileListTable.Controls.Add(PhotoBoxNew, 0, j - 1);
                    automobileListTable.Controls.Add(automobileInfoTableNew, 1, j - 1);
                    automobileListTable.Controls.Add(AddButtonNew, 2, j - 1);
                    j++;
                }
            }
            catch (NullReferenceException) {}
        }

        private void AddButton_Click(object sender, EventArgs e)
        {            
            Control btn = (Control)sender;

            Auto openautomobile = new Auto();

            try
            {
                AutoService service = new AutoService(Model.Automobiles);
                openautomobile = service.automobileSearch(btn.Name);
                if (openautomobile.Enable)
                {
                    ClientList clientList = new ClientList(true, openautomobile);
                    clientList.Show();
                }
                else
                {
                    MessageBox.Show("Автомобиля нет в наличии.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Вы пытаетесь добавить несуществующий автомобиль", "", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
           
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            NewAutoOfModel newauto = new NewAutoOfModel(Model);
            newauto.ShowDialog();
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

        public void repaint()
        {
            while (automobileListTable.RowCount > 1)
            {
                int row = automobileListTable.RowCount - 1;
                for (int i = 0; i < automobileListTable.ColumnCount; i++)
                {
                    Control c = automobileListTable.GetControlFromPosition(i, row);
                    automobileListTable.Controls.Remove(c);
                }

                automobileListTable.RowStyles.RemoveAt(row);
                automobileListTable.RowCount--;
                automobileListTable.Height -= 284;
            }
        }

        private void automobileList_Activated(object sender, EventArgs e)
        {
            automobileListTable.Hide();
            repaint();
            ShowList();
            automobileListTable.Show();
        }


        private void ClientListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClientList showClients = new ClientList(true);
            showClients.Show();
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

        private void ReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientList clientcard = new ClientList(false);
            clientcard.setflagCanCount(true);
            clientcard.Show();
        }

        private void AutoList_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }
    }
}
