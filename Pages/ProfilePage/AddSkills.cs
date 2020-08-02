using System;
using OpenQA.Selenium;

namespace MarsQA.Pages.ProfilePage
{
    public class AddSkills
    {private IWebDriver driver;
        public AddSkills(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void Addskillsets(string skill)
        {
         driver.FindElement(By.XPath("//a[@class='item active'][contains(.,'Skills')]")).Click();

        }
    }
}

