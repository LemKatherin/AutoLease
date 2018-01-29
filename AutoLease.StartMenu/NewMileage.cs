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


namespace AutoLease.StartMenu
{
    public partial class NewMileage : Form
    {
        Auto auto = new Auto();

        public NewMileage()
        {
            InitializeComponent();
        }
        public NewMileage(Auto auto) : this()
        {
            this.auto = auto;
        }

        private void MileageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

        }
        private void MileageTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MileageTextBox.BackColor == Color.IndianRed)
                MileageTextBox.BackColor = Color.White;
            ErrorProvider.Clear();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (MileageTextBox.TextLength == 0)
                MileageTextBox.BackColor = Color.IndianRed;
            else if (Convert.ToInt32(MileageTextBox.Text) < Convert.ToInt32(auto.Mileage))
            {
                ErrorProvider.SetError(MileageTextBox, "Пробег после аренды меньше пробега до");
            }
            else
            {
                auto.Mileage = MileageTextBox.Text;
                this.Close();
            }
        }
    }
}
