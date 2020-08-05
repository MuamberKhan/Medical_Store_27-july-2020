using BusinessLogic;
using Medical_Store_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Store_System.ProjectReports
{
    public class InitializePatientReport
    {
        private readonly int PatientID;
        public InitializePatientReport(int PatientID)
        {
            this.PatientID = PatientID;
        }
        public void InitialiazeReport()
        {
            ProcessPatient processPatient = new ProcessPatient();
            if (this.PatientID > 0)
            {
                var pateint = processPatient.getPateintByID(this.PatientID);

                PatientReportModel model = new PatientReportModel();
                model.ID = pateint.ID;
                model.FatherName = pateint.FatherName;
                model.PatientName = pateint.PatientName;
                model.PatientGender = processPatient.getPateintType(pateint.PatientType.Value);
                model.PatientAddress = pateint.PatientAddress;

                var result = pateint.PateintRecords.Select(x => new PateintRecords
                {
                    ID = x.ID,
                    AppointmentDate = x.AppointmentDate.Value.ToShortDateString(),
                    Description = x.Description,
                    Diagnosis = x.Diagnosis,
                    Treatment = x.Treatment
                }).ToList();

                model.PateintRecords = result;
                using (PatientPrintReport form = new PatientPrintReport(model))
                {
                    form.ShowDialog();
                }

            }
        }
    }
}