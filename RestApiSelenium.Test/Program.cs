using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace RestApiSelenium.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = @"https://docs.microsoft.com/ru-ru/";
            driver.FindElement(By.XPath(@".//input[@id='ax-43']")).SendKeys("c#");
            Actions builder = new Actions(driver);
            builder.SendKeys(Keys.Enter);
            Thread.Sleep(3000);
            var links = driver.FindElements(By.XPath(".//data-bi-name='result'"));
            foreach (IWebElement link in links)
            Console.WriteLine("{0} - {1}", link.Text, link.GetAttribute("href"));
        }
    }
}
