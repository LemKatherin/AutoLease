using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AutoLeaseClass
{
    public class AutoCopy : Auto
    {
        public int Year { get; set; } = 0;
        public String Color { get; set; } = "";
        public String Mileage { get; set; } = "";
        public String ID { get; set; } = "";
        public Image Photo { get; set; } = null;
        public int Number { get; set; } = 0;
        public bool Enable { get; set; } = true;

        public AutoCopy() { }

        public AutoCopy(int year, String color, String mileage, int number, Image photo, Auto car)
        {
            Year = year;
            Color = color;
            Mileage = mileage;
            Number = number;
            Photo = photo;
            Mark = car.Mark;
            Model = car.Model;
            Country = car.Country;
            Category = car.Category;
            Transmission = car.Transmission;
            Fuel = car.Fuel;
            FuelPerHour = car.FuelPerHour;
            SumLease = car.SumLease;
            CarCount = car.CarCount;
            Description = car.Description;
            AutoPhoto = car.AutoPhoto;
            CarNumber = car.CarNumber;
            Copies = car.Copies;
        }

       
    }

}
