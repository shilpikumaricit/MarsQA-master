using System;
using System.Threading;
using MarsQA.Pages;
using MarsQA.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefination
{
    [Binding]
    public class AddProfile
    {
        IWebDriver driver = new ChromeDriver();

        string Url = "http://localhost:5000/";
        string Username = "shilpikumaricit@gmail.com";
        string Password = "Shilpi@01";


        [Given(@"login to Mars application as a seller")]
        public void GivenLoginToMarsApplicationAsASeller()
        {
            LoginPage loginpage = new LoginPage(driver);
            loginpage.login(Url, Username, Password);
            Thread.Sleep(5000);
        }

        [Given(@"navigate to profile page")]
        public void GivenNavigateToProfilePage()
        {
            Console.WriteLine("GivenNavigateToProfilePage");
        }

        [When(@"click on the edit button of Description")]
        public void WhenClickOnTheEditButtonOfDescription()
        {
            AddLanguage language = new AddLanguage(driver);
            language.Addlanguage(GenerateRandomString.random());
            Thread.Sleep(5000);
        }

        [Then(@"should be able to Add description")]
        public void ThenShouldBeAbleToAddDescription()
        {
            Console.WriteLine("ThenShouldBeAbleToAddDescription");
        }

        [Given(@"loging to Mars Application as a seller")]
        public void GivenLogingToMarsApplicationAsASeller()
        {
            Console.WriteLine("GivenLogingToMarsApplicationAsASeller");
        }

        [When(@"click on the edit button of discription")]
        public void WhenClickOnTheEditButtonOfDiscription()
        {
            Console.WriteLine("WhenClickOnTheEditButtonOfDiscription");
        }

        [When(@"seller should try to add empty valu in description field")]
        public void WhenSellerShouldTryToAddEmptyValuInDescriptionField()
        {
            Console.WriteLine("WhenSellerShouldTryToAddEmptyValuInDescriptionField");
        }

        [Then(@"seller should not able to add empty valu in discription field")]
        public void ThenSellerShouldNotAbleToAddEmptyValuInDiscriptionField()
        {
            Console.WriteLine("ThenSellerShouldNotAbleToAddEmptyValuInDiscriptionField");
        }

        [Given(@"as a seller loging to Mars Application")]
        public void GivenAsASellerLogingToMarsApplication()
        {
            Console.WriteLine("GivenAsASellerLogingToMarsApplication");
        }

        [Given(@"seller navigate to profile page")]
        public void GivenSellerNavigateToProfilePage()
        {
            Console.WriteLine("GivenSellerNavigateToProfilePage");
        }

        [When(@"seller click on the add language button")]
        public void WhenSellerClickOnTheAddLanguageButton()
        {
            Console.WriteLine("WhenSellerClickOnTheAddLanguageButton");
        }

        [Then(@"seller should able to add language")]
        public void ThenSellerShouldAbleToAddLanguage()
        {
            Console.WriteLine("ThenSellerShouldAbleToAddLanguage");
        }

        [Then(@"seller should not be able to add language")]
        public void ThenSellerShouldNotBeAbleToAddLanguage()
        {
            Console.WriteLine("ThenSellerShouldNotBeAbleToAddLanguage");
        }

        [AfterScenario("deleteTestItem")]
        public void DeleteTestItem()
        {
            driver.Quit();
        }
    }
}
