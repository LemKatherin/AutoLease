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
    public partial class CopyList : Form
    {
        StartMenu startMenu = new StartMenu();
        Auto Model = new Auto();
        
        public CopyList()
        {
            InitializeComponent();
            ClientsToolStripTextBox.Text = ClientListStorage.Clients.Count.ToString();
            int sum = 0;
            foreach (Auto auto in AutoListStorage.Cars)
            {
                sum += auto.Copies.Count;
            }
            AutoToolStripTextBox.Text = sum.ToString();
            DateToolStripTextBox.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
        }

        public CopyList(bool CanAdd, StartMenu menu, Auto model)
        {
            InitializeComponent();

            AddButton1.Enabled = !CanAdd;
            AddNewButton.Enabled = CanAdd;
            startMenu = menu;
            Model = model;
            LeaseToolStripMenuItem.Enabled = CanAdd;
            ShowList();

        }
        public CopyList(bool CanAdd, StartMenu menu)
        {
            InitializeComponent();

            AddButton1.Enabled = !CanAdd;
            AddNewButton.Enabled = CanAdd;
            startMenu = menu;
            LeaseToolStripMenuItem.Enabled = CanAdd;
            

        }

        public void ShowList()   
        {
            int j = 1;
            foreach (AutoCopy i in Model.Copies)
            {
                if (j == 1)
                {
                    PhotoPictureBox.Image = i.Photo;
                    YearTextBox.Text = i.Year.ToString();
                    ColorTextBox.Text = i.Color;
                    EnableCheckBox.Checked = i.Enable;
                    MileageTextBox.Text = i.Mileage.ToString();
                    IDTextBox.Text = i.ID;                    
                    j++;
                    continue;
                }

                copyListTable.RowCount = ++copyListTable.RowCount;
                copyListTable.Size = new System.Drawing.Size(copyListTable.Width, this.copyListTable.Size.Height + 174);
                copyListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 174));

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

                TextBox YearTextBoxNew = new TextBox();
                YearTextBoxNew.Anchor = YearTextBox.Anchor;
                YearTextBoxNew.Font = YearTextBox.Font;
                YearTextBoxNew.Size = YearTextBox.Size;
                YearTextBoxNew.Enabled = YearTextBox.Enabled;

                Label ColorLabelNew = new Label();
                ColorLabelNew.Anchor = ColorLabel.Anchor;
                ColorLabelNew.Text = ColorLabel.Text;
                ColorLabelNew.Font = ColorLabel.Font;
                ColorLabelNew.AutoSize = ColorLabel.AutoSize;

                TextBox ColorTextBoxNew = new TextBox();
                ColorTextBoxNew.Anchor = ColorTextBox.Anchor;
                ColorTextBoxNew.Font = ColorTextBox.Font;
                ColorTextBoxNew.Size = ColorTextBox.Size;
                ColorTextBoxNew.Enabled = ColorTextBox.Enabled;

                Label EnableLabelNew = new Label();
                EnableLabelNew.Anchor = EnableLabel.Anchor;
                EnableLabelNew.Text = EnableLabel.Text;
                EnableLabelNew.Font = EnableLabel.Font;
                EnableLabelNew.AutoSize = EnableLabel.AutoSize;

                CheckBox EnableCheckBoxNew = new CheckBox();
                EnableCheckBoxNew.Anchor = EnableCheckBox.Anchor;
                EnableCheckBoxNew.Text = EnableCheckBox.Text;
                EnableCheckBoxNew.Enabled = EnableCheckBox.Enabled;

                Label MileageLabelNew = new Label();
                MileageLabelNew.Anchor = MileageLabel.Anchor;
                MileageLabelNew.Text = MileageLabel.Text;
                MileageLabelNew.Font = MileageLabel.Font;
                MileageLabelNew.AutoSize = MileageLabel.AutoSize;

                TextBox MileageTextBoxNew = new TextBox();
                MileageTextBoxNew.Anchor = MileageTextBox.Anchor;
                MileageTextBoxNew.Font = MileageTextBox.Font;
                MileageTextBoxNew.Size = MileageTextBox.Size;
                MileageTextBoxNew.Enabled = MileageTextBox.Enabled;

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

               

                Button  AddButtonNew = new Button();
                AddButtonNew.Name = "AddButton" + j.ToString();
                AddButtonNew.FlatStyle = AddButton1.FlatStyle;
                AddButtonNew.Font = AddButton1.Font;
                AddButtonNew.Text = AddButton1.Text;
                AddButtonNew.Enabled = AddButton1.Enabled;
                AddButtonNew.Anchor = AddButton1.Anchor;
                AddButtonNew.Size = AddButton1.Size;
                AddButtonNew.BackColor = AddButton1.BackColor;
                AddButtonNew.FlatAppearance.BorderColor = AddButton1.FlatAppearance.BorderColor;
                AddButtonNew.FlatAppearance.BorderSize = AddButton1.FlatAppearance.BorderSize;
                AddButtonNew.Click += AddButton_Click;

                TableLayoutPanel copyInfoTableleNew = new TableLayoutPanel();
                copyInfoTableleNew.Size = copyInfoTable.Size;
                copyInfoTableleNew.Anchor = copyInfoTable.Anchor;
                copyInfoTableleNew.RowCount = copyInfoTable.RowCount;
                copyInfoTableleNew.ColumnCount = copyInfoTable.ColumnCount;
                copyInfoTableleNew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
                copyInfoTableleNew.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
                copyInfoTableleNew.Controls.Add(YearLabelNew, 0, 0);
                copyInfoTableleNew.Controls.Add(ColorLabelNew, 0, 1);
                copyInfoTableleNew.Controls.Add(EnableLabelNew, 0, 2);
                copyInfoTableleNew.Controls.Add(MileageLabelNew, 0, 3);
                copyInfoTableleNew.Controls.Add(IDLabelNew, 0, 4);
                copyInfoTableleNew.Controls.Add(YearTextBoxNew, 1, 0);
                copyInfoTableleNew.Controls.Add(ColorTextBoxNew, 1, 1);
                copyInfoTableleNew.Controls.Add(EnableCheckBoxNew, 1, 2);
                copyInfoTableleNew.Controls.Add(MileageTextBoxNew, 1, 3);
                copyInfoTableleNew.Controls.Add(IDTextBoxNew, 1, 4);

                PhotoBoxNew.Image = i.Photo;
                YearTextBoxNew.Text = i.Year.ToString();
                ColorTextBoxNew.Text = i.Color;
                EnableCheckBoxNew.Checked = i.Enable;
                MileageTextBoxNew.Text = i.Mileage.ToString();
                IDTextBoxNew.Text = i.ID;

                copyListTable.Controls.Add(PhotoBoxNew, 0, j - 1);
                copyListTable.Controls.Add(copyInfoTableleNew, 1, j - 1);
                copyListTable.Controls.Add(AddButtonNew, 2, j - 1);
                j++;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition pos = copyListTable.GetPositionFromControl((Control)sender);
            Control btn = (Control)sender;
            Control tableTemp = copyListTable.GetControlFromPosition(1, Convert.ToInt32(btn.Name.Remove(0, 9)) - 1);
            TableLayoutPanel table = (TableLayoutPanel)tableTemp;

            AutoCopy openCopy = new AutoCopy();
            AutoCopyService service = new AutoCopyService(Model.Copies);
            openCopy = service.CopySearch(table.GetControlFromPosition(1,4).Text);
            try
            {
                if (openCopy.Enable)
                {
                    openCopy.Enable = false;
                    ClientList clientcard = new ClientList(startMenu, true, openCopy);
                    clientcard.Show();
                }
                else
                {
                    MessageBox.Show("Автомобиля нет в наличии.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Вы пытаетесь добавить несуществующий автомобиль", "", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            NewAutoOfModel newauto = new NewAutoOfModel(startMenu, Model);
            newauto.ShowDialog();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ClientsToolStripTextBox.Text = ClientListStorage.Clients.Count.ToString();
            int sum = 0;
            foreach (Auto auto in AutoListStorage.Cars)
            {
                sum += auto.Copies.Count;
            }
            AutoToolStripTextBox.Text = sum.ToString();
            DateToolStripTextBox.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
        }
        public void repaint()
        {
            while (copyListTable.RowCount > 1)
            {
                int row = copyListTable.RowCount - 1;
                for (int i = 0; i < copyListTable.ColumnCount; i++)
                {
                    Control c = copyListTable.GetControlFromPosition(i, row);
                    copyListTable.Controls.Remove(c);
                }

                copyListTable.RowStyles.RemoveAt(row);
                copyListTable.RowCount--;
                copyListTable.Height -= 174;
            }
        }
        private void CopyList_Activated(object sender, EventArgs e)
        {
            copyListTable.Hide();
            repaint();
            ShowList();
            copyListTable.Show();
        }

        private void AutoListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AutoList autoList = new AutoList(true, false, startMenu);
            autoList.Show();
        }

        private void ClientListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClientList showClients = new ClientList(startMenu, true);
            showClients.Show();
        }

        private void ClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckClient clientRegistr = new CheckClient(startMenu);
            clientRegistr.ShowDialog();
        }

        private void AutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckAutoModel autoRegistr = new CheckAutoModel(startMenu);
            autoRegistr.ShowDialog();
        }

        private void CategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckCategory autoRegistr = new CheckCategory(startMenu, false);
            autoRegistr.ShowDialog();
        }

        private void LeaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoList autoLease = new AutoList(false, true, startMenu);
            autoLease.Show();
        }

        private void ReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientList clientcard = new ClientList(startMenu, false);
            clientcard.setflagCanCount(true);
            clientcard.Show();
        }
    }
}
