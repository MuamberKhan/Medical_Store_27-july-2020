using LocalDataBase;
using System.Data;

namespace BussinessLogic
{
    public class ProcessBills
    {
        MedicalStore_dbEntities context; //MedicalStore_dbEntities

        public void BillPaied(int ID)
        {
            using (context=new LocalDataBase.MedicalStore_dbEntities())
            {
              var bill=  context.Bills.Find(ID);
                bill.BillStatus = true;
                context.Entry(bill).State =EntityState.Modified;
                context.SaveChanges();
            }
            
        }
    }
}
