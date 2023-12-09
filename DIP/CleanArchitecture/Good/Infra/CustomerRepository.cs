using DIP.CleanArchitecture.Bad.Domain;
using DIP.CleanArchitecture.Good.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.CleanArchitecture.Good.Infra;

public class CustomerRepository : IRepositoryService
{
    private DbContext dbContext;
    public CustomerRepository(DbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    public void Add(Customer customer)
    {
        dbContext.Save(customer);
    }

    public List<Customer> Getall()
    {
        //to do
        return new List<Customer>();
    }

    public Customer GetById(int id)
    {
        //to do
        return new Customer();
    }
}
