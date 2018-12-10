using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace MurTestTask.pages
{
    public class BasePage
    {
        protected static IWebDriver driver;
        protected static WebDriverWait wait;

        public BasePage()
        {
            if(driver != null)
                PageFactory.InitElements(driver, this);
        }
    }
}