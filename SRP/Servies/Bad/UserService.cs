using SRP.Servies.Models;
using SRP.Servies.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Servies.Bad;

public class UserService

{
    public void InsertUser(UserViewModel userViewModel)
    {
        if (string.IsNullOrEmpty(userViewModel.Name))
            throw new InvalidOperationException();

        if (string.IsNullOrEmpty(userViewModel.Family))
            throw new InvalidOperationException();

        if (userViewModel.Age == 0)
            throw new Exception("Age is not valid");


        TestContext testContext = new TestContext();
        testContext.UserViewModels.Add(
            new UserViewModel()
            {
                Age = userViewModel.Age,
                Name = userViewModel.Name,
                Family = userViewModel.Family
            });

        testContext.SaveChanges();

        SmtpClient client = new SmtpClient("mail.gmail.com");
        client.Send(new MailMessage());
    }
}
