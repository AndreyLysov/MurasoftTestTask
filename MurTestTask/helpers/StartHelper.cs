﻿using MurTestTask.pages;
using System;

namespace MurTestTask.helpers
{
    public class StartHelper : StartPage
    {
        public void OpenLoginForm()
        {
            Console.WriteLine("Waiting for execution the code");
            WaitUntilPageIsLoaded();
            Console.WriteLine("Clicking 'Log in' link");
            btnLogin.Click();
        }

        public void OpenSignUpForm()
        {
            WaitUntilPageIsLoaded();
            btnSignup.Click();
        }
    }
}
