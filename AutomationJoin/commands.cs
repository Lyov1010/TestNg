using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutomationJoin
{
    public class Commands
    {
        IWebDriver driver;
        public Commands(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void Click(By by)
        {
            Wait(by);
            driver.FindElement(by).Click();

        }
        public void InputClear(By by)
        {
            Wait(by);
            driver.FindElement(by).Clear();
        }
        public void Enter(By by)
        {
            Wait(by);
            driver.FindElement(by).SendKeys(Keys.Enter);
        }
        public void IndexClick(By by, int index)
        {

            Wait(by);
            driver.FindElements(by)[index].Click();
        }
        public void IndexSendKeys(By by, int index, string text)
        {
            Wait(by);
            driver.FindElements(by)[index].SendKeys(text);
        }
        public void Write(By by, string text)
        {
            Wait(by);
            driver.FindElement(by).SendKeys(text);
        }
        public void Wait(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            wait.Until(drw => drw.FindElement(by));
        }
        public void Wait1()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(d => d.FindElement(By.CssSelector(".click-set")));
        }

        public void AsserttBY_EL_GETTEXT(string text, By by)
        {
            Wait(by);
            string CompText = driver.FindElement(by).Text;
            Assert.AreEqual(text, CompText);
        }
        public void AsserttBY_EL_GETTEXTIndex(string text, By by, int index)
        {
            Wait(by);
            string CompText = driver.FindElements(by)[index].Text;
            Assert.AreEqual(text, CompText);
        }
        public void AsserttBY_URl(string text)
        {
            Thread.Sleep(2000);
            string Url = driver.Url;
            Assert.AreEqual(text, Url);
        }
        public string GetText(By by)
        {
            Wait(by);
            string Text = driver.FindElement(by).Text;
            return Text;
        }
     


    }
}
