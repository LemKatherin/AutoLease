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
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void Exit(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientList clientcard = new ClientList(false);
            clientcard.setflagCanCount(true);
            clientcard.Show();
        }

        private void LeaseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutoModelList autoLease = new AutoModelList(false);
            autoLease.Show();
        }


        private void AutoListButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutoModelList autoList = new AutoModelList(true);
            autoList.Show();
        }

        //public void ShowModelList()
        //{
        //    AutoModelList autoList = new AutoModelList(true);
        //    autoList.Show();
        //}

        private void ClientListButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientList clientcard = new ClientList(false);
            clientcard.setflagCanCount(false);
            clientcard.Show();
        }

        private void ClientRegistrButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckClient clientregistr = new CheckClient();
            clientregistr.Show();
        }

        private void AutoRegistrButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckAutoModel checkautomodel = new CheckAutoModel();
            checkautomodel.Show();
        }

        private void CategoryRegistrButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckCategory checkcategory = new CheckCategory(true);
            checkcategory.Show();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ClientsToolStripTextBox.Text = ClientListStorage.Clients.Count.ToString();
            int sum = 0;
            foreach (AutoForStorage auto in AutoListStorage.Cars)
            {
                sum += auto.Automobiles.Count;
            }
            AutoToolStripTextBox.Text = sum.ToString();
            PennyToolStripTextBox.Text = AutoListStorage.penny.ToString();
            DateToolStripTextBox.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
        }

        private void PennyToolStripButton_Click(object sender, EventArgs e)
        {
            SetPenny setPenny = new SetPenny();
            setPenny.ShowDialog();
        }
    }
}
