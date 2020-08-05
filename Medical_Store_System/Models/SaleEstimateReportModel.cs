using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Store_System.Models
{
   public class SaleEstimateReportModel
    {
        public int ID { get; set; }
        public string MedName { get; set; }
        public decimal MedSellPrice { get; set; }
        public decimal MedPurchasePrice { get; set; }

        public string MedType { get; set; }
        public int SoldQuantity { get; set; }

        public int PID { get; set; }
    }
}
