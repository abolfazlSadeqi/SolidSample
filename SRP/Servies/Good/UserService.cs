
using SRP.Servies.Models;

namespace SRP.Servies.Good;

public class UserService : UserValidate
{
    public readonly UserValidate userValidate;
    public readonly EmailService emailService;
    public readonly UserRepository userRepository;

    public UserService(UserValidate userValidate, EmailService emailService, UserRepository userRepository)
    {
        this.userValidate = userValidate;
        this.emailService = emailService;
        this.userRepository = userRepository;

    }
    public void InsertUser(UserViewModel userViewModel)
    {
        userValidate.Validate(userViewModel);
        userRepository.Insert(userViewModel);
        emailService.SendEmail();
    }




}
