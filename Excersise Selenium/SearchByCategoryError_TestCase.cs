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
   public class SearchByCategoryError
    {
        [TestMethod]
        [Description("Search Product")]
        [Owner("Jonathan")]
        [Priority(1)]
        public void SearchByCategoriesError()
        {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://localhost:54467/#/home");
        driver.Manage().Window.Maximize();
        List<string> Category = new List<string>();
        ReadOnlyCollection<IWebElement> categories = driver.FindElements(By.Id("categories"));
            foreach (IWebElement ListCategories in categories)
            {
                string cat = ListCategories.Text;
                cat = cat.Substring(0, cat.LastIndexOf("\r"));
                Category.Add(cat);
            }
        SelectElement selectCategory = new SelectElement(driver.FindElement(By.Id("categories")));

            driver.FindElement(By.Id("searchProduct")).SendKeys("MSI Gaming");
            selectCategory.SelectByValue("Fashion");
            driver.FindElement(By.Id("SearchTextBox")).Click();
            Thread.Sleep(3000);
        driver.Navigate().GoToUrl("http://localhost:54467/#/home");
        driver.Close();
        driver.Quit();
    }
    }

}
