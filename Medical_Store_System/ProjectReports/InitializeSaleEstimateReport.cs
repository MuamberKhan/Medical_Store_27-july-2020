using BusinessLogic;
using Medical_Store_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Store_System.ProjectReports
{
    public class InitializeSaleEstimateReport
    {
        private readonly DateTime fromDate;
        private readonly DateTime toDate;
        ProcessMedicine processMedicine = new ProcessMedicine();
        ProcessPatient processPatient = new ProcessPatient();
        public InitializeSaleEstimateReport(DateTime fromDate, DateTime toDate)
        {
            this.fromDate = fromDate;
            this.toDate = toDate;
        }
        public void InitialiazeReport()
        { 
            string[] fromToDate = { fromDate.ToShortDateString(), toDate.ToShortDateString() };
            if (fromToDate != null)
            {
                var result = processMedicine.GetReportDataForMedicines();


                int pateintCount = result.Item2;
                var list2 = result.Item1.GroupBy(x => x.ID)
                    .Select(x => new SaleEstimateReportModel
                    {
                        ID = x.First().ID,
                        MedName = x.First().MedName,
                        MedPurchasePrice = x.First().MedPurchasePrice.Value,
                        MedSellPrice = x.First().MedSellPrice.Value,
                        MedType = processMedicine.getMedineType(x.First().MedType.Value),
                        SoldQuantity = x.Count(),

                    })
                    .OrderByDescending(x => x.ID);


                using (SaleEstimateReportPrint form = new SaleEstimateReportPrint(fromToDate, list2.ToList(),pateintCount))
                {
                    form.ShowDialog();
                }
            }
        }
    }
}
