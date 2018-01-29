using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace AutoLeaseClass
{
    public class Car
    {
        public String Mark { get; set; }
        public String Model { get; set; }
        public String Country { get; set; }
        public AutoCategoryClass Category { get; set; }
        public String Transmission { get; set; }
        public String Fuel { get; set; }
        public double FuelPerHour { get; set; }
        public double SumLease { get; set; }
        //public int CarCount { get; set; }
        public int CarCount { get; set; }
        public String Description { get; set; }
        public Image AutoPhoto { get; set; }
        public int CarNumber { get; set; }
        public List<AutoCopy> Copies { get; set; }

        public Car()
        {
            Mark = "";
            Model = "";
            Country = "";
            Category = new AutoCategoryClass();
            Transmission = "";
            Fuel = "";
            FuelPerHour = 0;
            SumLease = 0;
            CarCount = 0;
            Copies = new List<AutoCopy>(CarCount);
            Description = "";
            AutoPhoto = null;
            CarNumber = 0;

        }

        public Car(String mark, String model, String country, AutoCategoryClass category, String transmission, String fuel, double fuelPerHour,
                   double sumLease, int carCount, String description, Image autoPhoto, int carNumber)
        {
            Mark = mark;
            Model = model;
            Country = country;
            Category = category;
            Transmission = transmission;
            Fuel = fuel;
            FuelPerHour = fuelPerHour;
            SumLease = sumLease;
            CarCount = carCount;
            Description = description;
            AutoPhoto = autoPhoto;
            CarNumber = carNumber;
            Copies = new List<AutoCopy>(carCount);
        }        

    }
}
