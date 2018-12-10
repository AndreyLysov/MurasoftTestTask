using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace MurTestTask.pages
{
    public class MainPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "login-button")]
        protected IWebElement btnLogin;
        [FindsBy(How = How.Id, Using = "signup-button")]
        protected IWebElement btnSignup;
        [FindsBy(How = How.Id, Using = "output")]
        protected IWebElement txtOutput;

        //This method is needed for avoiding throwing exception because not possible to click anything before the code is exececuted
        protected void WaitUntilPageIsLoaded()
        {
            wait.Until(ExpectedConditions.TextToBePresentInElement(txtOutput, "Hello World"));
        }
    }
}
