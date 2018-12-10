using MurTestTask.common;
using MurTestTask.driver_factory;
using MurTestTask.pages;
using OpenQA.Selenium.Support.UI;
using System;

namespace MurTestTask.helpers
{
    public class BaseHelper : BasePage
    {   
        public void StartApp()
        {
            driver = DriverFactory.GetDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Constants.ExplicitWait));
        }

        public void StopApp()
        {
            driver.Quit();
        }
    }
}
