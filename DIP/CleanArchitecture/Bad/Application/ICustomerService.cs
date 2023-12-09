using DIP.CleanArchitecture.Bad.Domain;

namespace DIP.CleanArchitecture.Bad.Application;

public interface ICustomerService
{
    public Customer GetById(int id);
    public void Add(Customer customer);
    public List<Customer> Getall();
}