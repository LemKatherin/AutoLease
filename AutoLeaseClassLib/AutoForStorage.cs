using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLeaseClass
{
    public class AutoForStorage
    {
        public AutoModel ThisAutoModel { get; set; } = new AutoModel();
        public List<Auto> Automobiles { get; set; } = new List<Auto>();
        public int CarsAmount { get; set; }

        public AutoForStorage() { }

        public AutoForStorage(AutoForStorage auto)
        {
            ThisAutoModel = auto.ThisAutoModel;
            Automobiles = auto.Automobiles;
            CarsAmount = auto.CarsAmount;
        }
        
        public AutoForStorage(AutoModel model, int amount)
        {
            ThisAutoModel = model;
            CarsAmount = amount;
            //Automobiles.Capacity = amount;
        }
    }
}
