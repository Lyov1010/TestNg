using AutomationJoin.Login;
using AutomationJoin.MailinatorCreate;
using AutomationJoin.SignUp;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AutomationJoin.NotSignedinHireNow
{
  public  class HireNowModels
    {
        
        IWebDriver driver;
        public HireNowModels(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void HireNowRegister()
        {
            Random rd = new Random();
            string tiv = rd.Next(400, 1000000).ToString();
            string UrlNumber = rd.Next(1, 100).ToString();
            string rand = ("username" + tiv + "a");
            Commands commands = new Commands(driver);
            commands.IndexClick(HireNowWebELements.Freelancer,2);
            Thread.Sleep(4000);
            int NamesCount = driver.FindElements(By.CssSelector(".Button_outline")).Count;
            commands.IndexClick(HireNowWebELements.ProfileName, rd.Next(0, NamesCount));
            commands.Write(HireNowWebELements.JobName,rand);
            commands.Write(HireNowWebELements.JobDesc,rand+"--YES");
            string File = AppDomain.CurrentDomain.BaseDirectory + "\\" + "Screenshot_15.png";
            driver.FindElement(By.Name("attachments")).SendKeys(File);
            commands.Write(HireNowWebELements.Rate,"10");
            commands.Write(HireNowWebELements.Limit,"10");
            RegisterForHireNow();
            commands.AsserttBY_EL_GETTEXT(rand, By.CssSelector(".Text_lg"));
            commands.Click(By.CssSelector(".UserBlock-Item"));
            Thread.Sleep(500);
            commands.IndexClick(By.CssSelector(".Link"),6);
            Thread.Sleep(500);
            var Mail = driver.FindElements(By.CssSelector(".DescriptionList-Item_description"))[1].Text;
            commands.Click(By.CssSelector(".UserBlock-Item"));
            commands.IndexClick(By.CssSelector(".Link"), 8);


            commands.IndexClick(HireNowWebELements.Freelancer, 2);
            Thread.Sleep(4000);

            commands.IndexClick(HireNowWebELements.ProfileName, rd.Next(0, NamesCount));
            commands.Write(HireNowWebELements.JobName,"User Lyov");
            commands.Write(HireNowWebELements.JobDesc, rand+"--NO");
            driver.FindElement(By.Name("attachments")).SendKeys(File);
            commands.Write(HireNowWebELements.Rate, "10");
            commands.Write(HireNowWebELements.Limit, "10");
            commands.Click(By.CssSelector(".LinkButton_orange"));
            LoginModels login = new LoginModels(driver);
            login.Login(Mail);
            Thread.Sleep(1000);
            commands.AsserttBY_EL_GETTEXT("User Lyov", By.CssSelector(".Text_lg"));
        }
        public void HireNowSignIn()
        {
            Random rd = new Random();
            string tiv = rd.Next(400, 1000000).ToString();
            string UrlNumber = rd.Next(1, 100).ToString();
            string rand = ("username" + tiv + "a");
            Commands commands = new Commands(driver);
            commands.IndexClick(HireNowWebELements.Freelancer, 2);
            Thread.Sleep(4000);
            int NamesCount = driver.FindElements(By.CssSelector(".Button_outline")).Count;
            commands.IndexClick(HireNowWebELements.ProfileName, rd.Next(0, NamesCount));
            commands.Write(HireNowWebELements.JobName, "UserLyov");
            commands.Write(HireNowWebELements.JobDesc, rand);
            string File = AppDomain.CurrentDomain.BaseDirectory + "\\" + "Screenshot_15.png";
            driver.FindElement(By.Name("attachments")).SendKeys(File);
            commands.Write(HireNowWebELements.Rate, "10");
            commands.Write(HireNowWebELements.Limit, "10");
            LoginModels login = new LoginModels(driver);
        }
        public void RegisterForHireNow()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(5000, 100000);
            string Email = ("usernamee" + randomInt + "@harakirimail.com");
            string Em = "usernamee" + randomInt;
            Commands commands = new Commands(driver);
            commands.Write(WebElements.FirstName, "Lyov");
            commands.Write(WebElements.lastName, "Hambardzumyan");
            commands.Write(WebElements.email, Email);
            commands.Write(WebElements.password, "lyov1010");
            commands.Write(WebElements.confirmpassword, "lyov1010");
            IWebElement ele = driver.FindElements(By.CssSelector(".Checkbox-Label"))[1];
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", ele);
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
