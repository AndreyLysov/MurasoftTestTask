using MurTestTask.models;
using MurTestTask.pages;

namespace MurTestTask.helpers
{
    public class LoginHelper : LoginForm
    {
        public void FillInform(UserData user)
        {
            inputEmail.SendKeys(user.Email);
            inputPassword.SendKeys(user.Password);
        }

        public string GetEmailWarningText()
        {
            return wrnInvalidEmail.Text;
        }
    }
}
