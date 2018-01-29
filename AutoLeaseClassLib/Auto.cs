using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AutoLeaseClass
{
    public class Auto : AutoModel
    {

        public int Year { get; set; } 
        public String Color { get; set; } 
        public String Mileage { get; set; }
        public String ID { get; set; } 
        public Image Photo { get; set; } 
        public int Number { get; set; }
        public bool Enable { get; set; } = true;
        public String Description { get; set; }
        public String Transmission { get; set; }
        public DateTime DateReturn { get; set; }

        public Auto() {}

        public Auto(Auto automobile): base(automobile)
        {
            Year = automobile.Year;
            Color = automobile.Color;
            Mileage = automobile.Mileage;
            Number = automobile.Number;
            Photo = automobile.Photo;     
            Transmission = automobile.Transmission;                    
            Description = automobile.Description;
            DateReturn = automobile.DateReturn;
            Enable = automobile.Enable;                 
            ID = automobile.ID;
        }

        public Auto(int year, String color, String mileage, int number, Image photo, String transmission, String description, AutoModel car): base (car)
        {
            Year = year;
            Color = color;
            Mileage = mileage;
            Number = number;
            Photo = photo;
            Transmission = transmission;
            Description = description;

        }
       
    }

}
