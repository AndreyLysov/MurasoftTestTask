using MurTestTask.pages;

namespace MurTestTask.helpers
{
    public class MainHelper : MainPage
    {
        public void OpenLoginForm()
        {
            btnLogin.Click();
        }

        public void OpenSignUpForm()
        {
            btnSignup.Click();
        }
    }
}
