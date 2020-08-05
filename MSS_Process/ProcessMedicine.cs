using LocalDataBase;
using Process_Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ProcessMedicine
    {
        MedicalStore_dbEntities context;


        public void AddMedicine(Medicine model, string cmboBxMedType)
        {
            try
            {
                if (model.Quantity < 5)
                {
                    model.IsLacking = true;
                }
                else
                {
                    model.IsLacking = false;
                }
                model.MedStatus = "Medium";

                //Get Medicine Type
                model.MedStatus = null;
                string type = cmboBxMedType;
                int medType = 0;
                foreach (var item in Enum.GetValues(typeof(MedicineType)))
                {
                    if (item.ToString() == type)
                    {
                        medType = (int)item;
                    }
                }
                ///
                using (context = new MedicalStore_dbEntities())
                {
                    model.MedType = medType;
                    context.Medicines.Add(model);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Tuple<List<Medicine>,int> GetReportDataForMedicines()
        {
            using (context = new MedicalStore_dbEntities())
            {
               var bills = context.BillMedicines.Include(p=>p.Bill).ToList();

                var soldMedicinesIDs = bills.Select(b=>b.MedicineID);
                var soldMedicines= context.Medicines.Where(m => soldMedicinesIDs.Contains(m.ID)).ToList();

                var pateintCount = bills.Select(b => b.Bill.PatientID).Distinct().Count();

                Tuple<List<Medicine>, int> result = Tuple.Create(soldMedicines,pateintCount);

                return result;
            }
        }

        public Medicine getMedicineByID(int iD)
        {
            using (context = new MedicalStore_dbEntities())
            {
                return context.Medicines.Where(i => i.ID == iD).First();
            }
        }
        public object getLackingMedicines(string searchTerm=null)
        {
            using (context = new MedicalStore_dbEntities())
            {
                List<Medicine> result=null;
                if (searchTerm==null)
                {
                    result = context.Medicines.Where(m => m.IsLacking != false).ToList();
                }
                else
                {
                    result = context.Medicines.Where(m => m.IsLacking != false && m.MedName.Contains(searchTerm)).ToList();

                }

                return result;
            }
        }

        public void UpdateMedicine(Medicine model, bool isSold,string cmboBxMedType = null)
        {
            try
            {
                //reducing Quantity
                if (isSold)
                {
                    model.Quantity = model.Quantity - 1;
                    //Checking  If Lacking?
                    model.SoldQuantity += 1;
                }

                if (model.Quantity < 3)
                {
                    model.IsLacking = true;
                }
                else
                {
                    model.IsLacking = false;
                }

                if (cmboBxMedType != null)
                {
                    //Get Medicine Type
                    string type = cmboBxMedType;
                    int medType = 0;
                    foreach (var item in Enum.GetValues(typeof(MedicineType)))
                    {
                        if (item.ToString() == type)
                        {
                            medType = (int)item;
                        }
                    }
                    model.MedType = medType;
                }
                using (context = new MedicalStore_dbEntities())
                {
                    context.Medicines.Attach(model);
                    context.Entry(model).State= EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetPendingBillsCount()
        {
            using (context = new MedicalStore_dbEntities())
            {
                var result = context.Bills.Where(p => p.BillStatus == false).Select(b => b.PatientID).Count();
                return result;
            }
        }

        public async Task<int> GetPendingBillsCountAsync()
        {
            var res = await Task.Run(() =>
              {
                  using (context = new MedicalStore_dbEntities())
                  {
                      var result = context.Bills.Where(p => p.BillStatus == false).Select(b => b.PatientID).Count();
                      return result;
                  }
              });
            return res;

        }

        public int GetLackingMedicinesCount()
        {
            using (context=new MedicalStore_dbEntities())
            {
            var count = context.Medicines.Where(m => m.IsLacking == true).Count();
                return count;
            }
        }
        public async System.Threading.Tasks.Task<int> GetLackingMedicinesCountAsync()
        {
            var res = await Task.Run(() =>
            {
                using (context = new MedicalStore_dbEntities())
                {
                    var count = context.Medicines.Where(m => m.IsLacking == true).Count();
                    return count;
                }
            });
            return res;
        }

        public List<Medicine> GetAllMedicines()
        {
            using (context = new MedicalStore_dbEntities())
            {
                return context.Medicines.ToList();
            }
        }
        public List<Medicine> GetMedicines()
        {
            using (context = new MedicalStore_dbEntities())
            {
                return context.Medicines.Where(m => m.IsLacking != true && m.Quantity > 2).ToList();
            }
        }

        public object SearchMedicine(string medName, string medTypeString = null)
        {
            using (context = new MedicalStore_dbEntities())
            {
                try
                {
                    //Get Medicine Type
                    int medTypeInt = 0;
                    foreach (var item in Enum.GetValues(typeof(MedicineType)))
                    {
                        if (item.ToString() == medTypeString)
                        {
                            medTypeInt = (int)item;
                        }
                    }
                    if (medName != "" && medTypeString == null)
                    {
                        context.Medicines.Where(m => m.MedName.Contains(medName) && m.Quantity > 2).ToList();
                    }
                    if (medName == "" && medTypeInt > 0)
                    {
                        return context.Medicines.Where(x => x.MedType == medTypeInt && x.Quantity > 2).ToList();
                    }
                    else if (medName != "" && medTypeInt <= 0)
                    {
                        return context.Medicines.Where(x => x.MedName.Contains(medName) && x.Quantity > 2).ToList();
                    }
                    else if (medTypeInt > 0 && medName != "")
                    {
                        return context.Medicines.Where(m => m.MedName.Contains(medName) && m.MedType == medTypeInt && m.Quantity > 2).ToList();
                    }
                    else
                    {
                        return context.Medicines.ToList();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        /// <summary>
        /// Deletes the specified medicine according to the ID
        /// </summary>
        /// <param name="iD"></param>
        public void DeleteMedicine(int iD)
        {
            using (context=new MedicalStore_dbEntities())
            {
                var model = context.Medicines.Find(iD);
                context.Medicines.Remove(model);
                context.Entry(model).State =EntityState.Deleted;
                context.SaveChanges();
                
            }
        }

        /// <summary>
        /// Function takes integer and returns string againt the enum
        /// </summary>
        /// <param name="value"></param>
        /// <returns>string:medType</returns>
        public string getMedineType(int value)
        {
            string medType = null;
            foreach (var item in Enum.GetValues(typeof(MedicineType)))
            {
                if ((int)item == value)
                {
                    medType = item.ToString();
                }
            }
            return medType;
        }
        /// <summary>
        /// Function takes string and returns int againt the enum
        /// </summary>
        /// <param name="value"></param>
        /// <returns>int:medType</returns>
        public int getMedineType(string value)
        {
            int medType = -1;
            foreach (var item in Enum.GetValues(typeof(MedicineType)))
            {
                if (item.ToString() == value)
                {
                    medType = (int)item;
                }
            }
            return medType;
        }

        public Medicine getMedicineByName(string text)
        {
            using (context = new MedicalStore_dbEntities())
            {
                return context.Medicines.Where(m => m.MedName == text).FirstOrDefault();
            }
        }
    }
}
