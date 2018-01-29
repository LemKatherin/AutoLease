using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLeaseClass;
using AutoLeaseStorage;
using System.Drawing;

namespace AutoLeaseServeces
{
    public class AutoCopyService: AutoCopy, GenerateID
    {
        public AutoCopyService(AutoCopy copy)
        {
            Year = copy.Year;
            Color = copy.Color;
            Mileage = copy.Mileage;
            Number = copy.Number;
            Photo = copy.Photo;
            Mark = copy.Mark;
            Model = copy.Model;
            Country = copy.Country;
            Category = copy.Category;
            Transmission = copy.Transmission;
            Fuel = copy.Fuel;
            FuelPerHour = copy.FuelPerHour;
            SumLease = copy.SumLease;
            CarCount = copy.CarCount;
            Description = copy.Description;
            AutoPhoto = copy.AutoPhoto;
            CarNumber = copy.CarNumber;
            ID = copy.ID;
            Copies = copy.Copies;
        }

        public AutoCopyService(List <AutoCopy> copies)
        {
            Copies = copies;
        }
        public string generateID()
        {
            ID = Category.NameCode + CarNumber.ToString() + Number.ToString();
            ID = ID.ToUpper();
            return ID;
        }

        public void CopyRegistration(AutoCopy autoCopy)
        {
            Copies.Add(autoCopy);
        }

        public IEnumerable<AutoCopy> CopySearch(int flag, String searchString)
        {
            switch (flag)
            {
                case 1:
                    var selectedCopies = from copy in Copies
                                         where (copy.Mark + " " + copy.Model).Equals(searchString)
                                         select copy;
                    return selectedCopies;
                case 2:
                    selectedCopies = from copy in Copies
                                     where copy.Category.Equals(searchString)
                                     select copy;
                    return selectedCopies;
                case 3:
                    selectedCopies = from copy in Copies
                                     where copy.Mark.Equals(searchString)
                                     select copy;
                    return selectedCopies;
                default:
                    return null;
            }
        }
        public AutoCopy CopySearch(String searchString)
        {
            var findCopy = Copies.Where(copy => copy.ID.Equals(searchString)).SingleOrDefault();
            return findCopy;
        }
    }
}
