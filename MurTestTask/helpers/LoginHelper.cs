using MurTestTask.models;
using MurTestTask.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
