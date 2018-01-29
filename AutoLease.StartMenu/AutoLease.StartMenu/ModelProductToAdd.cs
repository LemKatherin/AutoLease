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
    public partial class ModelProductToAdd : Form
    {
        public ModelProductToAdd()
        {
            InitializeComponent();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (ModelProductTextBox.TextLength == 0)
                ModelProductTextBox.BackColor = Color.IndianRed;
            //else if()
            //{
            //    MessageBox.Show("Такая модель уже есть в списке", "Ошибка!");
            //}
            else
                this.Close();
        }

        private void ModelProductTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ModelProductTextBox.BackColor == Color.IndianRed)
                ModelProductTextBox.BackColor = Color.White;
        }

        private void ModelProductTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) ||
               (ModelProductTextBox.TextLength == 0 && char.IsLower(e.KeyChar)))
                e.Handled = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
