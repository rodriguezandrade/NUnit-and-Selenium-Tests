using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using TestDatabase;
using System.Linq;

namespace Excersise_Selenium
{
  
    [TestClass]
   public class DB_VerifyUser
    {
        private TestDatabase.TestContext context = new TestDatabase.TestContext();

        [TestMethod]
        [Description ("Create a user")]
        [Owner("Jonathan")]
        [Priority(0)]
        public void DB_VerifyUser_TestCase()
        {
            
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("sign")).Click();
            driver.FindElement(By.Id("username")).SendKeys("master@mail.com");
            driver.FindElement(By.Id("password")).SendKeys("P@ssw0rd");
            driver.FindElement(By.Id("submitSign")).Click();
            Thread.Sleep(3000);
            var usernameApp = driver.FindElement(By.Id("nameuser")).Text;
            var userAdmin = new User();
            using (var db = new TestDatabase.TestContext())
            {
                userAdmin = db.Users.Where(p => p.Id == 40).FirstOrDefault<User>();
            }
             var username = userAdmin;
            Assert.IsTrue(username.UserName.Contains(usernameApp));
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            driver.Close();
            driver.Quit();
        }
        [TestMethod]
        [Description("Verify Mail")]
        [Owner("Jonathan")]
        [Priority(0)]
        public void DB_VerifyMail_TestCase()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("sign")).Click();
            driver.FindElement(By.Id("username")).SendKeys("master@mail.com");
            driver.FindElement(By.Id("password")).SendKeys("P@ssw0rd");
            driver.FindElement(By.Id("submitSign")).Click();
            Thread.Sleep(3000);
            var mail = driver.FindElement(By.Id("mail")).Text;
            var MailDb = new User();
            using (var db = new TestDatabase.TestContext())
            {
                MailDb = db.Users.Where(p => p.Email == "master@mail.com").FirstOrDefault<User>();
            }
            var MailAdmin = MailDb;
            Assert.IsTrue(MailAdmin.Email.Contains(mail));
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        [Description("Verify Role")]
        [Owner("Jonathan")]
        [Priority(0)]
        public void DB_VerifyRole_TestCase()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("sign")).Click();
            driver.FindElement(By.Id("username")).SendKeys("master@mail.com");
            driver.FindElement(By.Id("password")).SendKeys("P@ssw0rd");
            driver.FindElement(By.Id("submitSign")).Click();
            Thread.Sleep(3000);
            var role = driver.FindElement(By.Id("role")).Text;
            var RoleDb = new Role();
            using (var db = new TestDatabase.TestContext())
            {
                RoleDb = db.Roles.Where(p => p.Name == "admin").FirstOrDefault<Role>();
            }
            var RoleAdmin = RoleDb;
            Assert.IsTrue(RoleAdmin.Name.Contains(role));
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            driver.Close();
            driver.Quit();
        }


        [TestMethod]
        [Description("EditProduct")]
        [Owner("Jonathan")]
        [Priority(0)]
        public void DB_EditProduct_VerifyProductEdited_TestCase()
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
            driver.FindElement(By.Id("1134")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("name")).Clear();
            driver.FindElement(By.Id("name")).SendKeys("MSI Gaming ProductModified 8RE-021XES Raider RGB Negro Portátil 39.6 cm (15.6 ) 1920 x 1080 Pixeles 2.20 GHz 8ª generación de procesadores Intel® Core™ i7 i7-8750H - Ordenador portátil(8ª generación de procesadores Intel® Core™ i7, 2.20 GHz, 39.6 cm 15.6 , 1920 x 1080 Pixeles, 16 GB, 1256 GB)");
            driver.FindElement(By.Id("detail")).Clear();
            driver.FindElement(By.Id("detail")).SendKeys("aJonathan Rdodríguez");
            driver.FindElement(By.Id("cost")).Clear();
            driver.FindElement(By.Id("cost")).SendKeys("33");
            driver.FindElement(By.Id("amount")).Clear();
            driver.FindElement(By.Id("amount")).SendKeys("33");
            driver.FindElement(By.Id("status")).Clear();
            driver.FindElement(By.Id("status")).SendKeys("1");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("save")).Click();
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("productAdministrator")).Click();
            Thread.Sleep(2000);
            var product = driver.FindElement(By.Id("cost33")).Text;
            decimal prCost = decimal.Parse(product);
            var ProductDb = new Product();
            using (var db = new TestDatabase.TestContext())
            {
                ProductDb = db.Products.Where(p => p.Id == 1134).FirstOrDefault<Product>();
            }
            var ProductResult= ProductDb;
            Assert.IsTrue(ProductResult.Cost == prCost);
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        [Description("SignUp")]
        [Owner("Jonathan")]
        [Priority(0)]
        public void DB_SignUp_TestCase()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("signup")).Click();
            driver.FindElement(By.Id("name")).SendKeys("yworld");
            driver.FindElement(By.Id("email")).SendKeys("yworld@mail.com");
            driver.FindElement(By.Id("password")).SendKeys("P@ssw0rd");
            driver.FindElement(By.Id("signupButtom")).Click();
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            driver.FindElement(By.Id("sign")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("username")).SendKeys("yworld@mail.com");
            driver.FindElement(By.Id("password")).SendKeys("P@ssw0rd");
            driver.FindElement(By.Id("submitSign")).Click();
            Thread.Sleep(3000);
            var user = driver.FindElement(By.Id("nameuser")).Text;
            var Userdb = new User();
            using (var db = new TestDatabase.TestContext())
            {
                Userdb = db.Users.Where(p => p.UserName == "yworld").FirstOrDefault<User>();
            }
            var UserResult = Userdb;
            Assert.IsTrue(UserResult.UserName == user);
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        [Description("Checkout")]
        [Owner("Jonathan")]
        [Priority(0)]
        public void DB_ReviewCheckout_TestCase()
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
            var Checkout = driver.FindElement(By.Id("normal")).Text;

            var Cartdb = new CartItem();
            using (var db = new TestDatabase.TestContext())
            {
                Cartdb = db.CartItems.FirstOrDefault<CartItem>();
            }
            var CartdbResult = Cartdb;
            Assert.IsTrue(CartdbResult == null);
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        [Description("FilterbyPagination")]
        [Owner("Jonathan")]
        [Priority(0)]
        public void Db_FilterProductByPagination_TestCase()
        {
            var numberElementsContext = 0;
            int numberPagining =3;
            string nameProduct = "MSI Gaming";
            using (var db = new TestDatabase.TestContext())
            {
                numberElementsContext = db.Products.Where(p => p.Name.Contains(nameProduct)).ToList().Take(numberPagining).Count();
            }
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            Thread.Sleep(2000);
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("paginationId")).Clear();
            driver.FindElement(By.Id("paginationId")).SendKeys(numberPagining.ToString());
            driver.FindElement(By.Id("searchProduct")).SendKeys(nameProduct);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("SearchTextBox")).Click();
            var numberProducts = driver.FindElements(By.Id("ClassProduct")).Count;
            Assert.IsTrue(numberProducts == numberElementsContext);
            Thread.Sleep(4000);
            driver.Close();
        }

        [TestMethod]
        [Description("VerifyCart")]
        [Owner("Jonathan")]
        [Priority(0)]
        public void Db_AddToCartVerifyInDatabase_TestCase()
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
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("Cart")).Click();
            Thread.Sleep(2000);
            var Checkout = driver.FindElement(By.Id("amount")).Text;
            int prCheckout = int.Parse(Checkout);
            var Cartdb = new CartItem();
            using (var db = new TestDatabase.TestContext())
            {
             Cartdb = db.CartItems.Where(p => p.UserId == 40).FirstOrDefault<CartItem>();
            } 
            Assert.IsTrue(Cartdb.Amount == prCheckout);
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            driver.Close();
            driver.Quit();
        }


        [TestMethod]
        [Description("Verify SubTotal")]
        [Owner("Jonathan")]
        [Priority(0)]
        public void Db_VerifySubTotalCartDatabase_TestCase()
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
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("Cart")).Click();
            Thread.Sleep(2000);
            var Checkout = driver.FindElement(By.Id("subtotal")).Text;
            int SubTotal = int.Parse(Checkout);
            var Cartdb = new CartItem();
            using (var db = new TestDatabase.TestContext())
            {
                Cartdb = db.CartItems.Where(p => p.UserId == 40).FirstOrDefault<CartItem>();
            }
            Assert.IsTrue(Cartdb.SubTotal == SubTotal);
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        [Description("CountProducts")]
        [Owner("Jonathan")]
        [Priority(0)]
        public void Db_CountProducts_TestCase()
        {
            var numberElementsContext = 0;
       
            using (var db = new TestDatabase.TestContext())
            {
                numberElementsContext = db.Products.ToList().Count();
            }
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:54467/#/home");
            Thread.Sleep(2000);
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            var numberProducts = driver.FindElements(By.Id("ClassProduct")).Count;
            Assert.IsTrue(numberProducts == numberElementsContext);
            Thread.Sleep(4000);
            driver.Close();
        }
    }

}
