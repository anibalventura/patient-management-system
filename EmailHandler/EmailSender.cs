using System;
using System.Net;
using System.Net.Mail;

namespace EmailHandler
{
    public class EmailSender
    {
        public void SendEmail(string to, string subject, string body)
        {
            try
            {
                MailMessage newMail = new MailMessage();
                newMail.From = new MailAddress(EmailSetting.Default.From);
                newMail.To.Add(to);
                newMail.Subject = subject;
                newMail.Body = body;

                SmtpClient smtpServer = new SmtpClient(EmailSetting.Default.SmtpServer);
                smtpServer.Port = EmailSetting.Default.Port;
                smtpServer.Credentials = new NetworkCredential(EmailSetting.Default.From, EmailSetting.Default.Password);
                smtpServer.EnableSsl = true;

                smtpServer.Send(newMail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}