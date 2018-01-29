using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLeaseCode
{
    class Client
    {
        public string Name { get;  set; }
        public string Surname { get; set; }
        public string SecondName { get; set; }
        public bool Sex { get; set; }
        public DateTime Birthday { get; set; }
        public bool DriverLicense { get; set; }
        public DateTime DriverLicenseTime { get; set; }
        public bool Debt { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime DateLease { get; set; }
        public DateTime DateReturn { get; set; }
        public double SumLease { get; set; }
        public double SumPenny { get; set; }
        public double CommonSum { get; set; }
        public string ID { get; set; }
        //список автомобилей
        
        public Client (string name, string surname, string secondname, bool sex, DateTime birthday,
            bool driverLicense, DateTime driverLicenseTime, bool debt, DateTime registrationDate)
        {
            Name = name;
            Surname = surname;
            SecondName = secondname;
            Sex = sex;
            Birthday = birthday;
            DriverLicense = driverLicense;
            DriverLicenseTime = driverLicenseTime;
            Debt = debt;
            RegistrationDate = registrationDate;
        }

    }
}
