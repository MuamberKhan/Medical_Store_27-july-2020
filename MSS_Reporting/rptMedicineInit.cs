using MedicineReport;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;

namespace MSS_Reporting
{
    public class RpMedicineInit
    {
        DateTime fromDate, toDate;
        public RpMedicineInit(DateTime fromDate, DateTime toDate)
        {
            this.fromDate = fromDate;
            this.toDate = toDate;
        }
        public void InitialiazeReport()
        {
            string[] fromToDate = { fromDate.ToShortDateString(), toDate.ToShortDateString() };
            if (fromToDate != null)
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string query = "SELECT m.ID ,m.MedName,m.SoldQuantity,m.MedSellPrice,m.MedPurchasePrice,m.MedType,p.ID as PID, b.BillDate FROM Medicine m" +
                                                " JOIN BillMedicine bm ON m.ID = bm.MedicineID" +
                                                " JOIN Bill b ON bm.BilIID = b.ID" +
                                                " JOIN Patient p On b.PatientID=p.ID "+
                                                $" where b.BillDate between '{fromDate}' and '{toDate}';";
                        List<MedicineReportData> list = db.Query<MedicineReportData>(query, commandType: CommandType.Text).ToList();
                        // Adjusting the list according to the requirements.

                        var list2 = list.GroupBy(x => x.ID)
                            .Select(x => new MedicineReportData
                            {
                                ID = x.First().ID,
                                MedName = x.First().MedName,
                                MedPurchasePrice = x.First().MedPurchasePrice,
                                MedSellPrice = x.First().MedSellPrice,
                                MedType = x.First().MedType,
                                PID = x.Distinct().First().PID,
                                SoldQuantity = x.Count(),

                            })
                            .OrderByDescending(x => x.ID);
                        

                        using (MedicineReportPrint form = new MedicineReportPrint(fromToDate, list2.ToList()))
                        {
                            form.ShowDialog();
                        }

                    }

                }
            }
        }
    }
}
