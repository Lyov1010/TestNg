using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationJoin.Login
{
   public class LoginWebElements
    {
        public static By Email = By.Name("email");
        public static By Pass = By.Name("password");
        public static By Login = By.CssSelector(".Button_orange");
        public static By Reset = By.PartialLinkText("Forgot password?");
        public static By confirm = By.Name("passwordConfirmation");
        public static By Messages = By.CssSelector(".NavigationItem");
        public static By InMailRes = By.PartialLinkText("Reset Password");
        public static By pass = By.Name("password");
        public static By confirmpass = By.Name("passwordConfirmation");
        public static By login = By.CssSelector(".NavigationItem");
    }
}
