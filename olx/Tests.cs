using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace olx
{
    [TestFixture]
    public class Class1
    {
        static string GoodsUrl = "https://www.olx.ua/obyavlenie/prodam-shikarnogo-persikovogo-myagkogo-zaychenka-1-5-m-vysota-ID8gdJF.html#f5e5cfebb7";
        static void pageWithgoods(ChromeDriver browser)
        {
            browser.Navigate().GoToUrl("https://www.olx.ua/obyavlenie/prodam-shikarnogo-persikovogo-myagkogo-zaychenka-1-5-m-vysota-ID8gdJF.html#f5e5cfebb7");
        }
        static void CategoriesOfMain(string nameOfCategoria, string buttonAll)
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://www.olx.ua");
            IWebElement categoria = browser.FindElement(By.CssSelector(nameOfCategoria));
            categoria.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement button = browser.FindElement(By.CssSelector(buttonAll));
            button.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            browser.Close();
        }

        [Test]
        public void go_to_home_page()
        {
            ChromeDriver browser = new ChromeDriver();
            pageWithgoods(browser);
            IWebElement button = browser.FindElement(By.CssSelector("#headerLogo"));
            button.Click();
            IWebElement button1 = browser.FindElement(By.CssSelector("#submit-searchmain"));
            button1.Click();
            browser.Close();
        }

        [Test]
        public void submit_search()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://www.olx.ua");
            IWebElement button = browser.FindElement(By.CssSelector("#submit-searchmain"));
            button.Click();
            browser.Close();
        }

        [Test]
        public void all_in_deti()
        {
            var c = "#searchmain-container > div > div > div:nth-child(1) > div:nth-child(1) > div > a";
            var buttonall = "#bottom36 > div > a";
            CategoriesOfMain(c, buttonall);
        }

        [Test]
        public void nedviz()
        {
            var nameOfCategoria = "#searchmain-container > div > div > div:nth-child(1) > div:nth-child(2) > div > a > span:nth-child(1)";
            CategoriesOfMain(nameOfCategoria, "#bottom1 > div > a > strong");

        }

        [Test]
        public void cars()
        {
            var nameOfCategoria = "#searchmain-container > div > div > div:nth-child(1) > div:nth-child(3) > div > a > span:nth-child(1)";
            CategoriesOfMain(nameOfCategoria, "#bottom1532 > div > a > strong");
        }

        [Test]
        public void zapchast()
        {
            var nameOfCategoria = "#searchmain-container > div > div > div:nth-child(1) > div:nth-child(4) > div > a > span:nth-child(1)";
            CategoriesOfMain(nameOfCategoria, "#bottom3 > div > a > strong");
        }

        [Test]
        public void rabota()
        {
            var nameOfCategoria = "#searchmain-container > div > div > div:nth-child(6) > div:nth-child(1) > div > a > span:nth-child(1)";
            CategoriesOfMain(nameOfCategoria, "#bottom6 > div > a > strong");
        }

        [Test]
        public void animal()
        {
            var nameOfCategoria = "#searchmain-container > div > div > div:nth-child(6) > div:nth-child(2) > div > a > span:nth-child(1)";
            var buttonAll = "#bottom35 > div > a > strong";
            CategoriesOfMain(nameOfCategoria, buttonAll);

        }

        [Test]
        public void dom()
        {
            var nameOfCategoria = "#searchmain-container > div > div > div:nth-child(6) > div:nth-child(3) > div > a > span:nth-child(1)";
            var buttonAll = "#bottom899 > div > a > strong";
            CategoriesOfMain(nameOfCategoria, buttonAll);

        }

        [Test]
        public void electron()
        {
            var nameOfCategoria = "#searchmain-container > div > div > div:nth-child(6) > div:nth-child(4) > div > a > span:nth-child(1)";
            var buttonAll = "#bottom37 > div > a > strong";
            CategoriesOfMain(nameOfCategoria, buttonAll);

        }

        [Test]
        public void bussines()
        {
            var nameOfCategoria = "#searchmain-container > div > div > div:nth-child(11) > div:nth-child(1) > div > a > span:nth-child(1)";
            CategoriesOfMain(nameOfCategoria, "#bottom7 > div > a > strong");
        }

        [Test]
        public void moda()
        {
            var nameOfCategoria = "#searchmain-container > div > div > div:nth-child(11) > div:nth-child(2) > div > a > span:nth-child(1)";
            CategoriesOfMain(nameOfCategoria, "#bottom891 > div > a > strong");
        }

        [Test]
        public void hobbi()
        {
            var nameOfCategoria = "#searchmain-container > div > div > div:nth-child(11) > div:nth-child(3) > div > a > span:nth-child(1)";
            CategoriesOfMain(nameOfCategoria, "#bottom903 > div > a > strong");
        }

        [Test]
        public void darom()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://www.olx.ua");
            IWebElement categoria = browser.FindElement(By.CssSelector("#searchmain-container > div > div > div:nth-child(11) > div:nth-child(4) > div > a > span:nth-child(1)"));
            categoria.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            browser.Close();
        }

        [Test]
        public void obmen()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://www.olx.ua");
            IWebElement categoria = browser.FindElement(By.CssSelector("#searchmain-container > div > div > div:nth-child(16) > div.li.fleft > div > a > span:nth-child(1)"));
            categoria.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            browser.Close();
        }

        [Test]
        public void searchInCategory()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://www.olx.ua");
            IWebElement zapas = browser.FindElement(By.CssSelector("#searchmain-container > div > div > div:nth-child(1) > div:nth-child(4)"));
            zapas.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement button = browser.FindElement(By.CssSelector("#bottom3 > div > a"));
            button.Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            browser.FindElement(By.CssSelector("#search-text"));
            IWebElement TextBox = browser.FindElement(By.CssSelector("#search-text"));
            TextBox.Clear();
            TextBox.SendKeys("резина");
            IWebElement pop = browser.FindElement(By.CssSelector("#paramsListOpt > div > div.fblock.fleft.olx-delivery-filter.last.olx-delivery-filter.js-highlight-element.highlight-element-active > div.highlight-container > div.highlight-text > span"));
            pop.Click();
            IWebElement searchbutton = browser.FindElement(By.CssSelector("#search-submit"));
            searchbutton.Click();
        }

        [Test]
        public void logo()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl(GoodsUrl);
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement cont = browser.FindElement(By.Id("headerLogo"));
            cont.Click();
            browser.Close();
        }
    }
}