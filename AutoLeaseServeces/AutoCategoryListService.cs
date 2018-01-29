using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLeaseStorage;
using AutoLeaseClass;

namespace AutoLeaseServeces
{
    public static class AutoCategoryListService
    {
        public static bool Check(String categoryToFind)
        {
            var findcategory = AutoCategoryListStorage.Categories.Where(category => category.Name.Equals(categoryToFind)).SingleOrDefault();

            if (findcategory == null)
                return false;
            else
                return true;

        }
       
        public static AutoCategory Search(String categoryToFind)
        {
            var findcategory = AutoCategoryListStorage.Categories.Where(category => category.Name.Equals(categoryToFind)).SingleOrDefault();
            return findcategory;

        }

        public static void CategoryRegistration(AutoCategory newCategory)
        {
            AutoCategoryListStorage.Categories.Add(newCategory);
        }


    }
}
