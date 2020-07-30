using LocalDataBase;
using System;
using System.Collections.Generic;
using BusinessLogic;

namespace Medical_Store_System.Models
{
    public class MedicineDetailsModel
    {
        public int ID { get; set; }
        public string MedName { get; set; }
        public decimal MedSellPrice { get; set; }
        public decimal MedPurchasePrice { get; set; }
        public string IsLacking { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string MedStatus { get; set; }
        public string MedDescription { get; set; }

        public virtual ICollection<RecordsMedicine> RecordsMedicines { get; set; }
        public string MedType { get; internal set; }

    }
}
