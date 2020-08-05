using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Store_System.Models
{
   public class PatientReportModel
    {
        public int ID { get; set; }
        public string PatientName { get; set; }
        public string PatientGender { get; set; }
        public string PatientAddress { get; set; }
        public string FatherName { get; set; }
        public virtual ICollection<PateintRecords> PateintRecords { get; set; }
    }
    /// <summary>
    /// Model for the report
    /// </summary>
   public class PateintRecords
    {
        public int ID { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public string Description { get; set; }
        public string AppointmentDate { get; set; }
      
    }
}
