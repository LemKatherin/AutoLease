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
    public partial class AutoModelList : Form
    {
        bool flagCanAdd = false;
   

        public AutoModelList()
        {
            InitializeComponent();
        }

        public AutoModelList(bool CanAdd) : this()
        {   
            flagCanAdd = CanAdd;
            ShowList(AutoListStorage.Cars);
        }

        private void AutoList_FormClosed(object sender, FormClosedEventArgs e)
        {
            WorkingClass.WorkingMenu.Show();
        }

        public void repaint()
        {
            while (autoListTable.RowCount > 1)
            {
                int row = autoListTable.RowCount - 1;
                for (int i = 0; i < autoListTable.ColumnCount; i++)
                {
                    Control c = autoListTable.GetControlFromPosition(i, row);
                    autoListTable.Controls.Remove(c);
                }

                autoListTable.RowStyles.RemoveAt(row);
                autoListTable.RowCount--;
                autoListTable.Height -= 120;
            }
        }

        public void ShowList(List<AutoForStorage> list)
        {
            int j = 1;
            try
            {
                foreach (AutoForStorage i in list)
                {
                    if (j == 1)
                    {
                        ModelTextBox.Text = i.ThisAutoModel.Mark + " " + i.ThisAutoModel.Model;
                        CountryTextBox.Text = i.ThisAutoModel.Country;
                        CategoryTextBox.Text = i.ThisAutoModel.Category.Name;
                        CountAutoTextBox.Text = i.Automobiles.Count.ToString();
                        SumLeaseTextBox.Text = i.ThisAutoModel.SumLease.ToString();
                        AutoPhotoBox.Image = i.ThisAutoModel.AutoPhoto;
                        OpenAllButton.Name = i.ThisAutoModel.Mark + " " + i.ThisAutoModel.Model;
                        OpenInfoButton.Name = "info" + i.ThisAutoModel.Mark + " " + i.ThisAutoModel.Model;
                        j++;
                        continue;
                    }

                    autoListTable.RowCount = ++autoListTable.RowCount;
                    autoListTable.Size = new System.Drawing.Size(autoListTable.Width, this.autoListTable.Size.Height + 120);
                    autoListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120));

                    PictureBox AutoPhotoBoxNew = new PictureBox();
                    AutoPhotoBoxNew.Size = AutoPhotoBox.Size;
                    AutoPhotoBoxNew.Anchor = AutoPhotoBox.Anchor;
                    AutoPhotoBoxNew.Location = AutoPhotoBox.Location;
                    AutoPhotoBoxNew.SizeMode = AutoPhotoBox.SizeMode;
                    AutoPhotoBoxNew.BorderStyle = AutoPhotoBox.BorderStyle;
                    AutoPhotoBoxNew.Enabled = AutoPhotoBox.Enabled;
                    AutoPhotoBoxNew.Visible = true;

                    Label ModelLabelNew = new Label();
                    ModelLabelNew.Anchor = ModelLabel.Anchor;
                    ModelLabelNew.Text = ModelLabel.Text;
                    ModelLabelNew.Font = ModelLabel.Font;
                    ModelLabelNew.Margin = ModelLabel.Margin;
                    ModelLabelNew.AutoSize = ModelLabel.AutoSize;
                    ModelLabelNew.Dock = ModelLabel.Dock;

                    TextBox ModelTextBoxNew = new TextBox();
                    ModelTextBoxNew.Anchor = ModelTextBox.Anchor;
                    ModelTextBoxNew.Font = ModelTextBox.Font;
                    ModelTextBoxNew.Size = ModelTextBox.Size;
                    ModelTextBoxNew.Enabled = ModelTextBox.Enabled;
                    ModelTextBoxNew.Margin = ModelTextBox.Margin;
                    ModelTextBoxNew.AutoSize = ModelTextBox.AutoSize;
                    ModelTextBoxNew.Dock = ModelTextBox.Dock;

                    Label CountryLabelNew = new Label();
                    CountryLabelNew.Anchor = CountryLabel.Anchor;
                    CountryLabelNew.Text = CountryLabel.Text;
                    CountryLabelNew.Font = CountryLabel.Font;
                    CountryLabelNew.Margin = CountryLabel.Margin;
                    CountryLabelNew.AutoSize = CountryLabel.AutoSize;
                    CountryLabelNew.Dock = CountryLabel.Dock;

                    TextBox CountryTextBoxNew = new TextBox();
                    CountryTextBoxNew.Anchor = CountryTextBox.Anchor;
                    CountryTextBoxNew.Font = CountryTextBox.Font;
                    CountryTextBoxNew.Size = CountryTextBox.Size;
                    CountryTextBoxNew.Enabled = CountryTextBox.Enabled;
                    CountryTextBoxNew.Margin = CountryTextBox.Margin;
                    CountryTextBoxNew.AutoSize = CountryTextBox.AutoSize;
                    CountryTextBoxNew.Dock = CountryTextBox.Dock;

                    Label CategoryLabelNew = new Label();
                    CategoryLabelNew.Anchor = CategoryLabel.Anchor;
                    CategoryLabelNew.Text = CategoryLabel.Text;
                    CategoryLabelNew.Font = CategoryLabel.Font;
                    CategoryLabelNew.Margin = CategoryLabel.Margin;
                    CategoryLabelNew.AutoSize = CategoryLabel.AutoSize;
                    CategoryLabelNew.Dock = CategoryLabel.Dock;

                    TextBox CategoryTextBoxNew = new TextBox();
                    CategoryTextBoxNew.Anchor = CategoryTextBox.Anchor;
                    CategoryTextBoxNew.Font = CategoryTextBox.Font;
                    CategoryTextBoxNew.Size = CategoryTextBox.Size;
                    CategoryTextBoxNew.Enabled = CategoryTextBox.Enabled;
                    CategoryTextBoxNew.Margin = CategoryTextBox.Margin;
                    CategoryTextBoxNew.AutoSize = CategoryTextBox.AutoSize;
                    CategoryTextBoxNew.Dock = CategoryTextBox.Dock;

                    Label CountAutoLabelNew = new Label();
                    CountAutoLabelNew.Anchor = CountAutoLabel.Anchor;
                    CountAutoLabelNew.Text = CountAutoLabel.Text;
                    CountAutoLabelNew.Font = CountAutoLabel.Font;
                    CountAutoLabelNew.Margin = CountAutoLabel.Margin;
                    CountAutoLabelNew.AutoSize = CountAutoLabel.AutoSize;
                    CountAutoLabelNew.Dock = CountAutoLabel.Dock;

                    TextBox CountAutoTextBoxNew = new TextBox();
                    CountAutoTextBoxNew.Anchor = CountAutoTextBox.Anchor;
                    CountAutoTextBoxNew.Font = CountAutoTextBox.Font;
                    CountAutoTextBoxNew.Size = CountAutoTextBox.Size;
                    CountAutoTextBoxNew.Enabled = CountAutoTextBox.Enabled;
                    CountAutoTextBoxNew.Margin = CountAutoTextBox.Margin;
                    CountAutoTextBoxNew.AutoSize = CountAutoTextBox.AutoSize;
                    CountAutoTextBoxNew.Dock = CountAutoTextBox.Dock;

                    Label SumLeaseLabelNew = new Label();
                    SumLeaseLabelNew.Anchor = SumLeaseLabel.Anchor;
                    SumLeaseLabelNew.Text = SumLeaseLabel.Text;
                    SumLeaseLabelNew.Font = SumLeaseLabel.Font;
                    SumLeaseLabelNew.Margin = SumLeaseLabel.Margin;
                    SumLeaseLabelNew.AutoSize = SumLeaseLabel.AutoSize;
                    SumLeaseLabelNew.Dock = SumLeaseLabel.Dock;

                    TextBox SumLeaseTextBoxNew = new TextBox();
                    SumLeaseTextBoxNew.Anchor = SumLeaseTextBox.Anchor;
                    SumLeaseTextBoxNew.Font = SumLeaseTextBox.Font;
                    SumLeaseTextBoxNew.Size = SumLeaseTextBox.Size;
                    SumLeaseTextBoxNew.Enabled = SumLeaseTextBox.Enabled;
                    SumLeaseTextBoxNew.Margin = SumLeaseTextBox.Margin;
                    SumLeaseTextBoxNew.AutoSize = SumLeaseTextBox.AutoSize;
                    SumLeaseTextBoxNew.Dock = SumLeaseTextBox.Dock;

                    Button OpenInfoButtonNew = new Button();
                    OpenInfoButtonNew.Name = "info" + i.ThisAutoModel.Mark + " " + i.ThisAutoModel.Model;
                    OpenInfoButtonNew.FlatStyle = OpenInfoButton.FlatStyle;
                    OpenInfoButtonNew.Font = OpenInfoButton.Font;
                    OpenInfoButtonNew.Text = OpenInfoButton.Text;
                    OpenInfoButtonNew.Enabled = OpenInfoButton.Enabled;
                    OpenInfoButtonNew.Anchor = OpenInfoButton.Anchor;
                    OpenInfoButtonNew.Size = OpenInfoButton.Size;
                    OpenInfoButtonNew.BackColor = OpenInfoButton.BackColor;
                    OpenInfoButtonNew.FlatAppearance.BorderColor = OpenInfoButton.FlatAppearance.BorderColor;
                    OpenInfoButtonNew.FlatAppearance.BorderSize = OpenInfoButton.FlatAppearance.BorderSize;
                    OpenInfoButtonNew.Click += OpenInfoButton_Click;


                    Button OpenAllButtonNew = new Button();
                    OpenAllButtonNew.Name = i.ThisAutoModel.Mark + " " + i.ThisAutoModel.Model;
                    OpenAllButtonNew.FlatStyle = OpenAllButton.FlatStyle;
                    OpenAllButtonNew.Font = OpenAllButton.Font;
                    OpenAllButtonNew.Text = OpenAllButton.Text;
                    OpenAllButtonNew.Anchor = OpenAllButton.Anchor;
                    OpenAllButtonNew.Size = OpenAllButton.Size;
                    OpenAllButtonNew.BackColor = OpenAllButton.BackColor;
                    OpenAllButtonNew.FlatAppearance.BorderColor = OpenAllButton.FlatAppearance.BorderColor;
                    OpenAllButtonNew.FlatAppearance.BorderSize = OpenAllButton.FlatAppearance.BorderSize;
                    OpenAllButtonNew.Click += OpenAllButton_Click;



                    TableLayoutPanel AutoInfoTableleNew = new TableLayoutPanel();
                    AutoInfoTableleNew.Size = AutoInfoTable.Size;
                    AutoInfoTableleNew.Anchor = AutoInfoTable.Anchor;
                    AutoInfoTableleNew.Margin = AutoInfoTable.Margin;
                    AutoInfoTableleNew.AutoSize = AutoInfoTable.AutoSize;
                    AutoInfoTableleNew.Dock = AutoInfoTable.Dock;
                    AutoInfoTableleNew.RowCount = AutoInfoTable.RowCount;
                    AutoInfoTableleNew.ColumnCount = AutoInfoTable.ColumnCount;
                    AutoInfoTableleNew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
                    AutoInfoTableleNew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
                    AutoInfoTableleNew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
                    AutoInfoTableleNew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
                    AutoInfoTableleNew.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
                    AutoInfoTableleNew.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
                    AutoInfoTableleNew.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
                    AutoInfoTableleNew.Controls.Add(ModelLabelNew, 0, 0);
                    AutoInfoTableleNew.Controls.Add(CountryLabelNew, 0, 1);
                    AutoInfoTableleNew.Controls.Add(CategoryLabelNew, 0, 2);
                    AutoInfoTableleNew.Controls.Add(ModelTextBoxNew, 1, 0);
                    AutoInfoTableleNew.Controls.Add(CountryTextBoxNew, 1, 1);
                    AutoInfoTableleNew.Controls.Add(CategoryTextBoxNew, 1, 2);
                    AutoInfoTableleNew.Controls.Add(CountAutoLabelNew, 2, 0);
                    AutoInfoTableleNew.Controls.Add(SumLeaseLabelNew, 2, 1);
                    AutoInfoTableleNew.Controls.Add(CountAutoTextBoxNew, 3, 0);
                    AutoInfoTableleNew.Controls.Add(SumLeaseTextBoxNew, 3, 1);

                    TableLayoutPanel ButtonsTableNew = new TableLayoutPanel();
                    ButtonsTableNew.Anchor = AutoButtonsTable.Anchor;
                    ButtonsTableNew.Size = AutoButtonsTable.Size;
                    ButtonsTableNew.RowCount = AutoButtonsTable.RowCount;
                    ButtonsTableNew.ColumnCount = AutoButtonsTable.ColumnCount;
                    ButtonsTableNew.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
                    ButtonsTableNew.Controls.Add(OpenInfoButtonNew, 0, 0);
                    ButtonsTableNew.Controls.Add(OpenAllButtonNew, 0, 1);


                    ModelTextBoxNew.Text = i.ThisAutoModel.Mark + " " + i.ThisAutoModel.Model;
                    CountryTextBoxNew.Text = i.ThisAutoModel.Country;
                    CategoryTextBoxNew.Text = i.ThisAutoModel.Category.Name;
                    CountAutoTextBoxNew.Text = i.Automobiles.Count.ToString();
                    SumLeaseTextBoxNew.Text = i.ThisAutoModel.SumLease.ToString();
                    AutoPhotoBoxNew.Image = i.ThisAutoModel.AutoPhoto;

                    autoListTable.Controls.Add(AutoPhotoBoxNew, 0, j - 1);
                    autoListTable.Controls.Add(AutoInfoTableleNew, 1, j - 1);
                    autoListTable.Controls.Add(ButtonsTableNew, 2, j - 1);
                    j++;
                }
            }
            catch (NullReferenceException) { }
        }

        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!CategoryRadioButton.Checked && !ModelRadioButton.Checked && !MarkRadioButton.Checked)
                e.Handled = true;
           else if(CategoryRadioButton.Checked)
            {
                if ((!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) ||
               (SearchTextBox.TextLength > 0 && char.IsUpper(e.KeyChar)))
                    e.Handled = true;
            }
            else if(MarkRadioButton.Checked)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) 
                    e.Handled = true;
            }
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.TextLength == 0)
                MessageBox.Show("Введите данные для поиска", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                List<AutoForStorage> searchedCars = new List<AutoForStorage>(0);
                if (ModelRadioButton.Checked)
                    searchedCars = AutoModelsListService.CarSearch(1, SearchTextBox.Text).ToList();
                else if (CategoryRadioButton.Checked)
                    searchedCars = AutoModelsListService.CarSearch(2, SearchTextBox.Text).ToList();
                else if(MarkRadioButton.Checked)
                    searchedCars = AutoModelsListService.CarSearch(3, SearchTextBox.Text).ToList();

                autoListTable.Hide();
                repaint();

                if (searchedCars.Count == 0)
                {
                    MessageBox.Show("Такие автомобили не найдены.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowList(AutoListStorage.Cars);
                }
                else
                    ShowList(searchedCars);
                autoListTable.Show();
            }
        }

        private void ModelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ModelRadioButton.Checked)
            {
                SearchTextBox.Clear();
            }
        }

        private void CategoryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CategoryRadioButton.Checked)
            {
                SearchTextBox.Clear();
            }
        }

        private void OpenAllButton_Click(object sender, EventArgs e)
        {
            Control btn = (Control)sender;

            AutoForStorage openCar = new AutoForStorage();
            openCar = AutoModelsListService.CarSearch(btn.Name);

            if (openCar != null)
            {
                AutoList automobilelist = new AutoList(flagCanAdd, openCar);
                automobilelist.Show();
            }
            else
            {
                AutoList automobilelist = new AutoList(flagCanAdd);
                automobilelist.Show();
            }
            //this.Refresh();
        }

        private void OpenInfoButton_Click(object sender, EventArgs e)
        {
            Control btn = (Control)sender;
        
            AutoForStorage openCar = new AutoForStorage();
            openCar = AutoModelsListService.CarSearch(btn.Name.Remove(0,4));

            if (openCar != null)
            {             
                AutoCard autocard = new AutoCard(openCar.ThisAutoModel.Mark,openCar.ThisAutoModel.Model,openCar.ThisAutoModel.Country,openCar.ThisAutoModel.Category.Name,
                    openCar.ThisAutoModel.Fuel,openCar.ThisAutoModel.FuelPerHour.ToString(),openCar.ThisAutoModel.SumLease.ToString(),openCar.CarsAmount.ToString(),openCar.ThisAutoModel.AutoPhoto);
                autocard.Show();
            }
            else
            {
                AutoCard autocard = new AutoCard();
                autocard.Show();
            }
            
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

        private void MarkRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MarkRadioButton.Checked)
            {
                SearchTextBox.Clear();
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.TextLength == 0)
            {
                autoListTable.Hide();
                repaint();
                ShowList(AutoListStorage.Cars);
                autoListTable.Show();
            }
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
            CheckCategory categoryRegistr = new CheckCategory(false);
            categoryRegistr.ShowDialog();

        }

        private void ReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientList clientList = new ClientList(false);
            clientList.setflagCanCount(true);
            clientList.Show();
        }

        private void AutoModelList_Activated(object sender, EventArgs e)
        {
            autoListTable.Hide();
            repaint();
            ShowList(AutoListStorage.Cars);
            autoListTable.Show();
        }
    }
}
