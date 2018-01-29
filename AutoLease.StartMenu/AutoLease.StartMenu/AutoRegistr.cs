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
    public partial class AutoRegistr : Form
    {
        public AutoRegistr()
        {
            InitializeComponent();        
        }

        Form checkautomodelwin = new Form();

        public void setNameTextBox2(TextBox name)
        {
            NameTextBox2.Text = name.Text;
        }

        public void setNameTextBox1(ComboBox name)
        {
            NameTextBox1.Text = name.Text;
        }

        public void setCheckAutoModelWin(Form win)
        {
            checkautomodelwin = win;
        }

        private void OpenPhotoButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                PhotoPictureBox.ImageLocation = openFileDialog.FileName;
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            CheckCategory autocategoryregistr = new CheckCategory();
            autocategoryregistr.Show();
        }

        private void AddCountryButton_Click(object sender, EventArgs e)
        {
            CountryToAdd countrytoadd = new CountryToAdd();
            countrytoadd.setAutoRegistrWin(this);
            countrytoadd.Show();
        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {

            if (NameTextBox2.TextLength != 0 && NameTextBox1.Text.Length !=0 &&
                CountryComboBox.Text.Length != 0 && CategoryComboBox.Text.Length != 0 &&
                SumLeaseMaskedTextBox.MaskFull && PhotoPictureBox.Image != null && DescriptionTextBox.TextLength!=0)
            {

                MessageBox.Show("Регистрация новой модели автомобиля успешно завершена", "",MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (!MechTrRadioButton.Checked && !AutTrRadioButton.Checked &&
                    !VarTrRadioButton.Checked && !RobTrRadioButton.Checked)
                    TransmissionErrorProvider.SetError(TransmissiomLabel, "Выберите тип коробки передач");
                if (CountryComboBox.Text.Length == 0)
                    CountryComboBox.BackColor = Color.IndianRed;
                if (CategoryComboBox.Text.Length == 0)
                    CategoryComboBox.BackColor = Color.IndianRed;
                if (!SumLeaseMaskedTextBox.MaskFull)
                    SumLeaseMaskedTextBox.BackColor = Color.IndianRed;           
                if (PhotoPictureBox.Image == null)
                    PhotoPictureBox.BackColor = Color.IndianRed;
                if (DescriptionTextBox.TextLength == 0)
                    DescriptionTextBox.BackColor = Color.IndianRed;
            }
        }



        private void CountryComboBox_TextUpdate(object sender, EventArgs e)
        {
           if(CountryComboBox.BackColor==Color.IndianRed)
                CountryComboBox.BackColor = Color.White;
        }

        private void CategoryComboBox_TextUpdate(object sender, EventArgs e)
        {
            if(CategoryComboBox.BackColor == Color.IndianRed)
                CategoryComboBox.BackColor = Color.White;
        }


        private void SumLeaseMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SumLeaseMaskedTextBox.BackColor == Color.IndianRed)
                SumLeaseMaskedTextBox.BackColor = Color.White;
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DescriptionTextBox.BackColor == Color.IndianRed)
                DescriptionTextBox.BackColor = Color.White;
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
            StartMenu startmenu = new StartMenu();
            startmenu.Show();
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

        private void MechTrRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MechTrRadioButton.Checked)
                TransmissionErrorProvider.Clear();
        }

        private void RobTrRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RobTrRadioButton.Checked)
                TransmissionErrorProvider.Clear();
        }

        private void VarTrRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (VarTrRadioButton.Checked)
                TransmissionErrorProvider.Clear();
        }

        private void AutTrRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AutTrRadioButton.Checked)
                TransmissionErrorProvider.Clear();
        }
    }



        //public void setCounryComboBoxItem(TextBox name)
        //{        
        //    if(!CountryComboBox.Items.Contains(name.Text))
        //        CountryComboBox.Items.Add(name.Text);
        //    else
        //    {
        //        CantAddCountry cantaddwin = new CantAddCountry();               
        //        cantaddwin.Show();
        //    }
        //}


    }

