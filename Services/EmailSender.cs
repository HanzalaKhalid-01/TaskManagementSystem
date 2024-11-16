using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace TaskManagementSystem.Services
{
public class EmailSender
{
    public static void SendEmail(string toEmail, string subject, string body)
    {
        var smtp = new SmtpClient
        {
            Host = "smtp.gmail.com",
            Port = 587,
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential("hanzalabinkhalid@gmail.com", "nzrrhknlkscxxvrq")
        };

        using (var message = new MailMessage("hanzalabinkhalid@gmail.com", toEmail)
        {
            Subject = subject,
            Body = body,
            IsBodyHtml = true
        })
        {
            smtp.Send(message);
        }
    }
}
}
