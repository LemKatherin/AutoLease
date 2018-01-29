using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLeaseClass
{
    public class SumsForLease
    {
        public double SumLease { get; set; }
        public double SumPenny { get; set; }
        public double CommonSum { get; set; } 

        public SumsForLease() { }

        public SumsForLease(double lease, double penny, double common)
        {
            SumLease = lease;
            SumPenny = penny;
            CommonSum = common;
        }

    }
}
