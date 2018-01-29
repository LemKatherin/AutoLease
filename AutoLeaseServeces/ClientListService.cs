using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLeaseStorage;
using AutoLeaseClass;

namespace AutoLeaseServeces
{
    public static class ClientListService
    {
        public static void ClientRegistration(Client client)
        {
           ClientListStorage.Clients.Add(client);
        }

        public static IEnumerable<Client> ClientSearch(int flag, string searchString)
        {
            switch (flag)
            {
                case 1:
                    var selectedClients = from client in ClientListStorage.Clients
                                          where client.Surname.Equals(searchString)
                                          select client;
                    return selectedClients;
                case 2:
                    selectedClients = from client in ClientListStorage.Clients
                                      where client.Name.Equals(searchString)
                                      select client;
                    return selectedClients;
                case 3:
                    selectedClients = from client in ClientListStorage.Clients
                                      where client.ID.Equals(searchString)
                                      select client;
                    return selectedClients;
                default:
                    return null;
            }

        }

        public static IEnumerable<Client> ClientSearch(string name, string surname, string secondname)
        {
            var selectedClients = from client in ClientListStorage.Clients
                                  where (client.Surname.Equals(surname) && client.Name.Equals(name) &&
                                  client.SecondName.Equals(secondname))
                                  select client;
            return selectedClients;
        }

        public static Client ClientSearch(string id)
        {
            var findClient = ClientListStorage.Clients.Where(client => client.ID.Equals(id)).SingleOrDefault();
            return findClient;
        }

        public static Client ClientSearchCheck(string passport)
        {
            var findClient = ClientListStorage.Clients.Where(client => client.Passport.Equals(passport)).SingleOrDefault();
            return findClient;
        }

        public static void ClientLease(string id, List<string> returnautomobile, ref List<Lease> auto)
        {
            try
            {
                Client client = ClientSearch(id);
                foreach (string automobile in returnautomobile)
                {
                    Lease findautomobile = client.leaseList.Where(lease => (lease.LeasedAutomobile.ID.Equals(automobile) && lease.ReturnDate.Date.Year.Equals(1))).SingleOrDefault();
                    findautomobile.ReturnDate = DateTime.Today;
                    SumsService service = new SumsService(findautomobile.Sum.SumLease, findautomobile.Sum.SumPenny, findautomobile.Sum.CommonSum);
                    AutoForStorage model = AutoModelsListService.CarSearch(findautomobile.LeasedAutomobile.Mark + " " + findautomobile.LeasedAutomobile.Model);
                    AutoService automobileservice = new AutoService(model.Automobiles);
                    automobileservice.automobileSearch(findautomobile.LeasedAutomobile.ID).Enable = true;
                    automobileservice.automobileSearch(findautomobile.LeasedAutomobile.ID).DateReturn = DateTime.MinValue;
                    if (findautomobile.ReturnDate.Subtract(findautomobile.LeaseDate).TotalDays <= findautomobile.DaysLease)
                        findautomobile.Sum.SumLease = service.countSumLease(findautomobile.LeasedAutomobile.SumLease, findautomobile.ReturnDate.Subtract(findautomobile.LeaseDate).TotalDays);
                    else
                    {
                        findautomobile.Sum.SumLease = service.countSumLease(findautomobile.LeasedAutomobile.SumLease, findautomobile.DaysLease);
                        client.Debt = true;
                        findautomobile.Sum.SumPenny = service.countSumPenny(AutoListStorage.penny, findautomobile.LeasedAutomobile.SumLease, findautomobile.ReturnDate.Subtract(findautomobile.LeaseDate).TotalDays - findautomobile.DaysLease);
                    }
                    findautomobile.Sum.CommonSum = service.countCommonSum();
                    auto.Add(findautomobile);

                }
            }
            catch
            {
                throw;
            }

        }

        public static void AnnulmentReturn (Lease auto)
        {
            auto.ReturnDate = DateTime.MinValue;
            auto.Sum.SumLease = 0;
            auto.Sum.SumPenny = 0;
            auto.Sum.CommonSum = 0;
            auto.LeasedAutomobile.DateReturn = auto.LeaseDate.Date.AddDays(auto.DaysLease);
            auto.LeasedAutomobile.Enable = false;

        }
    }
}
