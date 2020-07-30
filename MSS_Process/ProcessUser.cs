using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Data;
using LocalDataBase;

namespace BusinessLogic
{
    public class ProcessUser
    {
        MedicalStore_dbEntities context;
        /// <summary>
        /// Encrypts a password and returns an encrypted password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public string Encrypt(string password)
        {
            string EncryptionKey = "MAKPROGRAMMER";
            byte[] clearBytes = Encoding.Unicode.GetBytes(password);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    password = Convert.ToBase64String(ms.ToArray());
                }
            }
            return password;
        }

        public void CreateUser(User user)
        {
            using (context=new MedicalStore_dbEntities())
            {
              var Password= Encrypt(user.Password);
                user.Password = Password;
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
        /// <summary>
        /// Confirms the user, if already exists, returns true. 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool UserExist(User user)
        {
            using (context=new MedicalStore_dbEntities())
            {
               var userExiting= context.Users.Where(u => u.Username == user.Username).FirstOrDefault();
                if (userExiting != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Decrypts a password and returns an decrypted password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public string Decrypt(string password)
        {
            string EncryptionKey = "MAKPROGRAMMER";
            byte[] cipherBytes = Convert.FromBase64String(password);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    password = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return password;
        }

        public List<User> GetUsers()
        {
                using (context = new MedicalStore_dbEntities())
                {
                    var result = context.Users.ToList();
                    return result;
                }
            
        }

        public void UpdateUser(User user)
        {
            using (context = new MedicalStore_dbEntities())
            {
                context.Entry(user).State =EntityState.Modified;
                context.SaveChanges();
            }
        }
            

        public string GetUserPasswordByName(string name)
        {
            using (context = new MedicalStore_dbEntities())
            {

                string result= context.Users.Where(u => u.Username == name).Select(x => x.Password).FirstOrDefault();
                return result;
            }
        }
        public User GetUser(string name, string pass)
        {
            using (context = new MedicalStore_dbEntities())
            {

               var result= context.Users.Where(y => y.Password == pass && y.Username == name);
                return result.First();
            }
        }

        public void LoggoutUser(User LoggedInUser)
        {
            using (context=new MedicalStore_dbEntities())
            {
               var user= context.Users.Where(y => y.Password == LoggedInUser.Password && y.Username == LoggedInUser.Username).First();
               
                user.IsLoggedin = false;
                context.Entry(user).State =EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}