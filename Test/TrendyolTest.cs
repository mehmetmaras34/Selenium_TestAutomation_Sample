using OpenQA.Selenium;
using Selenium_Sample.Model;
using Selenium_Sample.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Selenium_TestAutomation_Sample.Test
{
    [Binding, Scope(Feature = "TrendyolTest")]
    public class TrendyolTest
    {
        public static IWebDriver WebDriver { get; set; }
        public BrowserUtilitity browserUtility;
        public BasePage basePage;
        public LoginPage loginPage;
        public DetailPage detailPage;
        public HomePage homePage;
        public FavoritePage favoritePage;


        string driverPath = String.Empty;

        public TrendyolTest()
        {
            driverPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            browserUtility = new BrowserUtilitity();
        }
        [StepDefinition("Chrome browser ayağa kaldırılır")]
        public void OpenBrowser()
        {
            WebDriver = browserUtility.SetupChromeDriver(driverPath);

            basePage = new BasePage(WebDriver);
            loginPage = new LoginPage(WebDriver);
            detailPage = new DetailPage(WebDriver);
            homePage = new HomePage(WebDriver);
            favoritePage = new FavoritePage(WebDriver);
        }
        [StepDefinition("'(.*)' sitesine gidilir")]
        public void OpenWebPage(string webPageUrl)
        {
            WebDriver.Navigate().GoToUrl(webPageUrl);
        }
        [StepDefinition("Popup kapatılır")]
        public void CloseWebPagePopup()
        {
            homePage.CloseThePopup();
            if (!basePage.GetCurrentUrl().Contains("trendyol.com"))
            {
                Console.WriteLine("Anasayfa yüklenemedi!");
            }
        }
        [StepDefinition("Giriş Yap butonuna tıklanır")]
        public void ClickToLogin()
        {
            homePage.ClickToLogin();
            if (!basePage.GetCurrentUrl().Contains("trendyol.com/giris"))
            {
                Console.WriteLine("Giriş sayfası yüklenemedi!");
            }
        }
        [StepDefinition("E-posta adresi '(.*)' olarak girilir")]
        public void SetEmail(string email)
        {
            loginPage.SetEmail(email);
        }
        [StepDefinition("Şifre '(.*)' olarak girilir")]
        public void SetPassword(string password)
        {
            loginPage.SetPassword(password);
        }

        [StepDefinition("Giriş yap butonuna tıklanır")]
        public void ClickToSubmitLogin()
        {
            loginPage.ClickSubmitLogin();
        }
        [StepDefinition("Login olduktan sonra çıkan popup kapatılır")]
        public void CloseLoginPopup()
        {
            homePage.CloseLoginPopup();
            if (!basePage.GetCurrentUrl().Contains("trendyol.com/butik/liste/"))
            {
                Console.WriteLine("Anasayfa yüklenemedi!");
            }
        }
        [StepDefinition("Arama alanına '(.*)' yazılarak aratılır")]
        public void SearchProduct(string product)
        {
            homePage.SearchProduct(product);
        }
        [StepDefinition("Rastgele bir ürün seçilerek detay sayfası açılır")]
        public void SelectRandomProduct()
        {
            homePage.SelectProduct();
        }
        [StepDefinition("Detay sayfasında ürün favorilere eklenir")]
        public void AddFavorite()
        {
            detailPage.AddFavorite();
        }
        [StepDefinition("Favoriler sayfasına gidilerek ürünün olup olmadığı kontrol edilir")]
        public void CheckFavoriList()
        {
            favoritePage.CheckFavoriList();
        }
        [StepDefinition("Ürün favorilerden çıkarılır")]
        public void DeleteProduct()
        {
            favoritePage.ClickDeleteProduct();
        }

        [StepDefinition("Ürünün favorilerde olmadığı doğrulanır")]
        public void CheckFavoriteListEmpty()
        {
            favoritePage.CheckFavoriteListEmpty();
        }

    }
}