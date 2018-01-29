using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLeaseClass;

namespace AutoLeaseServeces
{
    public class SumsService: SumsForLease
    {
        public SumsService(double lease, double penny, double common) : base(lease, penny, common) { }

        public double countSumLease(double carperday, double dayslease)
        {
           return SumLease = carperday * dayslease;
        }

        public double countSumPenny(double penny, double carperday, double dayslate)
        {
            return SumPenny = penny * carperday * dayslate;
        }

        public double countCommonSum()
        {
            return CommonSum = SumLease + SumPenny;
        }
    }
}
