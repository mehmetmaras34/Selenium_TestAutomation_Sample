using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Sample.Model
{
    public class LoginPage : BasePage
    {
        private IWebDriver webDriver;
        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
            this.webDriver = webDriver;
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='login-email']")]
        public IWebElement txtEmail;

        [FindsBy(How = How.XPath, Using = "//*[@id='login-password-input']")]
        public IWebElement txtPassword;

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'submit')]")]
        public IWebElement btnSubmit;

        public void SetEmail(string email)
        {
            SetText(txtEmail, email);
        }
        public void SetPassword(string password)
        {
            SetText(txtPassword, password);
        }
        public void ClickSubmitLogin()
        {
            ClickElement(btnSubmit);
        }
    }
}