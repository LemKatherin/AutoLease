using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLeaseClass
{
    public class AutoCategoryClass
    {
        public String Name { get; set; } = "";
        public String NameCode { get; set; } = "";

        public AutoCategoryClass() { }
        public AutoCategoryClass(String name, String nameCode)
        {
            Name = name;
            NameCode = nameCode;
        }
    }
}
