using AutomationJoin.Login;
using AutomationJoin.MailinatorCreate;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AutomationJoin.SignUp
{
  public  class SignUpModels
    {
        IWebDriver driver;

        public SignUpModels(IWebDriver driver)
        {
            this.driver = driver;
        }

        private string email; // field
        public string Email   // property
        {
            get { return email; }
            set { email = value; }
        }


        public void JoinUrl()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "http://test.jointohire.com:3000/";
            Thread.Sleep(1200);
            driver.FindElement(By.TagName("body")).SendKeys("Keys.ESCAPE");
        }
        public void SignUp() 
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(5000, 100000);
            Email = ("usernamee" + randomInt + "@harakirimail.com");
            string Em = "usernamee" + randomInt;
            Commands commands = new Commands(driver);
            commands.IndexClick(WebElements.Signup, 4);
            commands.Write(WebElements.FirstName, "Lyov");
            commands.Write(WebElements.lastName, "Hambardzumyan");
            commands.Write(WebElements.email, Email);
            commands.Write(WebElements.password, "lyov1010");
            commands.Write(WebElements.confirmpassword, "lyov1010");
            commands.Click(WebElements.Location);
            int count = driver.FindElements(By.CssSelector(".Select-Dropdown>div>div>button")).Count;
            commands.IndexClick(By.CssSelector(".Select-Dropdown>div>div>button"), randomGenerator.Next(1, count));
            commands.Click(WebElements.CHeckBox);
            commands.Click(WebElements.SignUp);
            commands.AsserttBY_EL_GETTEXT("Thanks for your sign up", By.CssSelector(".FeedbackLayout-Title"));
            MailinatorModel mod = new MailinatorModel(driver);
            mod.MailinatorUrl();
            mod.Mailinator(Em);

            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Thread.Sleep(1500);
            commands.AsserttBY_EL_GETTEXT("Projects", By.CssSelector(".Panel-Title"));
        }
    }
}
