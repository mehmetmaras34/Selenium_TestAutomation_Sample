using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Sample.Model
{
    public class FavoritePage : BasePage
    {
        private IWebDriver webDriver;
        public FavoritePage(IWebDriver webDriver) : base(webDriver)
        {
            this.webDriver = webDriver;
        }

        [FindsBy(How = How.XPath, Using = "//div[@class='p-card-wrppr']")]
        public IList<IWebElement> productList;

        [FindsBy(How = How.XPath, Using = "//p[text()='Favorilerim']")]
        public IWebElement btnFavoritePage;

        [FindsBy(How = How.XPath, Using = "//i[@class='ufvrt-btn']")]
        public IWebElement btnDeleteProduct;

        [FindsBy(How = How.XPath, Using = "//p[@class='empty-favorites-header']")]
        public IWebElement txtFavoriteListEmpty;


        public void CheckFavoriList()
        {
            ClickFavoritePage();
            Assert.True(productList.Count > 0, "Favori listesinde ürün vardır.");
        }
        public void ClickFavoritePage()
        {
            webDriver.SwitchTo().Window(webDriver.WindowHandles.First());
            ClickElement(btnFavoritePage);
        }
        public void ClickDeleteProduct()
        {
            ClickElement(btnDeleteProduct);
        }
        public void CheckFavoriteListEmpty()
        {
            ClickableElement(txtFavoriteListEmpty);
            if (txtFavoriteListEmpty.Text == "Favoriler Listeniz Henüz Boş")
            {
                Console.WriteLine("Favori Listesi Boş");
            }
            else Console.WriteLine("Favori Listesi Dolu");
        }


    }
}