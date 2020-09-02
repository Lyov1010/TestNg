using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutomationJoin.MailinatorCreate
{
   public class MailinatorModel
    {
        IWebDriver driver;
        public MailinatorModel(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void MailinatorUrl()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://harakirimail.com/";
        }

        public void Mailinator(string RandomMail)
        {
            Commands commands = new Commands(driver);
            commands.Write(MailinatorWebElements.WriteEmail, RandomMail);
            Thread.Sleep(4000);
            commands.Click(MailinatorWebElements.EmailSubmit);
            driver.FindElements(By.CssSelector("#mail_list_body>tr>td"))[1].FindElement(By.CssSelector("a>div")).Click();
            commands.Click(MailinatorWebElements.Verification);
    }
        public void Reset(string RandEmail)
        {
            Commands commands = new Commands(driver);
            commands.Write(MailinatorWebElements.WriteEmail, RandEmail);
            Thread.Sleep(4000);
            commands.Click(MailinatorWebElements.EmailSubmit);
            Thread.Sleep(1000);
            driver.FindElements(By.CssSelector("#mail_list_body>tr>td"))[1].FindElement(By.CssSelector("a>div")).Click();
            commands.Click(MailinatorWebElements.Verification);
        }
    }
}
