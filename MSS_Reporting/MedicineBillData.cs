using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineReport
{
    public class MedicineReportData
    {
        public int ID { get; set; }
        public string MedName { get; set; }
        public decimal MedSellPrice { get; set; }
        public decimal MedPurchasePrice { get; set; }

        public int MedType { get; set; }
        public int SoldQuantity { get; set; }

        public int PID { get; set; }

    }
}
