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
    public partial class FrmDateForUse : Form
    {
        Lease ThisLease;
        Client ThisClient;
        public FrmDateForUse(Lease lease, Client client)
        {
            InitializeComponent();
            ThisLease = lease;
            ThisClient = client;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (ThisClient.DriverLicenseTime < DateTime.Today.Date.AddDays(Convert.ToDouble(numericUpDown1.Value)))
                MessageBox.Show("Недостаточный срок прав", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numericUpDown1.Value != 0)
            {
                ThisLease.DaysLease = Convert.ToInt32(numericUpDown1.Value);
                ThisLease.LeasedAutomobile.DateReturn = DateTime.Today.Date.AddDays(ThisLease.DaysLease);
                ClientService service = new ClientService(ThisClient);
                service.LeasedCars(ThisLease);
                MessageBox.Show("Автомобиль успешно добавлен клиенту", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
