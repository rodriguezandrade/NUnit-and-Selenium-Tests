using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;


namespace Excersise_Selenium
{
    [TestClass]
   public class SignIn
    {
            IWebDriver driver = new ChromeDriver();

        [TestMethod]
        [Description("Sig in User")]
        [Owner("Jonathan")]
        [Priority(1)]
        public void Login()
        {
        fillSignIn();
        Thread.Sleep(2000);
        var username = driver.FindElement(By.Id("nameuser")).Text;
        Assert.IsTrue(username.Contains("Master"));
        Thread.Sleep(2000);
        driver.Navigate().GoToUrl("http://localhost:54467/#/home");
        driver.Close();
        driver.Quit();
    }

        public void fillSignIn()
        {
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("sign")).Click();
            driver.FindElement(By.Id("username")).SendKeys("master@mail.com");
            driver.FindElement(By.Id("password")).SendKeys("P@ssw0rd");
            driver.FindElement(By.Id("submitSign")).Click();
           
        }

    }


}
