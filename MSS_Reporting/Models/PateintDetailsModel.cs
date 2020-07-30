
using LocalDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Store_System.Models
{
   public class PateintDetailsModel
    {
        public int ID { get; set; }
        public string PatientName { get; set; }
        public string PatientGender { get; set; }
        public string PatientAddress { get; set; }
        public string PatientDescription { get; set; }
        public string PatientDiagnosis { get; set; }
        public string PatientTreatment { get; set; }
        public Nullable<System.DateTime> AppointmentDate { get; set; }

        public virtual ICollection<RecordsMedicine> RecordsMedicines { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public string PatientType { get; internal set; }
    }
}
