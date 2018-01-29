using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLeaseCode
{
    class ControlClass
    {
        List<Client> clientList = new List<Client>();
        public bool ClientRegistration(Client client)
        {
            clientList.Add(client);
            return true;
        }
    }
}
