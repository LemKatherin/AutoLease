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
    public partial class NewAutoOfModel : Form
    {
        public NewAutoOfModel()
        {
            InitializeComponent();
        }

        private void OpenPhotoButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                PhotoPictureBox.ImageLocation = openFileDialog.FileName;
        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {
            if (ProductYearMaskedTextBox.MaskFull && ColorTextBox.TextLength != 0 &&
                MileAgeTextBox.TextLength != 0) 
            {

                MessageBox.Show("Новый автомобиль успешно добавлен.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {

                if (ColorTextBox.TextLength == 0)
                    ColorTextBox.BackColor = Color.IndianRed;
                if (MileAgeTextBox.TextLength == 0)
                    MileAgeTextBox.BackColor = Color.IndianRed;
                if (!ProductYearMaskedTextBox.MaskFull)
                    ProductYearMaskedTextBox.BackColor = Color.IndianRed;
                if (PhotoPictureBox.Image == null)
                    PhotoPictureBox.BackColor = Color.IndianRed;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ColorTextBox.BackColor == Color.IndianRed)
                ColorTextBox.BackColor = Color.White;
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
        }

        private void PhotoPictureBox_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (PhotoPictureBox.BackColor == Color.IndianRed)
                PhotoPictureBox.BackColor = this.BackColor;
           
        }
    }
}
