
using LocalDataBase;
using Process_Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace BusinessLogic
{
    public class ProcessPatient
    {
        MedicalStore_dbEntities context;
        public string[] getPateintIDs()
        {
            using (context=new MedicalStore_dbEntities())
            {
                var Ids = context.Patients.Select(p => p.ID).ToArray();
                var IDs = Ids.Select(i => i.ToString()).ToArray();
                return IDs;
            }
        }

      

        /// <summary>
        /// Function takes integer and returns string againt the enum
        /// </summary>
        /// <param name="value"></param>
        /// <returns>string:medType</returns>
        public string getPateintType(int value)
        {
            string medType = null;
            foreach (var item in Enum.GetValues(typeof(PatientType)))
            {
                if ((int)item == value)
                {
                    medType = item.ToString();
                }
            }
            return medType;
        }
        /// <summary>
        /// Getting a pateint with Records by ID of the pateint
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Patient</returns>
        public Patient getPateintByID(int id)
        {
            using (context = new MedicalStore_dbEntities())
            {
                var reslt = context.Patients.Include(p=>p.PateintRecords).First();

                return reslt;
           }
           
        }

        public string[] GetPateintNames()
        {
            using (context = new MedicalStore_dbEntities())
            {
                var Ids = context.Patients.Select(p => p.PatientName).ToArray();
                return Ids;
            }
        }

        public object GetPateintRecords(int v)
        {
            using (context=new MedicalStore_dbEntities())
            {
                var result = context.Patients.Where(p => p.ID == v).Include(pateint => pateint.PateintRecords);
                return result;
            }
        }

        /// <summary>
        /// This function return a tuple of List<PateintRecord> with specified Pateint ID with paging accordingly
        /// item 1: Patient
        /// item 2: Records count
        /// </summary>
        /// <param name="pateintID"></param>
        /// <returns></returns>
        public Tuple<List<PateintRecord>,int> GetPatientRecords(int pateintID,int pageNo=1,int pageSize=1)
        {
            using (context=new MedicalStore_dbEntities())
            {
               Tuple<List<PateintRecord>, int> result = null;
               var pateintRecords = context.PateintRecords.Include(p => p.Patient).Include(m=>m.RecordsMedicines).Where(x => x.PatientID == pateintID).ToList();// as IQueryable;

               var recordsCount = pateintRecords.Count();

                pateintRecords = pateintRecords.Skip((pageNo - 1) * pageSize).Take(pageSize).ToList();


                result = Tuple.Create(pateintRecords, recordsCount);
                return result;
            }
        }

        /// <summary>
        /// Function takes string and returns int againt the enum
        /// </summary>
        /// <param name="value"></param>
        /// <returns>int:medType</returns>
        public int getPateintType(string value)
        {
            int medType = -1;
            foreach (var item in Enum.GetValues(typeof(PatientType)))
            {
                if (item.ToString() == value)
                {
                    medType = (int)item;
                }
            }
            return medType;
        }

        public int SavePatient(Patient objPateint)
        {
            using (context=new MedicalStore_dbEntities())
            {
                context.Patients.Add(objPateint);
                context.SaveChanges();
                int SavedPatientID = objPateint.ID;
                return SavedPatientID;
            }
            
        }

        public void SavePatientToMedicines(RecordsMedicine recordsMedicine)
        {
            using (context = new MedicalStore_dbEntities())
            {
                context.RecordsMedicines.Add(recordsMedicine);
                context.SaveChanges();
            }
        }
        /// <summary>
        /// getting the records of pateints along with bills and medical record.
        /// </summary>
        /// <param name="name">Nullable</param>
        /// <returns>Tuple<List<Patient>,Patient></returns>
        public Tuple<List<Patient>,Patient> GetPatients(string name=null)
        {
            using (context=new MedicalStore_dbEntities())
            {
                // getting all records
                var result=  context.Patients.Include(p=>p.PateintRecords).ToList();

                Tuple<List<Patient>, Patient> record ;
                if (name ==null)
                {
                    record = new Tuple<List<Patient>, Patient>(result,null);
                    return record;
                }
                else
                {
                    record = new Tuple<List<Patient>, Patient>(null, result.Where(u => u.PatientName.ToLower() == name.ToLower()).Single());
                    return record;
                }
            }
        }

        public int SaveBill(Bill bill)
        {
            using (context=new MedicalStore_dbEntities())
            {
                context.Bills.Add(bill);
                context.SaveChanges();
                return bill.ID;
            }
        }

        public void BillToMedicines(BillMedicine billMedicine)
        {
            using (context=new MedicalStore_dbEntities())
            {
                context.BillMedicines.Add(billMedicine);
                context.SaveChanges();
            }
        }

        public void UpdatePatient(Patient objPateint)
        {
            using (context = new MedicalStore_dbEntities())
            {
                context.Patients.Attach(objPateint);
                context.Entry(objPateint).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        /// <summary>
        /// Getting the ID Based Pateint and Saves the Records against it. 
        /// </summary>
        /// <param name="pateintID"></param>
        /// <param name="pateintRecord"></param>
        public void AddRecordToPatient(int pateintID,PateintRecord pateintRecord)
        {
            using (context = new MedicalStore_dbEntities())
            {
                Patient existingPateint=context.Patients.Find(pateintID);
                pateintRecord.Patient = existingPateint;
                context.PateintRecords.Add(pateintRecord);
                context.SaveChanges();
            }
        }

        public void UpdateRecordToMedicines(RecordsMedicine recordsMedicine)
        {
            using (context = new MedicalStore_dbEntities())
            {
                context.Entry(recordsMedicine).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public int SavePatient(PateintRecord pateintRecord)
        {
            using (context = new MedicalStore_dbEntities())
            {
                context.PateintRecords.Add(pateintRecord);
                context.SaveChanges();
                int SavedPatientID = pateintRecord.Patient.ID;
                return SavedPatientID;
            }
        }
    }
}
