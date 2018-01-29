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
    public partial class NewAutoOfModel : Form
    {
        AutoForStorage Model = new AutoForStorage();
        public bool FlagFrom { get; set; } = true;

        public NewAutoOfModel()
        {
            InitializeComponent();
        }

        public NewAutoOfModel(AutoForStorage model)
        {
            InitializeComponent();
            Model = model;
        }

        private void OpenPhotoButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                PhotoPictureBox.ImageLocation = openFileDialog.FileName;
        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {
            try
            {
                Model.ThisAutoModel.Mark.Equals("");
                if (ProductYearMaskedTextBox.MaskFull && ColorTextBox.TextLength != 0 &&
                MileAgeTextBox.TextLength != 0 &&
                Convert.ToInt32(ProductYearMaskedTextBox.Text.Remove(5, 2)) <= DateTime.Today.Date.Year &&
                 Convert.ToInt32(ProductYearMaskedTextBox.Text.Remove(5, 2)) >= 1700 && DescriptionTextBox.TextLength != 0)
                {
                    String transmission;
                    if (MechTrRadioButton.Checked)
                        transmission = "механическая";
                    else if (VarTrRadioButton.Checked)
                        transmission = "вариативная";
                    else if (AutTrRadioButton.Checked)
                        transmission = "автоматическая";
                    else transmission = "роботизированная";
                    if (FlagFrom)
                        Model.CarsAmount++;

                    Auto autoautomobile = new Auto(Convert.ToInt32(ProductYearMaskedTextBox.Text.Remove(4, 3)), ColorTextBox.Text, MileAgeTextBox.Text,
                        Model.Automobiles.Count + 1, PhotoPictureBox.Image, transmission, DescriptionTextBox.Text, Model.ThisAutoModel);

                    AutoService service = new AutoService(Model);
                    autoautomobile.ID = service.generateID();

                    service.automobileRegistration(autoautomobile);
                    MessageBox.Show("Новый автомобиль успешно добавлен.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    if (Convert.ToInt32(ProductYearMaskedTextBox.Text.Remove(5, 2)) > DateTime.Today.Date.Year ||
                     Convert.ToInt32(ProductYearMaskedTextBox.Text.Remove(5, 2)) <= 1700)
                        ErrorProvider.SetError(ProductYearMaskedTextBox, "проверьте введенный год");

                    if (ColorTextBox.TextLength == 0)
                        ColorTextBox.BackColor = Color.IndianRed;
                    if (MileAgeTextBox.TextLength == 0)
                        MileAgeTextBox.BackColor = Color.IndianRed;
                    if (!ProductYearMaskedTextBox.MaskFull)
                        ProductYearMaskedTextBox.BackColor = Color.IndianRed;
                    if (PhotoPictureBox.Image == null)
                        PhotoPictureBox.BackColor = Color.IndianRed;
                    if (!MechTrRadioButton.Checked && !AutTrRadioButton.Checked &&
                      !VarTrRadioButton.Checked && !RobTrRadioButton.Checked)
                        TransmissionErrorProvider.SetError(TransmissiomLabel, "Выберите тип коробки передач");
                    if (DescriptionTextBox.TextLength == 0)
                        DescriptionTextBox.BackColor = Color.IndianRed;
                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Вы пытаетесь добавить автомобиль несуществующей модели", " ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
            }           
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ColorTextBox.BackColor == Color.IndianRed)
                ColorTextBox.BackColor = Color.White;
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DescriptionTextBox.BackColor == Color.IndianRed)
                DescriptionTextBox.BackColor = Color.White;
        }

        private void MileAgeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MileAgeTextBox.BackColor == Color.IndianRed)
                MileAgeTextBox.BackColor = Color.White;
        }

        private void ProductYearMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ProductYearMaskedTextBox.BackColor == Color.IndianRed)
                ProductYearMaskedTextBox.BackColor = Color.White;
            ErrorProvider.Clear();
        }

        private void PhotoPictureBox_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (PhotoPictureBox.BackColor == Color.IndianRed)
                PhotoPictureBox.BackColor = this.BackColor;
           
        }

        private void MileAgeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void ColorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((ColorTextBox.TextLength == 0 && ((char.IsUpper(e.KeyChar) && char.IsLetter(e.KeyChar)) || (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)))) ||
              (ColorTextBox.TextLength != 0 && ((char.IsLetter(e.KeyChar) && char.IsUpper(e.KeyChar)) || (!e.KeyChar.Equals('-') && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)))))
                e.Handled = true;
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

        private void ProductYearMaskedTextBox_Leave(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }
    }
}
