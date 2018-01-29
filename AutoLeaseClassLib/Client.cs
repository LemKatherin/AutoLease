using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLeaseClass
{
    public class Client
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public String SecondName { get; set; }
        public bool Sex { get; set; }
        public DateTime Birthday { get; set; }
        public String Passport { get; set; }
        public DateTime DriverLicenseTime { get; set; }
        public bool Debt { get; set; }
        public int Number { get; set; }
        public DateTime RegistrationDate { get; set; }
        public String ID { get; set; }
        public List<Lease> leaseList = new List<Lease>(0);


        public Client(){ }

        public Client(String name, String surname, String secondname, bool sex, DateTime birthday,
            String passport, DateTime driverLicenseTime, bool debt, DateTime registrationDate, int number)
        {
            Name = name;
            Surname = surname;
            SecondName = secondname;
            Sex = sex;
            Birthday = birthday;
            Passport = passport;
            DriverLicenseTime = driverLicenseTime;
            Debt = debt;
            RegistrationDate = registrationDate;
            Number = number;
        }

        public Client(Client client)
        {
            Name = client.Name;
            Surname = client.Surname;
            SecondName = client.SecondName;
            Sex = client.Sex;
            Birthday = client.Birthday;
            Passport = client.Passport;
            DriverLicenseTime = client.DriverLicenseTime;
            Debt = client.Debt;
            RegistrationDate = client.RegistrationDate;
            Number = client.Number;
            leaseList = client.leaseList;
        }

    }
}
