using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationJoin.SignUp
{
    public class WebElements
    {
        
        public static By Signup = By.CssSelector(".NavigationItem");
        public static By FirstName = By.Name("firstName");
        public static By lastName = By.Name("lastName");
        public static By email = By.Name("email");
        public static By password = By.Name("password");
        public static By confirmpassword = By.Name("passwordConfirmation");
        public static By Location = By.CssSelector(".Select-Search");
        public static By SelectDropDown = By.CssSelector(".Select-Dropdown>div>div>button:nth-child(10)");
        public static By CHeckBox = By.CssSelector(".Checkbox_md");
        public static By SignUp = By.CssSelector(".Button_orange");
        public static By ThanksForYourSignUp = By.CssSelector(".FeedbackLayout-Title");
        public static By Account = By.CssSelector(".NavigationMenu-Button");
        public static By AccountClick = By.CssSelector(".List-Item");
    }
}
