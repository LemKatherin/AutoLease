using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLeaseClass
{
    public class AutoCategory
    {
        public String Name { get; set; }
        public String NameCode { get; set; }

        public AutoCategory() { }

        public AutoCategory(String name, String nameCode)
        {
            Name = name;
            NameCode = nameCode;
        }
    }
}
