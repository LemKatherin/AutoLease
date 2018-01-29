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
            else if(AutoModelsListService.CheckMark(ModelProductTextBox.Text))
            {
                MessageBox.Show("Такая марка уже есть в списке", "", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
               AutoListStorage.markList.Add(ModelProductTextBox.Text);
                this.Close();
            }
                
        }

        private void ModelProductTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ModelProductTextBox.BackColor == Color.IndianRed)
                ModelProductTextBox.BackColor = Color.White;
        }

        private void ModelProductTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((ModelProductTextBox.TextLength == 0 && ((char.IsLower(e.KeyChar) && char.IsLetter(e.KeyChar)) || (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)))) ||
               (ModelProductTextBox.TextLength != 0 && !e.KeyChar.Equals('-') && !e.KeyChar.Equals(' ') && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)))
                e.Handled = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
