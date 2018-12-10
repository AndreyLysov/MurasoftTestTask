using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MurTestTask.pages
{
    public class LoginForm : BasePage
    {
        [FindsBy(How = How.Id, Using = "Email")]
        protected IWebElement inputEmail;
        [FindsBy(How = How.Id, Using = "Password")]
        protected IWebElement inputPassword;
        [FindsBy(How = How.XPath, Using = "//button[text()='Log in']")]
        protected IWebElement btnLogin;
        [FindsBy(How = How.XPath, Using = "//span[@class='field-validation-error help-block']")]
        protected IWebElement wrnInvalidEmail;
    }
}
