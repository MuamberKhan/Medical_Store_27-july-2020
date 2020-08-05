using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MSS_Process
{
   public class ProcessAboutme
    {
        public bool validateEmail(string _email)
        {
            var foo = new EmailAddressAttribute();
            bool bar;
            bar = foo.IsValid(_email);
            if (new EmailAddressAttribute().IsValid(_email))
                return true;
            else
                return false;
        }
        public bool Send_Email(string senderName, string senderEmail, string message)
        {

            try
            {
                if (senderEmail != string.Empty && senderName != string.Empty)
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                    mail.From = new MailAddress("muamberalikhan@gmail.com");
                    mail.To.Add(senderEmail);
                    mail.Subject = "From: " + senderName + " Medical Store";
                    mail.Body = message;


                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("muamberalikhan@gmail.com", "password");
                    SmtpServer.EnableSsl = true;


                    SmtpServer.Send(mail);
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }


        public Task<bool> Send_EmailAsync(string senderName, string senderEmail, string message)
        {
            return Task.Factory.StartNew(() =>
            {
                try
                {
                    if (senderEmail != string.Empty && senderName != string.Empty)
                    {
                        MailMessage mail = new MailMessage();
                        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                        mail.From = new MailAddress("muamberalikhan@gmail.com");
                        mail.To.Add(senderEmail);
                        mail.Subject = "From: " + senderName + " Medical Store";
                        mail.Body = message;


                        SmtpServer.Port = 587;
                        SmtpServer.Credentials = new System.Net.NetworkCredential("muamberalikhan@gmail.com", "password");
                        SmtpServer.EnableSsl = true;

                        try
                        {
                            SmtpServer.Send(mail);
                            return true;
                        }
                        catch (Exception ex)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {

                    return false;
                }

            }
                );

        }
    }
}