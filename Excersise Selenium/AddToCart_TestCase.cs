using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Excersise_Selenium
{
    [TestClass]
    public class AddToCart_TestCase
    {
        [TestMethod]
      
        [Priority(0)]
        public void AddProductToCart()
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
            Thread.Sleep(2000);
            driver.FindElement(By.Id("Cart")).Click();
            Thread.Sleep(2000);
            var username = driver.FindElement(By.Id("MSI Gaming ProductModified 8RE-021XES Raider RGB Negro Portátil 39.6 cm (15.6 ) 1920 x 1080 Pixeles 2.20 GHz 8ª generación de procesadores Intel® Core™ i7 i7-8750H - Ordenador portátil(8ª generación de procesadores Intel® Core™ i7, 2.20 GHz, 39.6 cm 15.6 , 1920 x 1080 Pixeles, 16 GB, 1256 GB)")).Text;
            Thread.Sleep(3000);
            Assert.IsTrue(username.Contains("MSI Gaming ProductModified 8RE-021XES Raider RGB Negro Portátil 39.6 cm (15.6 ) 1920 x 1080 Pixeles 2.20 GHz 8ª generación de procesadores Intel® Core™ i7 i7-8750H - Ordenador portátil(8ª generación de procesadores Intel® Core™ i7, 2.20 GHz, 39.6 cm 15.6 , 1920 x 1080 Pixeles, 16 GB, 1256 GB)"));
            Thread.Sleep(2000);
            driver.Close();
            driver.Quit();
        }
    }
}
