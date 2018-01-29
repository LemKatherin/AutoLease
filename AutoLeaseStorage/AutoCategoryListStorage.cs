using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLeaseClass;

namespace AutoLeaseStorage
{
    public static class AutoCategoryListStorage
    {
        public static List<AutoCategory> Categories { get; set; } = new List<AutoCategory>();
        static AutoCategoryListStorage()
        {
            Categories.Add(new AutoCategory("Джип", "джи"));
            Categories.Add(new AutoCategory("Седан", "сед"));
            Categories.Add(new AutoCategory("Универсал", "уни"));
            Categories.Add(new AutoCategory("Кабриолет", "каб"));
        }

    }
}
