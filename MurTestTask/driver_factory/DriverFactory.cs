using MurTestTask.common;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace MurTestTask.driver_factory
{
    public class DriverFactory
    {
        private static IWebDriver driver;

        public static IWebDriver GetDriver()
        {
            switch (System.Configuration.ConfigurationSettings.AppSettings.Get("browser"))
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Constants.ImplicitWait);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(System.Configuration.ConfigurationSettings.AppSettings.Get("baseUrl"));

            return driver;
        }
    }
}
