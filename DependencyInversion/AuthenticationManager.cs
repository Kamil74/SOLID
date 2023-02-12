namespace DependencyInversion;

public class AuthenticationManager
{
    private INotificationSender notyfificationSender;

    public AuthenticationManager(INotificationSender emailNotification)
    {
        this.notyfificationSender = notyfificationSender;
    }
    public void Authenticate(User user, string email, string password)
    {
        if (user.Email == email && user.Password == password)
        {
           
            notyfificationSender.SendNotification(user);
        }
    }
}