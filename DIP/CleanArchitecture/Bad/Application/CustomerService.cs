using DIP.CleanArchitecture.Bad.Domain;
using DIP.CleanArchitecture.Bad.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.CleanArchitecture.Bad.Application;
public class CustomerService : ICustomerService
{

    private readonly DbContext _DbContext;

    public CustomerService(DbContext DbContext)
    {
        _DbContext = DbContext;
    }

    public void Add(Customer customer)
    {
        _DbContext.Save(customer);
    }

    public List<Customer> Getall()
    {

        //to do
        return null;
    }

    public Customer GetById(int id)
    {
        //to do
        return null;
    }
}
