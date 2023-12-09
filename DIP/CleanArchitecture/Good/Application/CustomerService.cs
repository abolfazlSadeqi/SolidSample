
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIP.CleanArchitecture.Good.Domain;
namespace DIP.CleanArchitecture.Good.Application;
public class CustomerService : ICustomerService
{

    private readonly IRepositoryService _IRepositoryService;

    public CustomerService(IRepositoryService IRepositoryService)
    {
        _IRepositoryService = IRepositoryService;
    }

    public void Add(Customer customer)
    {
        _IRepositoryService.Add(customer);
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
