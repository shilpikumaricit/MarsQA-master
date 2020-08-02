using System;
using MarsQA.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MarsQA.Pages
{
    public class AddLanguage

    {
        private IWebDriver driver;
        private DropDownSelector dropDownSelector;

        public AddLanguage(IWebDriver driver)
        {
            this.driver = driver;
            this.dropDownSelector = new DropDownSelector(driver);
        }

        public void Addlanguage(string language)
        {
            string XPath = "//select[@class='ui dropdown']";
            string indexOfElement = "Basic";
            driver.FindElement(By.XPath("(//div[contains(.,'Add New')])[11]")).Click();
            driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).SendKeys(language);
            this.dropDownSelector.getElementSelected(XPath, indexOfElement);
            //SelectElement userRole = new SelectElement(driver.FindElement(By.XPath("//select[@class='ui dropdown']")));
            //userRole.SelectByText("Basic");
            driver.FindElement(By.XPath("//input[contains(@class,'ui teal button')]")).Click();
            VerifySkill(language);
        }

        private void VerifySkill(string skillName)
        {
            Console.WriteLine("");
        }
    }
}


