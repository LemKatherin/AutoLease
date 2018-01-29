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
    public partial class AutoRegistr : Form
    {

        Form checkautomodelwin = new Form();
        List<Auto> autoautomobiles = new List<Auto>(); 

        public AutoRegistr()
        {
            InitializeComponent();        
        }

        public AutoRegistr(Form autoModel)
        {
            InitializeComponent();
            checkautomodelwin = autoModel;
            foreach (string country in AutoListStorage.countryList)
            {
                CountryComboBox.Items.Add(country);
            }
            foreach (AutoCategory category in AutoCategoryListStorage.Categories)
            {
                CategoryComboBox.Items.Add(category.Name);
            }
        }

        public void setNameTextBox2(TextBox name)
        {
            NameTextBox2.Text = name.Text;
        }

        public void setNameTextBox1(ComboBox name)
        {
            NameTextBox1.Text = name.Text;
        }

        private void OpenPhotoButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                PhotoPictureBox.ImageLocation = openFileDialog.FileName;
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            CheckCategory autocategoryregistr = new CheckCategory(false);
            autocategoryregistr.ShowDialog(this);
        }

        private void AddCountryButton_Click(object sender, EventArgs e)
        {
            CountryToAdd countrytoadd = new CountryToAdd();
            countrytoadd.ShowDialog(this);
        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {

            if (NameTextBox2.TextLength != 0 && NameTextBox1.Text.Length != 0 &&
               CountryComboBox.Text.Length != 0 && CategoryComboBox.Text.Length != 0 &&
               SumLeaseMaskedTextBox.MaskFull && PhotoPictureBox.Image != null)
            {
                
                AutoModel car = new AutoModel(NameTextBox1.Text, NameTextBox2.Text, CountryComboBox.Text, AutoCategoryListService.Search(CategoryComboBox.Text),
                    FuelTextBox.Text, Double.Parse(FuelInHourTextBox.Text), Double.Parse(SumLeaseMaskedTextBox.Text.Remove(5, 2)), PhotoPictureBox.Image,AutoListStorage.Cars.Count+1);
                AutoForStorage autoForStorage = new AutoForStorage(car, Convert.ToInt32(CountAutoDomainUpDown.Text));
                AutoModelsListService.CarRegistration(autoForStorage);
                DialogResult result;
                if (Convert.ToInt32(CountAutoDomainUpDown.Text) != 0)
                {
                    result = MessageBox.Show("Регистрация новой модели автомобиля успешно завершена. Желаете зарегестрировать автомобили данной модели?", "",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        for (int i = 1; i <= Convert.ToInt32(CountAutoDomainUpDown.Text); i++)
                        {
                            NewAutoOfModel newauto = new NewAutoOfModel(autoForStorage);
                            newauto.FlagFrom = false;
                            newauto.ShowDialog();
                        }
                    }
                }
                else
                {
                    result = MessageBox.Show("Регистрация новой модели автомобиля успешно завершена", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            else
            { 

                if (NameTextBox2.TextLength == 0)
                    NameTextBox2.BackColor = Color.IndianRed;
                if (NameTextBox1.TextLength == 0)
                    NameTextBox1.BackColor = Color.IndianRed;
                if (FuelInHourTextBox.TextLength == 0)
                    FuelInHourTextBox.BackColor = Color.IndianRed;
                if (FuelTextBox.TextLength == 0)
                    FuelTextBox.BackColor = Color.IndianRed;             
                if (CountryComboBox.Text.Length == 0)
                    CountryComboBox.BackColor = Color.IndianRed;
                if (CategoryComboBox.Text.Length == 0)
                    CategoryComboBox.BackColor = Color.IndianRed;
                if (!SumLeaseMaskedTextBox.MaskFull)
                    SumLeaseMaskedTextBox.BackColor = Color.IndianRed;           
                if (PhotoPictureBox.Image == null)
                    PhotoPictureBox.BackColor = Color.IndianRed;
            }
        }

        private void SumLeaseMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SumLeaseMaskedTextBox.BackColor == Color.IndianRed)
                SumLeaseMaskedTextBox.BackColor = Color.White;
        }



        private void PhotoPictureBox_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (PhotoPictureBox.BackColor == Color.IndianRed)
                PhotoPictureBox.BackColor = this.BackColor;
        }

        private void NameTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (NameTextBox2.BackColor == Color.IndianRed)
                NameTextBox2.BackColor = Color.White;
        }

        private void NameTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (NameTextBox1.BackColor == Color.IndianRed)
                NameTextBox1.BackColor = Color.White;
        }

        private void AutoRegistr_FormClosed(object sender, FormClosedEventArgs e)
        {
           WorkingClass.WorkingMenu.Show();
           checkautomodelwin.Close();
        }

        private void FuelTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FuelTextBox.BackColor == Color.IndianRed)
                FuelTextBox.BackColor = Color.White;
        }

        private void FuelInHourTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FuelInHourTextBox.BackColor == Color.IndianRed)
                FuelInHourTextBox.BackColor = Color.White;
        }



        private void AutoRegistr_Activated(object sender, EventArgs e)
        {
            CategoryComboBox.Items.Clear();
            foreach (AutoCategory categ in AutoCategoryListStorage.Categories)
            {
                CategoryComboBox.Items.Add(categ.Name);
            }
            CountryComboBox.Items.Clear();
            foreach (string country in AutoListStorage.countryList)
            {
                CountryComboBox.Items.Add(country);
            }
        }

        private void CategoryComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CountryComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;

        }

        private void CountryComboBox_TextChanged(object sender, EventArgs e)
        {
            if (CountryComboBox.BackColor == Color.IndianRed)
                CountryComboBox.BackColor = Color.White;

            //var findCountries = from country in startMenu.carList.countryList
            //                    where country.StartsWith(CountryComboBox.Text)
            //                    select country;
            //if (findCountries != null)
            //{
            //    CountryComboBox.Items.AddRange(findCountries.ToArray<String>());
            //    CountryComboBox.DroppedDown = true;
            //}
        }

        private void CategoryComboBox_TextChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.BackColor == Color.IndianRed)
                CategoryComboBox.BackColor = Color.White;
        }

        private void FuelInHourTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void FuelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            //    e.Handled = true;
        }
    }

}

