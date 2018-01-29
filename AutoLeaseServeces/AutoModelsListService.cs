using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLeaseClass;
using AutoLeaseStorage;

namespace AutoLeaseServeces
{
    public static class AutoModelsListService
    {

        public static bool CarRegistration(AutoForStorage car)
        {
            AutoListStorage.Cars.Add(car);
            return true;
        }

        public static IEnumerable<AutoForStorage> CarSearch(int flag, String searchString)
        {
            switch (flag)
            {
                case 1:
                    var selectedCars = from car in AutoListStorage.Cars
                                       where (car.ThisAutoModel.Mark + " " + car.ThisAutoModel.Model).Equals(searchString)
                                       select car;
                    return selectedCars;
                case 2:
                    selectedCars = from car in AutoListStorage.Cars
                                   where car.ThisAutoModel.Category.Name.Equals(searchString)
                                   select car;
                    return selectedCars;
                case 3:
                    selectedCars = from car in AutoListStorage.Cars
                                   where car.ThisAutoModel.Mark.Equals(searchString)
                                   select car;
                    return selectedCars;
                default:
                    return null;
            }

        }
        public static AutoForStorage CarSearch(String model)
        {
            var findCar = AutoListStorage.Cars.Where(car => (car.ThisAutoModel.Mark + " " + car.ThisAutoModel.Model).Equals(model)).SingleOrDefault();
            return findCar;
        }

        public static bool CheckCar(String carToFind)
        {
            var findcategory = AutoListStorage.Cars.Where(car => (car.ThisAutoModel.Mark + " " + car.ThisAutoModel.Model).Equals(carToFind)).SingleOrDefault();
            if (findcategory == null)
                return false;
            else
                return true;

        }
        public static bool CheckMark(String markToFind)
        {
            var findmark = AutoListStorage.markList.Where(mark => mark.Equals(markToFind)).SingleOrDefault();
            if (findmark == null)
                return false;
            else
                return true;
        }
        public static bool CheckCountry(String countryToFind)
        {
            var findcountry = AutoListStorage.countryList.Where(country => country.Equals(countryToFind)).SingleOrDefault();
            if (findcountry == null)
                return false;
            else
                return true;
        }
    }
}
