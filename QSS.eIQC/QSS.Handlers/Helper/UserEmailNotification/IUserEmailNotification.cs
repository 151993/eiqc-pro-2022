using QSS.eIQC.Domain.Models;

namespace QSS.eIQC.Handlers.Helper.UserEmailNotification
{
    public interface IUserEmailNotificationHelper
    {
        void SendEmailWhenNewUserAdded(User input);
    }
}
