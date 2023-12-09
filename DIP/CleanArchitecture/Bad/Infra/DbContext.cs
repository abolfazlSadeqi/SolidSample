using DIP.CleanArchitecture.Bad.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.CleanArchitecture.Bad.Infra;

public class DbContext
{
    public Customer customer { set; get; }

    public void Save<T>(T t)
    {

    }
}
