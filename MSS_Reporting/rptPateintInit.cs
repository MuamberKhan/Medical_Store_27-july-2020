using PateintReport;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using BusinessLogic;
using Medical_Store_System.Models;

namespace MSS_Reporting
{
   public class RptPateintInit
    {
        private readonly int PatientID;
        ProcessPatient patientProcess = new ProcessPatient();
        public RptPateintInit(int PatientID)
            {
                this.PatientID = PatientID;
            }
            public void InitialiazeReport()
            {
                if (this.PatientID >0)
                {
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        if (db.State == ConnectionState.Closed)
                        {
                            db.Open();
                            string query = string.Format("select * from Patient where ID = '{0}'", PatientID);
                            List<PateintReportData> pateint = db.Query<PateintReportData>(query, commandType: CommandType.Text).ToList();
                        
                        var result = pateint.Select(x => new PateintDetailsModel
                        {
                            ID = x.ID,
                            AppointmentDate = x.AppointmentDate,
                            PatientAddress = x.PatientAddress,
                            PatientDescription = x.PatientDescription,
                            PatientDiagnosis = x.PatientDiagnosis,
                            PatientType = patientProcess.getPateintType(x.PatientType),
                            PatientName = x.PatientName,
                            PatientTreatment = x.PatientTreatment
                        }).ToList();

                        using (PateintReportPrint form = new PateintReportPrint(result))
                            {
                                form.ShowDialog();
                            }

                        }

                    }
            }
        }
    }
}
