using MurTestTask.common;
using MurTestTask.driver_factory;
using MurTestTask.pages;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MurTestTask.helpers
{
    public class BaseHelper : BasePage
    {

        public BaseHelper() { }
        
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
