using AutomationJoin.Login;
using AutomationJoin.NotSignedinHireNow;
using AutomationJoin.SignUp;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace AutomationJoin
{
    public class Tests
    {
        
        IWebDriver driver;
        [Test]
        [SetUp]
        public void Join()
        {
            driver = new ChromeDriver();
            SignUpModels models = new SignUpModels(driver);
            models.JoinUrl();
        }
        [Test]
        public void SignUp()
        {
            SignUpModels models = new SignUpModels(driver);
            models.SignUp();
        }
        [Test]
        public void Login()
        {
            driver.Url = "http://test.jointohire.com:3000/sign-in";
            LoginModels models = new LoginModels(driver);
            SignUpModels Email = new SignUpModels(driver);

            models.Login(Email.Email);
        }
        [Test]
        public void Reset()
        {
            LoginModels models = new LoginModels(driver);
            models.ResetLogin();
        }
        [Test]
        public void HireNowRegister()
        {
            HireNowModels models = new HireNowModels(driver);
            models.HireNowRegister();
        }
        [Test]
        public void HireNowSignIn()
        {
            HireNowModels models = new HireNowModels(driver);
            models.HireNowSignIn();
        }

        //[TearDown]
        //public void Close()
        //{
        //    driver.Quit();
        //}

    }
}