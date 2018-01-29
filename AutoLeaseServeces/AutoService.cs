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
    public class AutoService: AutoForStorage, GenerateID
    {
        public AutoService(AutoForStorage automobile): base(automobile) {}

        public AutoService(List <Auto> automobiles)
        {
            Automobiles = automobiles;
        }

        public String generateID()
        {
            String ID;
            ID = ThisAutoModel.Category.NameCode + ThisAutoModel.CarNumber.ToString() + (Automobiles.Count + 1).ToString();
            ID = ID.ToUpper();
            return ID;
        }

        public void automobileRegistration(Auto autoautomobile)
        {
            Automobiles.Add(autoautomobile);
        }

        public IEnumerable<Auto> automobileSearch(int flag, String searchString)
        {
            switch (flag)
            {
                case 1:
                    var selectedautomobiles = from automobile in Automobiles
                                         where (automobile.Mark + " " + automobile.Model).Equals(searchString)
                                         select automobile;
                    return selectedautomobiles;
                case 2:
                    selectedautomobiles = from automobile in Automobiles
                                     where automobile.Category.Equals(searchString)
                                     select automobile;
                    return selectedautomobiles;
                case 3:
                    selectedautomobiles = from automobile in Automobiles
                                     where automobile.Mark.Equals(searchString)
                                     select automobile;
                    return selectedautomobiles;
                default:
                    return null;
            }
        }
        public Auto automobileSearch(String searchString)
        {
            var findautomobile = Automobiles.Where(automobile => automobile.ID.Equals(searchString)).SingleOrDefault();
            return findautomobile;
        }
    }
}
