using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net.Mime;

namespace SendText
{
    class Text
    {
        public static void Main(string[] args)
        {
            MailMessage mail = new MailMessage();
            mail.Subject = "Hudl CRAI goes SMS";
            mail.Sender = new MailAddress("support@hudl.com", "Hudl Support");
            mail.From = new MailAddress("support@hudl.com", "Hudl Support");
            mail.To.Add("4022166747@vtext.com");
            mail.Body = "Looks like you had a prob. Replies go in to zendesk. This is Rez :)";
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.office365.com";
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("Support@hudl.com", "Hudd1ePassw0rd");

            try
            {
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
