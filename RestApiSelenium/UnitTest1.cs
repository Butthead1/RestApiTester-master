using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;
using OpenQA.Selenium.Firefox;

namespace RestApiSelenium
{
    public class Tests
    {
        IWebDriver driverChrome;
        IWebDriver driverFireFox;
        [SetUp]
        public void Setup()
        {
            driverChrome = new ChromeDriver();
            driverFireFox = new FirefoxDriver();

        }

        [Test]
        public void TestChrome()
        {
          
            string searchName = "LINQ";
            driverChrome.Url = @"https://docs.microsoft.com/ru-ru/";
            //driverChrome.FindElement(By.XPath(@".//div[@id='nav-bar-search']/form/div[@class='autocomplete']/div[@class='control has-icons-left']/ input[@class='autocomplete-input input control has-icons-left is-small']")).SendKeys(searchName);
            driverChrome.FindElement(By.Name("terms")).SendKeys(searchName); 
            Actions builder = new Actions(driverChrome);
            builder.SendKeys(Keys.Enter);
            Thread.Sleep(3000);
            var links = driverChrome.FindElements(By.XPath(".//data-bi-name='result'"));
            if (links != null)
            {   
                var items = links.Count;
                if (items > 50) items = 50;
                for (int i = 0; i < items; i++)
                {
                  bool res = links[i].Text.Contains(searchName.ToLower());
                    Assert.IsTrue(res, "Поиск корректен!");
                }

            }
        }

        [Test]
        public void TestFireFox()
        {

            string searchName = "LINQ";
            driverFireFox.Url = @"https://docs.microsoft.com/ru-ru/";
            driverFireFox.FindElement(By.XPath(@".//input[@id='ax-43']")).SendKeys(searchName);
            Actions builder = new Actions(driverFireFox);
            builder.SendKeys(Keys.Enter);
            Thread.Sleep(3000);
            var links = driverFireFox.FindElements(By.XPath(".//data-bi-name='result'"));
            if (links != null)
            {
                var items = links.Count;
                if (items > 50) items = 50;
                for (int i = 0; i < items; i++)
                {
                    bool res = links[i].Text.Contains(searchName.ToLower());
                    Assert.IsTrue(res, "Поиск корректен!");
                }

            }
        }
    }
}