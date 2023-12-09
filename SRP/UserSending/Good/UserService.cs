using SRP.UserSending.Model;

namespace SRP.UserSending.Good;

public class UserService
{
    private EmailService emailService;
    private SmsService smsService;
    private FaxService faxService;

    public UserService(EmailService emailService, SmsService smsService, FaxService faxService)
    {
        this.emailService = emailService;
        this.smsService = smsService;
        this.faxService = faxService;

    }
    public bool Send(User user)
    {
        emailService.Send(user);
        smsService.Send(user);
        faxService.Send(user);
       //to do
        return true;
    }
       
}
