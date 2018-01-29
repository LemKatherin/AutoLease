using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoLeaseClassLib;

namespace AutoLease.StartMenu
{
    public partial class StartMenu : Form
    {

        ListClient clientList = new ListClient();

        public StartMenu()
        {
            InitializeComponent();
            ClientsToolStripTextBox.Text = clientList.Clients.Count.ToString();
            DateToolStripTextBox.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void Exit(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutoReturn autoreturn = new AutoReturn();
            autoreturn.Show();
        }

        private void LeaseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutoLease lease = new AutoLease();
            lease.setFlagCanAdd(true);
            lease.ShowDialog();
        }

        private void ClientRegistrButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckClient clientregistr = new CheckClient(clientList,this);
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
            CheckCategory checkcategory = new CheckCategory();
            checkcategory.setflag(true);
            checkcategory.Show();
        }

        private void ClientListButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientCard clientcard = new ClientCard(clientList, this, false);
            clientcard.setflagCanCount(false);
            clientcard.Show();
        }

        private void AutoListButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutoList autolist = new AutoList();
            autolist.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
