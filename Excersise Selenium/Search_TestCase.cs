using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.UI;

namespace Excersise_Selenium
{
    
    [TestClass]
   public class Search
    {
        [TestMethod]
        [Description("Search Product")]
        [Owner("Jonathan")]
        [Priority(1)]
        public void SearchByCategory()
        {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://localhost:54467/#/home");
        driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("searchProduct")).SendKeys("MSI Gaming");
            driver.FindElement(By.Id("SearchTextBox")).Click();
            Thread.Sleep(3000);
        driver.Navigate().GoToUrl("http://localhost:54467/#/home");
        driver.Close();
        driver.Quit();
    }
    }

}
