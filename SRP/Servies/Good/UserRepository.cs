using SRP.Servies.Models;
using SRP.Servies.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Servies.Good;

public class UserRepository
{
    public void Insert(UserViewModel userViewModel)
    {
        TestContext testContext = new TestContext();
        testContext.UserViewModels.Add(
            new UserViewModel()
            {
                Age = userViewModel.Age,
                Name = userViewModel.Name,
                Family = userViewModel.Family
            });

        testContext.SaveChanges();
    }
}
