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
   public class pagination
    {
        [TestMethod]
        [Description("Search Product")]
        [Owner("Jonathan")]
        [Priority(0)]
        public void errorPagination1()
        {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://localhost:54467/#/home");
        driver.Manage().Window.Maximize();
        driver.FindElement(By.Id("paginationId")).Clear();
        driver.FindElement(By.Id("paginationId")).SendKeys("0");
        driver.FindElement(By.Id("SearchTextBox")).Click();
        Thread.Sleep(3000);
        var info = driver.FindElement(By.Id("info")).Text;
         Thread.Sleep(3000);
       Assert.IsTrue(info.Contains("All\r\nElectronic\r\nFashion\r\nSports\r\nAccessories\r\nOffice\r\nMusic, Movies and Series\r\nSearch\r\nProduct amount per page\r\n\r\nMSI Gaming ProductModified 8RE-021XES Raider RGB Negro Portátil 39.6 cm (15.6 ) 1920 x 1080 Pixeles 2.20 GHz 8ª generación de procesadores Intel® Core™ i7 i7-8750H - Ordenador portátil(8ª generación de procesadores Intel® Core™ i7, 2.20 GHz, 39.6 cm 15.6 , 1920 x 1080 Pixeles, 16 GB, 1256 GB)\r\naJonathan Rdodríguez\r\nElectronic1\r\nDetails\r\nOrder Now\r\nCost: 33\r\nOld Cost:33\r\nMSI Gaming ProductModified 8RE-021XES Raider RGB Negro Portátil 39.6 cm (15.6 ) 1920 x 1080 Pixeles 2.20 GHz 8ª generación de procesadores Intel® Core™ i7 i7-8750H - Ordenador portátil(8ª generación de procesadores Intel® Core™ i7, 2.20 GHz, 39.6 cm 15.6 , 1920 x 1080 Pixeles, 16 GB, 1256 GB)\r\naJonathan Rdodríguez\r\nElectronic1\r\nDetails\r\nOrder Now\r\nCost: 33\r\nOld Cost:33\r\nMSI Gaming ProductModified 8RE-021XES Raider RGB Negro Portátil 39.6 cm (15.6 ) 1920 x 1080 Pixeles 2.20 GHz 8ª generación de procesadores Intel® Core™ i7 i7-8750H - Ordenador portátil(8ª generación de procesadores Intel® Core™ i7, 2.20 GHz, 39.6 cm 15.6 , 1920 x 1080 Pixeles, 16 GB, 1256 GB)\r\naJonathan Rdodríguez\r\nElectronic1\r\nDetails\r\nOrder Now\r\nCost: 33\r\nOld Cost:33\r\nhi\r\naJonathan Rodríguez\r\nElectronic1\r\nDetails\r\nOrder Now\r\nCost: 33\r\nOld Cost:33"));
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
        driver.Close();
        driver.Quit();
    }
    }

}
