using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Excersise_Selenium
{
    [TestClass]
    public class Checkout
    {
        [TestMethod]
        [Description("Add to Cart")]
        [Owner("Jonathan")]
        [Priority(2)]
        public void CheckoutCart()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("sign")).Click();
            driver.FindElement(By.Id("username")).SendKeys("master@mail.com");
            driver.FindElement(By.Id("password")).SendKeys("P@ssw0rd");
            driver.FindElement(By.Id("submitSign")).Click();
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("1134")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("addCart")).Click();
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("Cart")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("Checkout")).Click();
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("Cart")).Click();
            Thread.Sleep(2000);
            var username = driver.FindElement(By.Id("normal")).Text;
            Thread.Sleep(3000);
            Assert.IsTrue(username.Contains(""));
            driver.Close();
            driver.Quit();
        }
    }
}
