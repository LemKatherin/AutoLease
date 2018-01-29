using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLeaseClass
{
    public class Lease
    {
        public Auto LeasedAutomobile { get; set; } = new Auto();
        public DateTime LeaseDate { get; set; }
        public int DaysLease { get; set; }
        public DateTime ReturnDate { get; set; }
        public SumsForLease Sum { get; set; } = new SumsForLease();   
        
        public Lease() { }

        public Lease(Auto automobile, DateTime leaseDate, DateTime returnDate, SumsForLease sum)
        {
            LeasedAutomobile = automobile;
            LeaseDate = leaseDate;
            ReturnDate = returnDate;
            Sum = sum;
        }

        public Lease(Auto automobile, DateTime leaseDate)
        {
            LeasedAutomobile = automobile;
            LeaseDate = leaseDate;          
        }
    }
}
