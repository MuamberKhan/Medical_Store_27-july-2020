//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LocalDataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patient
    {
        public Patient()
        {
            this.Bills = new HashSet<Bill>();
            this.PateintRecords = new HashSet<PateintRecord>();
        }
        public int ID { get; set; }
        public string PatientName { get; set; }
        public Nullable<int> PatientType { get; set; }
        public string PatientAddress { get; set; }
        public string FatherName { get; set; }
    
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<PateintRecord> PateintRecords { get; set; }
    }
}
