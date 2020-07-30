using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporting
{
    public class MedicineReportData
    {
        public int ID { get; set; }
        public string MedName { get; set; }
        public decimal MedSellPrice { get; set; }
        public decimal MedPurchasePrice { get; set; }

        public int MedType { get; set; }
        public int SoldQuantity { get; set; }


        //public int SyrupsCount { get; set; }
        //public int TabletsCount { get; set; }
        //public int OthersCount { get; set; }
        //public int InjectionsCount { get; set; }
        //public decimal Total
        //{
        //    get
        //    {
        //        return Quantity * UnitPrice - Quantity * UnitPrice * Discount;
        //    }
        //}

    }
}
