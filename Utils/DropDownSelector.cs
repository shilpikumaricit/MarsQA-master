using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MarsQA.Utils
{
    public class DropDownSelector
    {
        private IWebDriver driver;
        public DropDownSelector(IWebDriver driver)
        {
            this.driver = driver;
        }

            
        public SelectElement getElementSelected(string Xpath, string indexOfElement)
        {
            SelectElement selectElement = new SelectElement(driver.FindElement(By.XPath(Xpath)));
            selectElement.SelectByText(indexOfElement);
            return selectElement;
        }
    }
}
