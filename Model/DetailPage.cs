using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Sample.Model
{
    public class DetailPage : BasePage
    {
        private IWebDriver webDriver;
        public DetailPage(IWebDriver webDriver) : base(webDriver)
        {
            this.webDriver = webDriver;
        }

        [FindsBy(How = How.XPath, Using = "//div[@class='prc-inf-wrp']/button[@class='pr-in-btn fv']/div[1]")]
        public IWebElement btnAddFavorite;

        public void AddFavorite()
        {
            Wait(10);
            webDriver.SwitchTo().Window(webDriver.WindowHandles.Last());
            ClickableElement(btnAddFavorite);
            ClickElement(btnAddFavorite);
        }

    }
}