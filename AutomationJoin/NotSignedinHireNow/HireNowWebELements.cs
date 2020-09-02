using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationJoin.NotSignedinHireNow
{
   public class HireNowWebELements
    {
        public static By Freelancer = By.CssSelector(".NavigationItem");
        public static By ProfileName = By.CssSelector(".Button_outline");
        public static By JobName = By.Name("jobName");
        public static By JobDesc = By.Name("jobDesc");
        public static By Rate = By.Name("rate");
        public static By Limit = By.Name("limit");
    }
}

    
    
    