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
    public partial class AutoCard : Form
    {
        public AutoCard()
        {
            InitializeComponent();
        }
        public AutoCard(string mark, string model, string country, string category, 
            string fuel, string fuelinhour, string sumlease, string autocount, Image photo)
        {
            InitializeComponent();
            ModelNameTextBox1.Text = mark;
            ModelNameTextBox2.Text = model;
            CountryTextBox.Text = country;
            CategoryTextBox.Text = category;
            FuelTextBox.Text = fuel;
            FuelInHourTextBox.Text = fuelinhour;
            LeaseSumTextBox.Text = sumlease.ToString();
            CountAutoTextBox.Text = autocount;
            PhotoPictureBox.Image = photo;

        }

    }
}
