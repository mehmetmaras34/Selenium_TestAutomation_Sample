using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Sample.Utilities
{
    public class BrowserUtilitity
    {
        public IWebDriver webDriver;

        public IWebDriver SetupChromeDriver(string driver)
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("start-maximized");
            chromeOptions.AddArgument("test-type");
            chromeOptions.AddArgument("disable-popup-blocking");
            chromeOptions.AddArgument("ignore-certificate-errors");
            chromeOptions.AddArgument("disable-translate");
            chromeOptions.AddArgument("disable-automatic-password-saving");
            chromeOptions.AddArgument("allow-silent-push");
            chromeOptions.AddArgument("disable-infobars");
            chromeOptions.AddArgument("disable-notifications");
            chromeOptions.AddAdditionalCapability("useAutomationExtension", false);
            webDriver = new ChromeDriver(driver, chromeOptions);
            return webDriver;
        }

        public void TearDown()
        {
            webDriver.Quit();
        }
    }
}