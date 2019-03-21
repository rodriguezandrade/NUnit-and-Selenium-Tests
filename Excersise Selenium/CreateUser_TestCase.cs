using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;


namespace Excersise_Selenium
{
    [TestClass]
   public class CreateUser
    {
        [TestMethod]
        [Description ("Create a user")]
        [Owner("Jonathan")]
        [Priority(0)]
        public void SignUp()
        {
            
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("signup")).Click();
            driver.FindElement(By.Id("name")).SendKeys("testtfakeJonathan Rodríguez");
            driver.FindElement(By.Id("email")).SendKeys("testtfake@mail.com");
            driver.FindElement(By.Id("password")).SendKeys("P@ssw0rd");
            driver.FindElement(By.Id("signupButtom")).Click();
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            driver.FindElement(By.Id("sign")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("username")).SendKeys("testtfake@mail.com");
            driver.FindElement(By.Id("password")).SendKeys("P@ssw0rd");
            driver.FindElement(By.Id("submitSign")).Click();
            Thread.Sleep(3000);
            var username = driver.FindElement(By.Id("nameuser")).Text;
            Thread.Sleep(3000);
            Assert.IsTrue(username.Contains("testtfakeJonathan Rodríguez")); ;
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            driver.Close();
            driver.Quit();
        }

        
    }

}
