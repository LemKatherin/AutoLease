using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLeaseClass;

namespace AutoLeaseStorage
{
   public static class AutoListStorage
    {
        public static double penny = 1.3;
        public static List<AutoForStorage> Cars { get; set; } = new List<AutoForStorage>();
        public static List<String> countryList { get; set; } = new List<String>();
        public static List<String> markList { get; set; } = new List<String>();

        static AutoListStorage()
        {
            countryList.Add("США");
            countryList.Add("Германия");
            countryList.Add("Великобритания");
            countryList.Add("Россия");
            countryList.Add("Италия");
            countryList.Add("Франция");

            markList.Add("Reno");
            markList.Add("Ford");
            markList.Add("Mazda");
            markList.Add("Audi");
            markList.Add("Toyota");
            markList.Add("BMW");
            markList.Add("MINI");
        }
       
    }
}
