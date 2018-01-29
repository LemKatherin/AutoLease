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
    public partial class AutoCategoryRegistr : Form
    {
        Form checkcategorywin = new Form();
        bool flagwho = false;

        public AutoCategoryRegistr()
        {
            InitializeComponent();
        }

        public AutoCategoryRegistr(Form category)
        {
            InitializeComponent();
            checkcategorywin = category;
        }

        public void setflag(bool temp)
        {
            flagwho = temp;
        }

        public void setNameTextBox(TextBox name)
        {
            NameTextBox.Text = name.Text;
            if (NameTextBox.TextLength >= 3)
                CodeTextBox.Text = NameTextBox.Text.Remove(3, NameTextBox.TextLength - 3);
            else if (NameTextBox.TextLength > 0 && NameTextBox.TextLength < 3)
                CodeTextBox.Text = NameTextBox.Text;
            CodeTextBox.Text = CodeTextBox.Text.ToUpper();
        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {

            if (NameTextBox.TextLength != 0 && CodeTextBox.TextLength != 0)
            {
                AutoCategory newCategory = new AutoCategory(NameTextBox.Text, CodeTextBox.Text);
                AutoCategoryListService.CategoryRegistration(newCategory);
                MessageBox.Show("Регистрация новой категории автомобиля успешно завершена","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {

                if (NameTextBox.TextLength == 0)
                    NameTextBox.BackColor = Color.IndianRed;               
                if(CodeTextBox.TextLength == 0)
                    CodeTextBox.BackColor = Color.IndianRed;
            }
        }


        private void CodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CodeTextBox.BackColor == Color.IndianRed)
                CodeTextBox.BackColor = Color.White;
        }


        private void AutoCategoryRegistr_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(flagwho)
               WorkingClass.WorkingMenu.Show();
            checkcategorywin.Close();
        }
    }
}
