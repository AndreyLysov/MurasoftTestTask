using MurTestTask.pages;
using System;

namespace MurTestTask.helpers
{
    public class MainHelper : MainPage
    {
        public void OpenLoginForm()
        {
            WaitUntilPageIsLoaded();
            btnLogin.Click();
        }

        public void OpenSignUpForm()
        {
            WaitUntilPageIsLoaded();
            btnSignup.Click();
        }
    }
}
