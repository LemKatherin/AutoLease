using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLeaseClassLib
{
    public class ListClient
    {
        public List<Client> Clients { get; set; } = new List<Client>();
 
        public bool ClientRegistration(Client client)
        {
            Clients.Add(client);
            return true;
        }
        //public List<Client> GetClient()
        //{
        //    return Clients;
        //}
    }
}
