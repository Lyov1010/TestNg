using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationJoin.MailinatorCreate
{
   public class MailinatorWebElements
    {
        public static By WriteEmail = By.Id("inbox-name");
        public static By EmailSubmit = By.CssSelector(".icon-envelope");
        public static By Verification = By.CssSelector(".button-blue");

    }

}
