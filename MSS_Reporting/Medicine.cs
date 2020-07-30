using Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineReport
{
   public class Medicine
    {
        public int ID { get; set; }
        [DisplayName("Name")]
        public string MedName { get; set; }
        [DisplayName("Sale Price")]
        public Nullable<decimal> MedSellPrice { get; set; }
        [DisplayName("Purchase Price")]
        public Nullable<decimal> MedPurchasePrice { get; set; }
        [DisplayName("Is lacking")]
        public Nullable<bool> IsLacking { get; set; }
        public Nullable<int> Quantity { get; set; }
        [DisplayName("Sale Status")]
        public string MedStatus { get; set; }
        [DisplayName("Description")]
        public string MedDescription { get; set; }
        [DisplayName("Type")]
        public Nullable<int> MedType { get; set; }

        public virtual ICollection<PatientMedicine> PatientMedicines { get; set; }
    }
}
