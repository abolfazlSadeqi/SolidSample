using DIP.CleanArchitecture.Good.Domain;

namespace DIP.CleanArchitecture.Good.Application;

public interface ICustomerService
{
    public Customer GetById(int id);
    public void Add(Customer customer);
    public List<Customer> Getall();
}