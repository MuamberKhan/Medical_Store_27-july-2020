
using LocalDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PateintReport
{
  public  class PateintReportData
    {
        public int ID { get; set; }
        public string PatientName { get; set; }
        public int PatientType { get; set; }
        public string PatientAddress { get; set; }
        public string PatientDescription { get; set; }
        public string PatientDiagnosis { get; set; }
        public string PatientTreatment { get; set; }
        public Nullable<System.DateTime> AppointmentDate { get; set; }

        public virtual ICollection<RecordsMedicine> RecordsMedicines { get; set; }
        public ICollection<Bill> Bills { get; internal set; }
    }
}
