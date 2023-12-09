using DIP.CleanArchitecture.Good.Domain;

namespace DIP.CleanArchitecture.Good.Application;

public interface IRepositoryService
{
    public void GetById(int id);
    public Customer Add(Customer customer);
    public List<Customer> Getall();
}