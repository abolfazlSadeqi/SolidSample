using Microsoft.EntityFrameworkCore;
using SRP.Servies.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Servies.Services;


public class TestContext : DbContext
{
    public DbSet<UserViewModel> UserViewModels { get; set; }

}

