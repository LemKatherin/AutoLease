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
    public partial class CopyList : Form
    {
        public CopyList()
        {
            InitializeComponent();
        }
        bool flagwho = false;

        public void setflag(bool temp)
        {
            flagwho = temp;
        }

        public void setEnabledAddButton(bool flag)
        {
            AddButton.Enabled = flag;
            AddNewButton.Enabled = !flag;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
                ClientCard clientcard = new ClientCard();
                clientcard.setflag(flagwho);
                clientcard.Show();
           
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            NewAutoOfModel newauto = new NewAutoOfModel();
            newauto.Show();
        }
    }
}
