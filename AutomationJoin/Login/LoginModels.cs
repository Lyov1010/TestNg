using AutomationJoin.MailinatorCreate;
using AutomationJoin.SignUp;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AutomationJoin.Login
{
   public class LoginModels
    {
        IWebDriver driver;
        public LoginModels(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void Login(string Em, string parol = "lyov1010")
        {          
            SignUpModels mod = new SignUpModels(driver);         
            Commands commands = new Commands(driver);
            //commands.IndexClick(LoginWebElements.login, 3);
            commands.Write(LoginWebElements.Email,Em);
            commands.Write(LoginWebElements.Pass, parol);
            commands.Click(LoginWebElements.Login);
            Thread.Sleep(2500);
            commands.AsserttBY_EL_GETTEXTIndex("Projects", By.CssSelector(".NavigationItem"), 0);
        }
        public void ResetLogin()
        {
            string AcoountLogin = "usernamee97659@harakirimail.com";
            string MailValue = "usernamee97659";
            Commands commands = new Commands(driver);
            commands.IndexClick(LoginWebElements.login, 3);
            commands.Click(LoginWebElements.Reset);
            Thread.Sleep(2000);
            commands.Write(LoginWebElements.Email, AcoountLogin);
            commands.Click(LoginWebElements.Login);
            commands.AsserttBY_EL_GETTEXT("We have e-mailed your password reset link!", By.CssSelector(".Notification-Message"));
            Thread.Sleep(2000);
            MailinatorModel mailinator = new MailinatorModel(driver);
            mailinator.MailinatorUrl();
            mailinator.Reset(MailValue);
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            commands.Write(LoginWebElements.pass, "lyov1010");
            commands.Write(LoginWebElements.confirmpass, "lyov1010");
            commands.Click(LoginWebElements.Login);
            //Login();
        }
    }
}
