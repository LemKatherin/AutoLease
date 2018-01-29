using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLeaseClass;

namespace AutoLeaseServeces
{
    public class ClientService: Client, GenerateID
    {
        public ClientService(Client client) : base(client) { }

        public string generateID()
        {
            if (Surname.Length >= 3)
                ID = Surname.Remove(3, Surname.Length - 3) + Name.Remove(1, Name.Length - 1) + Number.ToString();
            else
                ID = Surname + Name.Remove(1, Name.Length - 1) + Number.ToString();
            ID = ID.ToUpper();
            return ID;
        }

        public void LeasedCars(Lease lease)
        {
            leaseList.Add(lease);
        }
    }
}
