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
    public partial class ClientCardInfo : Form
    {
        public ClientCardInfo()
        {
            InitializeComponent();
           
        }

        public void setEnabledSum(bool flag)
        {
            btnSum.Enabled = flag;
            Change_SaveButton.Enabled = flag;
        }


        //private void tableLayoutPanel1_Click(object sender, EventArgs e)
        //{
        //    tableClientPanel.RowCount++;
        //    tableClientPanel.Size = new System.Drawing.Size(tableClientPanel.Size.Width, tableClientPanel.Size.Height + 100);
        //}
    }
}
