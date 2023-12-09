using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Servies.Good;

public class EmailService
{
    public void SendEmail()
    {
        SmtpClient client = new SmtpClient("mail.gmail.com");
        client.Send(new MailMessage());
    }
}
