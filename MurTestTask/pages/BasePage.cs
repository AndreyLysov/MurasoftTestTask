using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
