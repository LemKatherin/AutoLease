using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace AutoLeaseClass
{
    public class AutoModel
    {
        public String Mark { get; set; }
        public String Model { get; set; }
        public String Country { get; set; }
        public AutoCategory Category { get; set; } = new AutoCategory();
        public String Fuel { get; set; }
        public double FuelPerHour { get; set; }
        public double SumLease { get; set; }
        public Image AutoPhoto { get; set; }
        public int CarNumber { get; set; }

        public AutoModel()  { }

        public AutoModel(AutoModel car)
        {
            Mark = car.Mark;
            Model = car.Model;
            Country = car.Country;
            Category = car.Category;
            Fuel = car.Fuel;
            FuelPerHour = car.FuelPerHour;
            SumLease = car.SumLease;
            CarNumber = car.CarNumber;
            AutoPhoto = car.AutoPhoto;
        }

        public AutoModel(String mark, String model, String country, AutoCategory category, String fuel, double fuelPerHour,
                   double sumLease, Image autoPhoto, int carNumber)
        {
            Mark = mark;
            Model = model;
            Country = country;
            Category = category;
            Fuel = fuel;
            FuelPerHour = fuelPerHour;
            SumLease = sumLease;
            AutoPhoto = autoPhoto;
            CarNumber = carNumber;
        }        

    }
}
