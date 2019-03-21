using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;


namespace Excersise_Selenium
{
    [TestClass]
   public class AddProduct
    {
        [TestMethod]
        [Description("Add Product")]
        [Owner("Jonathan")]
        [Priority(0)]
        public void NewProduct()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("sign")).Click();
            driver.FindElement(By.Id("username")).SendKeys("master@mail.com");
            driver.FindElement(By.Id("password")).SendKeys("P@ssw0rd");
            driver.FindElement(By.Id("submitSign")).Click();
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            Assert.IsTrue(true, "Test Case Passed");
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("productAdministrator")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("name")).SendKeys("hi");
            driver.FindElement(By.Id("detail")).SendKeys("aJonathan Rodríguez");
            driver.FindElement(By.Id("cost")).SendKeys("33");
            driver.FindElement(By.Id("amount")).SendKeys("33");
            driver.FindElement(By.Id("status")).SendKeys("1");
            Thread.Sleep(500);
            driver.FindElement(By.Id("save")).Click();
            Thread.Sleep(3000);
            var name = driver.FindElement(By.Id("toast-container")).Text;
            Assert.IsTrue(name.Contains("Product Register!\r\nProduct Added Sucessfully"));
            Thread.Sleep(3000);
            driver.Close();
            driver.Quit();
        }

    }

}
