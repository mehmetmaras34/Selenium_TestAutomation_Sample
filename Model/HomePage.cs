using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Sample.Model
{
    public class HomePage : BasePage
    {
        private IWebDriver webDriver;
        public HomePage(IWebDriver webDriver) : base(webDriver)
        {
            this.webDriver = webDriver;
        }

        [FindsBy(How = How.XPath, Using = "//a[@title='Close']")]
        public IWebElement btnClosePopup;

        [FindsBy(How = How.XPath, Using = "//*[@id='account-navigation-container']/div/div[1]/div[1]/p")]
        public IWebElement btnLogin;

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-root']/div/div/div[1]")]
        public IWebElement btnCloseLoginPopup;

        [FindsBy(How = How.XPath, Using = "//input[@class='search-box']")]
        public IWebElement txtSearch;

        [FindsBy(How = How.XPath, Using = "//i[@class='search-icon']")]
        public IWebElement txtSearchButton;

        [FindsBy(How = How.XPath, Using = "//div[@class='p-card-wrppr']")]
        public IList<IWebElement> btnProductList;

        public void CloseThePopup()
        {
            ClickElement(btnClosePopup);
        }
        public void ClickToLogin()
        {
            ClickElement(btnLogin);
        }
        public void CloseLoginPopup()
        {
            ClickElement(btnCloseLoginPopup);
        }
        public void SearchProduct(string product)
        {
            SetText(txtSearch, product);
            txtSearch.SendKeys(Keys.Enter);
        }
        public void SelectProduct()
        {
            Wait(10);
            Random rnd = new Random();
            int rndProduct = rnd.Next(1, btnProductList.Count - 1);
            ClickableElement(btnProductList[rndProduct]);
            ClickElement(btnProductList[rndProduct]);
        }

    }
}