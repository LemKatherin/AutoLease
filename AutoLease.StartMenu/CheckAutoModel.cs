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
    public partial class CheckAutoModel : Form
    {

        public CheckAutoModel()
        {
            InitializeComponent();
            foreach (string mark in AutoListStorage.markList)
            {
                NameComboBox.Items.Add(mark);
            }
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (NameComboBox.Text.Length == 0)
                NameComboBox.BackColor = Color.IndianRed;
            if (NameTextBox.TextLength == 0)
                NameTextBox.BackColor = Color.IndianRed;

            else if (NameComboBox.Text.Length !=0 && NameTextBox.TextLength != 0 && 
                !AutoModelsListService.CheckCar(NameComboBox.Text + " " + NameTextBox.Text))
            {
                AutoRegistr autoregistrwin = new AutoRegistr(this);
                autoregistrwin.setNameTextBox1(NameComboBox);
                autoregistrwin.setNameTextBox2(NameTextBox);
                autoregistrwin.Show();
                this.Hide();

            }
            else 
            {
                MessageBox.Show("Такая модель уже зарегестрирована", "", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                this.Close();
            }

           
        }

        private void AddModelProductButton_Click(object sender, EventArgs e)
        {
            ModelProductToAdd modelproducttoaddwin = new ModelProductToAdd();
            modelproducttoaddwin.ShowDialog();
        }

        private void NameComboBox_TextChanged(object sender, EventArgs e)
        {
            if(NameComboBox.BackColor == Color.IndianRed)
                NameComboBox.BackColor = Color.White;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NameTextBox.BackColor == Color.IndianRed)
                NameTextBox.BackColor = Color.White;
        }

        private void NameComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = true;
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
                !char.IsNumber(e.KeyChar)))
                e.Handled = true;
        }


        private void CheckAutoModel_FormClosed(object sender, FormClosedEventArgs e)
        {
            WorkingClass.WorkingMenu.Show();
        }

        private void CheckAutoModel_Activated(object sender, EventArgs e)
        {
            NameComboBox.Items.Clear();
            foreach (string mark in AutoListStorage.markList)
            {
                NameComboBox.Items.Add(mark);
            }
        }
    }
}
