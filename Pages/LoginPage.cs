using System;
using OpenQA.Selenium;

namespace MarsQA.Pages
{
    public class LoginPage
    {
        IWebDriver driver;

        public LoginPage( IWebDriver driver)
        {
            this.driver = driver;
        }

        public void login(string Url, string Username, string Password)
        {
            this.driver.Navigate().GoToUrl(Url);
            //click on sign botton
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//a[@class='item'][contains(.,'Sign In')]")).Click();
            driver.FindElement(By.Name("email")).SendKeys(Username);
            driver.FindElement(By.Name("password")).SendKeys(Password);
            driver.FindElement(By.XPath("//button[@class='fluid ui teal button'][contains(.,'Login')]")).Click();
        }

    }


}

