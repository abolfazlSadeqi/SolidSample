
using SRP.CustomerClub.Good;
namespace SRP.CustomerClub.Good;


public class CustomerService
{
    private CustomerCal CustomerCal;
    private CustomerValidate customerValidate;
    private Log log;

    public CustomerService(CustomerCal CustomerCal, CustomerValidate customerValidate, Log log)
    {
        this.CustomerCal = CustomerCal;
        this.customerValidate = customerValidate;
        this.log = log;

    }


    public void InsertPoint(CustomerBase Customer)
    {
        if (!customerValidate.Validate(Customer))
            log.Save("Balace Not Valid");
        var point = CustomerCal.CalcautePoint(Customer.Balance);
        if (point == 0)
            log.Save("point Not Valid");

        //To do
    }



}




